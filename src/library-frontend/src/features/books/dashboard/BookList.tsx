import { observer } from "mobx-react-lite";
import { Fragment } from "react";
import { Header } from "semantic-ui-react";
import { useStore } from "../../store";
import BookListItem from "./BookListItem";

const BookList = observer(() => {
  const { bookStore } = useStore();
  const { filteredBooks } = bookStore; 

  return (
    <>
      {filteredBooks.map((book) => (
        <Fragment key={book.id}>
          <Header sub color="teal">
            {book.title}
          </Header>
          <BookListItem key={book.id} book={book} />
        </Fragment>
      ))}
    </>
  );
});

export default BookList;
