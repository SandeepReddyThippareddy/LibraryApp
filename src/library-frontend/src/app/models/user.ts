import { Book } from "./book";
import { Review } from "./review";

export interface User {
  id: string;
  username: string;
  email: string;
  role: "Customer" | "Librarian";
  borrowedBooks?: Book[];
  reviews?: Review[];
  profileImage?: string;
  token: string;
  displayName: string;
}
export interface UserFormValues {
  email: string;
  password: string;
  displayName?: string;
  username?: string;
  isLibrarian?: boolean;
}
