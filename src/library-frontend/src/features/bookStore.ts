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

  setPredicate = (key: string, value: string | boolean) => {
    this.predicate.set(key, value);
    // Trigger filtering logic based on the updated predicate
    this.filterBooks();
  };

  get filteredBooks() {
    let filteredBooks = Array.from(this.bookRegistry.values());

    // Apply filters
    if (this.predicate.has("all") && this.predicate.get("all") === "true") {
      return filteredBooks;
    }
    if (this.predicate.has("isBorrowed")) {
      filteredBooks = filteredBooks.filter((book) => book.isBorrowed);
    }
    if (this.predicate.has("title")) {
      filteredBooks = filteredBooks.filter((book) =>
        book.title.toLowerCase().includes(this.predicate.get("title")?.toLowerCase() ?? "")
      );
    }

    return filteredBooks;
  }

  filterBooks = () => {
    // This will automatically react in the UI when `filteredBooks` getter is called
  };


  clearSelectedBook = () => {
    this.selectedBook = undefined;
  };

  // Update book status (borrowed or returned)
  updateBookStatus = async (id: string, isBorrowed: boolean) => {
    this.loading = true;
    try {
      // Await the API call
      await agent.BookApi.updateBookStatus(id, isBorrowed);

      // Update local state in MobX store
      runInAction(() => {
        const book = this.bookRegistry.get(id);
        if (book) {
          book.isBorrowed = isBorrowed;
        }
        this.loading = false;
      });
    } catch (error: any) {
      runInAction(() => {
        this.loading = false;
      });
      if (error.response && error.response.status === 401) {
        alert("You are not authorized to perform this action.");
      } else if (error.response && error.response.status === 400) {
        alert("There was an error with your request.");
      } else {
        console.error(error);
        alert("Something went wrong.");
      }
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

  createBook = async (bookFormValues: BookFormValues) => {
    this.loading = true;
    try {
      const newBook = await agent.BookApi.create(bookFormValues);
      runInAction(() => {
        this.bookRegistry.set(newBook.id, newBook);
        this.selectedBook = newBook;
      });
      return newBook;
    } catch (error) {
      console.log(error);
    } finally {
      this.loading = false;
    }
  };
  

  updateBook = async (bookFormValues: BookFormValues) => {
    this.loading = true;
    try {
      const updatedBook: Book = {
        id: this.selectedBook?.id || uuid(),
        title: bookFormValues.title || this.selectedBook?.title || "",
        author: bookFormValues.author || this.selectedBook?.author || "",
        description: bookFormValues.description || this.selectedBook?.description || "",
        category: bookFormValues.category || this.selectedBook?.category || "",
        publicationDate: bookFormValues.publicationDate || this.selectedBook?.publicationDate || null,
        ISBN: bookFormValues.ISBN || this.selectedBook?.ISBN || "", 
        pageCount: bookFormValues.pageCount || this.selectedBook?.pageCount || 0,
        coverImage: bookFormValues.coverImage || this.selectedBook?.coverImage || "",
        publisher: bookFormValues.publisher || this.selectedBook?.publisher || "",
        reviews: this.selectedBook?.reviews || [], 
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
}
