import { createBrowserRouter, Navigate, RouteObject } from "react-router-dom";
import ProfilePage from "../../features/profiles/ProfilePage";
import App from "../layout/App";
import RequireAuth from "./RequireAuth";
import BookDashboard from "../../features/books/dashboard/BookDashboard";
import ServerError from "../../features/errors/ServerError";
import NotFound from "../../features/errors/NotFound";
import BookDetails from "../../features/books/details/BookDetails";

export const routes: RouteObject[] = [
  {
    path: "/",
    element: <App />,
    children: [
      {
        element: <RequireAuth />,
        children: [
          { path: "books", element: <BookDashboard /> },
          { path: "book/:id", element: <BookDetails /> },
          // {path: 'createBook', element: <EventForm key='create' />},
          // {path: 'manage/:id', element: <EventForm key='manage' />},
          { path: "profiles/:username", element: <ProfilePage /> },
        ],
      },
      { path: "not-found", element: <NotFound /> },
      { path: "server-error", element: <ServerError /> },
      { path: "*", element: <Navigate replace to="/not-found" /> },
    ],
  },
];

export const router = createBrowserRouter(routes);
