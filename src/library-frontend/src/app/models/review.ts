import { User } from "./user";

export interface Review {
  id: string;
  bookId: string;
  reviewerId: string;
  reviewText: string;
  rating: number;
  datePosted: Date;
  reviewer: User;
}
export interface ReviewFormValues {
  bookId: string;
  content: string;
  rating: number;
}
