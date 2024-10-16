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
  isBorrowed? : boolean;
  borrowers?: Borrower[];
}

export interface BookFormValues {
  title?: string; 
  description?: string;
  category?: string;
  publicationDate?: Date | null;
  ISBN?: string;
  coverImage?: string;
  publisher?: string;
  author?: string;
}
