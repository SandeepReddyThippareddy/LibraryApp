import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import HomePage from './features/home/HomePage';
import BookDashboard from './features/books/dashboard/BookDashboard';
import BookForm from './features/books/form/BookForm';
import LoginForm from './features/account/LoginForm';
import RegisterForm from './features/account/RegisterForm';
import ProfilePage from './features/profiles/ProfilePage';

export default function App() {
    return (
        <Router>
            <Routes>
                <Route path="/" element={<HomePage />} />
                <Route path="/books" element={<BookDashboard />} />
                <Route path="/login" element={<LoginForm />} />
                <Route path="/register" element={<RegisterForm />} />
                <Route path="/profiles/:username" element={<ProfilePage />} />
                <Route path="/books/create" element={<BookForm />} />
                <Route path="/books/edit/:id" element={<BookForm />} />
            </Routes>
        </Router>
    );
}
