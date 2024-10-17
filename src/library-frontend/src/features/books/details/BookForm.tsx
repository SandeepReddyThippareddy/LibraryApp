import { Formik, Form } from "formik";
import * as Yup from "yup";
import { Button, Header, Segment } from "semantic-ui-react";
import { observer } from "mobx-react-lite";
import { useNavigate, useParams } from "react-router-dom";
import { useEffect, useState } from "react";
import { useStore } from "../../store";
import { BookFormValues, defaultBookFormValues } from "../../../app/models/book";
import MyTextInput from "../../../app/common/form/MyTextInput";

const BookForm = observer(() => {
  const { bookStore } = useStore();
  const { createBook, updateBook, loadBook, loading } = bookStore;
  const { id } = useParams<{ id: string }>();
  const navigate = useNavigate();
  const [book, setBook] = useState<BookFormValues>(defaultBookFormValues);

  // Validation schema using Yup
  const validationSchema = Yup.object({
    title: Yup.string().required("The book title is required"),
    author: Yup.string().required("The author name is required"),
    description: Yup.string().required(),
    category: Yup.string().required(),
    publicationDate: Yup.date().nullable().required("Publication date is required"),
    ISBN: Yup.string().required(),
    pageCount: Yup.number().required(),
  });

  useEffect(() => {
    if (id) {
      loadBook(id).then((book) => {
        if (book) {
          setBook({
            id: book.id,
            title: book.title || "",
            author: book.author || "",
            description: book.description || "",
            category: book.category || "",
            publicationDate: book.publicationDate || null,
            ISBN: book.ISBN || "",
            pageCount: book.pageCount || 0, // Default to 0 if undefined
            coverImage: book.coverImage || "",
            publisher: book.publisher || ""
          });
        }
      });
    }
  }, [id, loadBook]);

  const handleFormSubmit = (book: BookFormValues) => {
    if (!book.id) {
      createBook(book).then((newBook) => navigate(`/books/${newBook?.id}`));
    } else {
      updateBook(book).then(() => navigate(`/books/${book.id}`));
    }
  };

  return (
    <Segment clearing>
      <Header content={id ? "Update Book" : "Create New Book"} />
      <Formik
        validationSchema={validationSchema}
        enableReinitialize
        initialValues={book}
        onSubmit={handleFormSubmit}
      >
        {({ handleSubmit, isValid, isSubmitting, dirty }) => (
          <Form className="ui form" onSubmit={handleSubmit}>
            <MyTextInput name="title" placeholder="Title" />
            <MyTextInput name="author" placeholder="Author" />
            <MyTextInput name="description" placeholder="Description" />
            <MyTextInput name="category" placeholder="Category" />
            <MyTextInput name="publicationDate" placeholder="Publication Date" />
            <MyTextInput name="ISBN" placeholder="ISBN" />
            <MyTextInput name="pageCount" placeholder="Page Count" />
            <Button
              disabled={!isValid || isSubmitting || !dirty}
              loading={isSubmitting}
              positive
              type="submit"
              content={id ? "Update" : "Create"}
              floated="right"
            />
          </Form>
        )}
      </Formik>
    </Segment>
  );
});

export default BookForm;
