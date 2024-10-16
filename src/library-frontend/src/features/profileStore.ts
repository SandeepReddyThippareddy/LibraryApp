import { makeAutoObservable, runInAction } from "mobx";
import { Profile } from "../app/models/profile";
import agent from "../app/api/agent";

export default class ProfileStore {
    profile: Profile | null = null;
    loadingProfile = false;
    uploading = false;

    constructor() {
        makeAutoObservable(this);
    }

    loadProfile = async (username: string) => {
        this.loadingProfile = true;
        try {
            const profile = await agent.ProfileApi.get(username);
            runInAction(() => {
                this.profile = profile;
                this.loadingProfile = false;
            });
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.loadingProfile = false;
            });
        }
    };
}
