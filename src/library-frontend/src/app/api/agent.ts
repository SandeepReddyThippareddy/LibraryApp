import axios, { AxiosResponse } from "axios";
import { Book, BookFormValues } from "../models/book";
import { store } from "../../features/store";
import { User, UserFormValues } from "../models/user";
import { Review, ReviewFormValues } from "../models/review";
import { Profile } from "../models/profile";

const sleep = (delay: number) => {
  return new Promise((resolve) => {
    setTimeout(resolve, delay);
  });
};

// Base URL for API requests
axios.defaults.baseURL = process.env.REACT_APP_API_URL;

// Intercept requests and include JWT token
axios.interceptors.request.use((config) => {
  const token = store.commonStore.token;
  if (token) {
    config.headers.Authorization = `Bearer ${token}`;
  }
  return config;
});

// Intercept responses for errors and simulate delay
axios.interceptors.response.use(
  async (response) => {
    await sleep(500);
    return response;
  },
  (error) => {
    const { data, status, config, headers } = error.response;

    if (status === 401) {
      console.error("Unauthorized access - invalid token");
    }

    if (status === 500) {
      console.error("Server error:", data);
    }

    return Promise.reject(error);
  }
);

// Extract the response body
const responseBody = <T>(response: AxiosResponse<T>) => response.data;

// Common request methods
const requests = {
  get: <T>(url: string) => axios.get<T>(url).then(responseBody),
  post: <T>(url: string, body: {}) =>
    axios.post<T>(url, body).then(responseBody),
  put: <T>(url: string, body: {}) => axios.put<T>(url, body).then(responseBody),
  delete: <T>(url: string) => axios.delete<T>(url).then(responseBody),
};

// API for User Authentication
const UserApi = {
  login: (creds: UserFormValues) =>
    requests.post<User>("/account/login", creds).then((user) => {
      store.commonStore.setToken(user.token ?? null);
      return user;
    }),
  register: (creds: UserFormValues) =>
    requests.post<User>("/account/register", creds).then((user) => {
      store.commonStore.setToken(user.token ?? null);
      return user;
    }),
  current: () => requests.get<User>("/account"),
};

// API for Book Management
const BookApi = {
  list: () => requests.get<Book[]>("/book"),
  details: (id: string) => requests.get<Book>(`/book/${id}`),
  create: (book: BookFormValues) => requests.post<Book>("/book", book),
  updateBook: (book: Book) => requests.put<void>(`/book/${book.id}`, book),
  updateBookStatus: (id: string, isBorrowed: boolean) => {
    return requests.put<void>(`/book/${id}/borrow`, { isBorrowed });
  },
  delete: (id: string) => requests.delete<void>(`/book/${id}`),
};


// Review API for interacting with reviews
const ReviewApi = {
  list: (bookId: string) => requests.get<Review[]>(`/reviews/${bookId}`),
  create: (review: Review) => requests.post<Review>("/reviews", review),
  update: (review: Review) =>
    requests.put<Review>(`/reviews/${review.id}`, review),
  delete: (id: string) => requests.delete<void>(`/reviews/${id}`),
};

// API for Profiles
const ProfileApi = {
  get: (username: string) => requests.get<Profile>(`/profiles/${username}`),
};

// Export the APIs to be used in the application
export default {
  UserApi,
  BookApi,
  ReviewApi,
  ProfileApi,
};
