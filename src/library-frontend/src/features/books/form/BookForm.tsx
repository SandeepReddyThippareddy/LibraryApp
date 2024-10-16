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
import { v4 as uuid } from 'uuid';

export default observer(function BookForm() {
    const { bookStore } = useStore();
    const { createBook, updateBook, loadBook, loadingInitial } = bookStore;
    const { id } = useParams<{ id: string }>();
    const navigate = useNavigate();
    
    // Initializing state with an empty object that conforms to BookFormValues interface
    const [book, setBook] = useState<BookFormValues>({
        title: '',
        author: '',
        description: '',
        category: '',
        publicationDate: null,
        ISBN: '',
        coverImage: '',
        publisher: ''
    });

    const validationSchema = Yup.object({
        title: Yup.string().required('The book title is required'),
        author: Yup.string().required('The book author is required'),
        description: Yup.string().required('The description is required'),
        category: Yup.string().required('The category is required'),
    });

    useEffect(() => {
        if (id) loadBook(id).then(book => setBook({
            title: book?.title,
            author: book?.author,
            description: book?.description,
            category: book?.category,
            publicationDate: book?.publicationDate,
            ISBN: book?.ISBN,
            coverImage: book?.coverImage,
            publisher: book?.publisher
        }));
    }, [id, loadBook]);

    function handleFormSubmit(bookFormValues: BookFormValues) {
        if (!id) {
            let newBook = {
                ...bookFormValues,
                id: uuid(), 
            };
            createBook(newBook).then(() => navigate(`/books/${newBook.id}`));
        } else {
            updateBook(bookFormValues).then(() => navigate(`/books/${id}`));
        }
    }

    if (loadingInitial) return <LoadingComponent content='Loading book details...' />;

    return (
        <Segment clearing>
            <Header content='Book Details' sub color='teal' />
            <Formik
                validationSchema={validationSchema}
                enableReinitialize
                initialValues={book}
                onSubmit={(values) => handleFormSubmit(values)}
            >
                {({ handleSubmit, isValid, isSubmitting, dirty }) => (
                    <Form className='ui form' onSubmit={handleSubmit} autoComplete='off'>
                        <MyTextInput name='title' placeholder='Title' />
                        <MyTextInput name='author' placeholder='Author' />
                        <MyTextInput name='description' placeholder='Description' />
                        <MyTextInput name='category' placeholder='Category' />
                        <Button
                            disabled={isSubmitting || !dirty || !isValid}
                            loading={isSubmitting}
                            floated='right'
                            positive
                            type='submit'
                            content='Submit'
                        />
                        <Button
                            floated='right'
                            type='button'
                            content='Cancel'
                            onClick={() => navigate('/books')}
                        />
                    </Form>
                )}
            </Formik>
        </Segment>
    );
});
