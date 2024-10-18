import { observer } from "mobx-react-lite";
import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { Button, Header, Segment } from "semantic-ui-react";
import { Formik, Form } from "formik";
import * as Yup from "yup";
import MyTextInput from "../../../app/common/form/MyTextInput";
import { useStore } from "../../store";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { BookFormValues } from "../../../app/models/book";

export default observer(function BookForm() {
  const { bookStore } = useStore();
  const { createBook, updateBook, loadBook, loadingInitial } = bookStore;
  const { id } = useParams<{ id: string }>();
  const navigate = useNavigate();

  const [book, setBook] = useState<BookFormValues>({
    id: "",
    title: "",
    author: "",
    description: "",
    category: "",
    publicationDate: null,
    ISBN: "",
    coverImage: "",
    publisher: "",
    pageCount: 0,
  });

  const validationSchema = Yup.object({
    title: Yup.string().required("The book title is required"),
    author: Yup.string().required("The author is required"),
    description: Yup.string().required("The description is required"),
    category: Yup.string().required("The category is required"),
    publicationDate: Yup.date()
      .nullable()
      .required("Publication date is required"),
    coverImage: Yup.string().required("The cover image URL is required - feel free to provide any valid URL from the internet"),
    publisher: Yup.string().required("The publisher is required"),
    pageCount: Yup.number()
      .required("The page count is required")
      .min(1, "Page count must be greater than 0"),
  });

  useEffect(() => {
    if (id)
      loadBook(id).then((book) => {
        if (book) {
          setBook({
            id: book.id || "",
            title: book.title || "",
            author: book.author || "",
            description: book.description || "",
            category: book.category || "",
            publicationDate: book.publicationDate || null,
            ISBN: book.ISBN || "",
            coverImage: book.coverImage || "",
            publisher: book.publisher || "",
            pageCount: book.pageCount || 0,
          });
        }
      });
  }, [id, loadBook]);

  // Handle form submission
  function handleFormSubmit(bookFormValues: BookFormValues) {
    if (!id) {
      let newBook = {
        ...bookFormValues,
      };
      createBook(newBook).then(() => navigate(`/books/${newBook.id}`));
    } else {
      updateBook(bookFormValues).then(() => navigate(`/books/${id}`));
    }
  }

  if (loadingInitial)
    return <LoadingComponent content="Loading book details..." />;

  return (
    <Segment clearing>
      <Header
        content={id ? "Update Book" : "Create New Book"}
        sub
        color="teal"
      />
      <Formik
        validationSchema={validationSchema}
        enableReinitialize
        initialValues={book}
        onSubmit={(values) => handleFormSubmit(values)}
      >
        {({ handleSubmit, isValid, isSubmitting, dirty }) => (
          <Form className="ui form" onSubmit={handleSubmit} autoComplete="off">
            <MyTextInput name="title" placeholder="Title" />
            <MyTextInput name="author" placeholder="Author" />
            <MyTextInput name="description" placeholder="Description" />
            <MyTextInput name="category" placeholder="Category" />
            <MyTextInput
              name="publicationDate"
              placeholder="Publication Date"
              type="date"
            />
            <MyTextInput name="ISBN" placeholder="ISBN" />
            <MyTextInput name="coverImage" placeholder="Cover Image URL" />
            <MyTextInput name="publisher" placeholder="Publisher" />
            <MyTextInput
              name="pageCount"
              placeholder="Page Count"
              type="number"
            />

            <Button
              disabled={isSubmitting || !dirty || !isValid}
              loading={isSubmitting}
              floated="right"
              positive
              type="submit"
              content="Submit"
            />
            <Button
              floated="right"
              type="button"
              content="Cancel"
              onClick={() => navigate("/books")}
            />
          </Form>
        )}
      </Formik>
    </Segment>
  );
});
