import { makeAutoObservable, runInAction } from "mobx";
import { store } from "./store";
import { User, UserFormValues } from "../app/models/user";
import agent from "../app/api/agent";
import { router } from "../app/router/Routes";

export default class UserStore {
    user: User | null = null;

    constructor() {
        makeAutoObservable(this)
    }

    get isLoggedIn() {
        return !!this.user;
    }

    login = async (creds: UserFormValues) => {
        try {
            const user = await agent.UserApi.login(creds);
            store.commonStore.setToken(user.token);
            runInAction(() => this.user = user);
            router.navigate('/books');
            store.modalStore.closeModal();
        } catch (error) {
            throw error;
        }
    }

    register = async (creds: UserFormValues) => {
        try {
            const user = await agent.UserApi.register(creds);
            store.commonStore.setToken(user.token);
            runInAction(() => this.user = user);
            router.navigate('/books');
            store.modalStore.closeModal();
        } catch (error) {
            throw error;
        }
    }


    logout = () => {
        store.commonStore.setToken(null);
        this.user = null;
        router.navigate('/');
    }

    getUser = async () => {
        try {
            const user = await agent.UserApi.current();
            runInAction(() => this.user = user);
        } catch (error) {
            console.log(error);
        }
    }

    setDisplayName = (name: string) => {
        if (this.user) this.user.displayName = name;
    }
}