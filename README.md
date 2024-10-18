# Book Management Application

This is a **Book Management Application** that allows users to manage books in a library system. It features role-based access control (RBAC), where Librarians can create, edit, and delete books, and Students can borrow and return books. This application is built using **React**, **MobX**, **TypeScript**, **Formik**, **Yup**, and **Semantic UI** for the front-end and **ASP.NET Core Web API** for the back-end.

## Features

- **Role-Based Access Control (RBAC)**: Librarians can manage books, while Students can borrow and return them.
- **CRUD Operations**: Librarians can create, update, and delete books.
- **SignalR**: Students can share their thoughts baout the book in the realtime chatting facility
- **Book Borrowing**: Students can borrow books and mark them as returned.
- **Formik with Yup Validation**: Form validation for creating and editing books.
- **Book Details View**: Displays book details along with reviews and borrowing status.
- **API Integration**: Communicates with the back-end to persist book data.

## Technologies

### Frontend

- **React**: For building the UI components.
- **MobX**: For state management.
- **TypeScript**: For strong typing.
- **Formik**: For form handling.
- **Yup**: For validation schemas.
- **Semantic UI**: For UI components and styling.

### Backend

- **ASP.NET Core Web API**: For handling RESTful API requests.
- **Entity Framework Core**: For database operations (CRUD).
- **JWT Authentication**: For secure access to API endpoints.
- **SignalR**: For real-time chat facility
- **Role-based Authorization**: For limiting actions based on the user's role (Librarian or Student).

## Setup and Installation

### Prerequisites

- **.NET 8 SDK**: Required for running the back-end API. Download from [here](https://dotnet.microsoft.com/download).
- **Node.js**: Ensure Node.js is installed. You can download it from [here](https://nodejs.org/).
- **React.js**: Ensure you have all the dependencies as listed in the packages.json of front-end project
- **SQL Server**: Install SQL Server or use a cloud-based solution like Azure SQL.
- **Entity Framework Core**: For database management, ensure you have EF Core installed.

**Clone the Repository**:
   ```bash
[   git clone https://github.com/your-repository/book-management-app.git](https://github.com/SandeepReddyThippareddy/LibraryApp.git)
  ```

**Book Management Application Setup**
### Backend Setup
### Configure the Database:
In the `appsettings.json` file, configure your SQL Server connection string as follows:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=your-server;Database=BookDb;User Id=your-username;Password=your-password;"
}
```
***Run Database Migrations:***
Ensure that Entity Framework Core is set up and then run migrations to create the database:
```bash
dotnet ef migrations add InitialCreate(name of your choice)
dotnet ef database update - since, I used a code first approcah, ypu can even simply run the database update command.
```
***Folder Structure Explanation***
### `src/`

The `src` directory contains all the core projects for both the back-end API and the front-end.

- **LibraryApp.API/**: 
  This folder contains the **ASP.NET Core Web API** project. It handles requests from the front-end and serves as the back-end for the application. Here, you’ll find controllers, services, middleware, and authentication logic.

- **LibraryApp.Data/**: 
  This project is responsible for the data access layer. It contains repositories and Entity Framework models for interacting with the SQL Server database.

- **LibraryApp.Models/**: 
  This folder contains the shared models used across both the API and the database projects. These models include entities like `Book`, `Borrower`, and `Review`.

- **library-frontend/**: 
  The front-end project built using **React** with **MobX** for state management. It provides the user interface for librarians and students to interact with the system. Key features include:
  - Book listing, borrowing, and returning (for students).
  - Book creation, editing, and deletion (for librarians).

### `test/`

The `test/` directory contains unit and integration tests for the **LibraryApp.Data** project.

- **LibraryApp.Data.Tests/**: 
  This project contains the test cases for the data access layer. These include repository tests to ensure correct interaction with the database.

### `.gitignore`

The `.gitignore` file specifies the files and directories that should not be tracked by Git. Typically, this includes build outputs, configuration files with sensitive data (like credentials), and dependency folders.

### `LibraryApp.sln`

This is the **solution** file that groups all the projects (API, Data, Models, Front-end, and Tests) into a single solution that can be opened in an IDE like **Visual Studio**.

### `README.md`

This is the markdown file that provides an overview of the project, setup instructions, and details about the structure and technology stack of the application.

---

***Run the ASP.NET Core API:***
To run the backend, execute the following command:
```bash
dotnet run
```
### Front Setup
Navigate to the Frontend Directory:
Move to the frontend directory of the project by running the command:
``` bash
cd ../library-frontend
```
Install Dependencies:
Install all necessary dependencies by running:
```bash
npm install
```
Configure API Endpoint:
```bash
REACT_APP_API_URL=https://localhost:5108/api
REACT_APP_CHAT_URL=https://localhost:5108/chat
```
Run the React App:
Start the React app by running:
```bash
npm start
```
