import { makeAutoObservable, runInAction } from "mobx";
import { Book, BookFormValues } from "../app/models/book";
import agent from "../app/api/agent";
import { v4 as uuid } from "uuid";

export default class BookStore {
  bookRegistry = new Map<string, Book>();
  selectedBook: Book | undefined = undefined;
  loadingInitial = false;
  loading = false;
  predicate = new Map();

  constructor() {
    makeAutoObservable(this);
  }

  clearSelectedBook = () => {
    this.selectedBook = undefined;
};

  get groupedBooks() {
    return Object.entries(
      this.booksByCategory.reduce((books, book) => {
        const category = book.category || "Other";
        books[category] = books[category] ? [...books[category], book] : [book];
        return books;
      }, {} as { [key: string]: Book[] })
    );
  }


  get booksByCategory() {
    return Array.from(this.bookRegistry.values());
  }

  // Update book status (borrowed or returned)
  updateBookStatus = async (id: string, isBorrowed: boolean) => {
    this.loading = true;
    try {
      // Make API request to update the book status
      await agent.BookApi.updateBookStatus(id, isBorrowed);

      // Run action to update the local state
      runInAction(() => {
        const book = this.bookRegistry.get(id);
        if (book) {
          book.isBorrowed = isBorrowed;
        }
        this.loading = false;
      });
    } catch (error) {
      console.log(error);
      runInAction(() => {
        this.loading = false;
      });
    }
  };


  // Load all books from the API
  loadBooks = async () => {
    this.setLoadingInitial(true);
    try {
      const books = await agent.BookApi.list();
      runInAction(() => {
        books.forEach((book) => {
          this.bookRegistry.set(book.id, book);
        });
      });
    } catch (error) {
      console.log(error);
    } finally {
      this.setLoadingInitial(false);
    }
  };

  // Load a specific book by its ID
  loadBook = async (id: string) => {
    let book = this.getBook(id);
    if (book) {
      this.selectedBook = book;
      return book;
    } else {
      this.setLoadingInitial(true);
      try {
        book = await agent.BookApi.details(id);
        runInAction(() => {
          this.selectedBook = book;
        });
        return book;
      } catch (error) {
        console.log(error);
      } finally {
        this.setLoadingInitial(false);
      }
    }
  };

  // Create a new book
  createBook = async (bookFormValues: BookFormValues) => {
    this.loading = true;
    try {
      const newBook: Book = {
        ...bookFormValues,
        id: uuid(), 
        title: bookFormValues.title || "",
        author: bookFormValues.author || "",
        description: bookFormValues.description || "",
        category: bookFormValues.category || "",
        publicationDate: bookFormValues.publicationDate || null,
        ISBN: bookFormValues.ISBN || "",
        coverImage: bookFormValues.coverImage || "",
        publisher: bookFormValues.publisher || "",
      };

      await agent.BookApi.create(newBook);
      runInAction(() => {
        this.bookRegistry.set(newBook.id, newBook);
        this.selectedBook = newBook;
      });
    } catch (error) {
      console.log(error);
    } finally {
      this.loading = false;
    }
  };

  // Update an existing book
  updateBook = async (bookFormValues: BookFormValues) => {
    this.loading = true;
    try {
      const updatedBook: Book = {
        id: this.selectedBook?.id || uuid(), // Ensure that id is always defined
        title: bookFormValues.title || this.selectedBook?.title || "",
        author: bookFormValues.author || this.selectedBook?.author || "",
        description:
          bookFormValues.description || this.selectedBook?.description || "",
        category: bookFormValues.category || this.selectedBook?.category || "",
        publicationDate:
          bookFormValues.publicationDate ||
          this.selectedBook?.publicationDate ||
          null,
        ISBN: bookFormValues.ISBN || this.selectedBook?.ISBN || "",
        coverImage:
          bookFormValues.coverImage || this.selectedBook?.coverImage || "",
        publisher:
          bookFormValues.publisher || this.selectedBook?.publisher || "",
        reviews: this.selectedBook?.reviews || [], // Handle reviews, if necessary
      };

      await agent.BookApi.updateBook(updatedBook);
      runInAction(() => {
        this.bookRegistry.set(updatedBook.id, updatedBook);
        this.selectedBook = updatedBook;
      });
    } catch (error) {
      console.log(error);
    } finally {
      this.loading = false;
    }
  };

  // Delete a book
  deleteBook = async (id: string) => {
    this.loading = true;
    try {
      await agent.BookApi.delete(id);
      runInAction(() => {
        this.bookRegistry.delete(id);
      });
    } catch (error) {
      console.log(error);
    } finally {
      this.loading = false;
    }
  };

  // Helper function to get a book from the registry by ID
  private getBook = (id: string) => {
    return this.bookRegistry.get(id);
  };

  // Helper function to set the loading state
  setLoadingInitial = (state: boolean) => {
    this.loadingInitial = state;
  };

  // Filtering using predicates
  setPredicate = (key: string, value: string) => {
    this.predicate.set(key, value);
  };
}
