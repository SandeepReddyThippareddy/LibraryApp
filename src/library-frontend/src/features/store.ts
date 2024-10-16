import { createContext, useContext } from "react";
import BookStore from "./bookStore";
import UserStore from "./userStore";
import CommonStore from "./commonStore";
import ReviewStore from "./reviewStore";
import ProfileStore from "./profileStore";
import ModalStore from "./modalStore";
import CommentStore from "./commentStore";

interface Store {
    bookStore: BookStore;
    userStore: UserStore;
    commonStore: CommonStore;
    profileStore: ProfileStore;
    reviewStore: ReviewStore;
    modalStore: ModalStore;
    commentStore: CommentStore;
}

export const store: Store = {
    bookStore: new BookStore(),
    userStore: new UserStore(),
    commonStore: new CommonStore(),
    profileStore: new ProfileStore(),
    reviewStore: new ReviewStore(),
    modalStore: new ModalStore(),
    commentStore: new CommentStore()
}

export const StoreContext = createContext(store);

export function useStore() {
    return useContext(StoreContext);
}
