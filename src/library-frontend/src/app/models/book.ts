import { Borrower } from "./borrower";
import { Review } from "./review";

export interface Book {
  id: string;
  title: string;
  author: string;
  description: string;
  category: string;
  publicationDate: Date | null;
  ISBN: string;
  coverImage: string;
  publisher: string;
  reviews?: Review[];
  isBorrowed?: boolean;
  borrowers?: Borrower[];
  pageCount: number;
}

export interface BookFormValues {
  id: string;
  title: string;
  author: string;
  description: string;
  category: string;
  publicationDate: Date | null;
  ISBN: string;
  pageCount: number;
  coverImage: string;
  publisher: string;
}

export const defaultBookFormValues: BookFormValues = {
  id: "",
  title: "",
  author: "",
  description: "",
  coverImage: "",
  publisher: "",
  publicationDate: null,
  category: "",
  ISBN: "",
  pageCount: 0,
};
