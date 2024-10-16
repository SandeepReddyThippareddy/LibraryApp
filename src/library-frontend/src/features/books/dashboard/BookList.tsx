import { Fragment } from "react";
import { observer } from "mobx-react-lite";
import { Header } from "semantic-ui-react";
import { useStore } from "../../store";
import BookListItem from "./BookListItem";
import { Book } from "../../../app/models/book";

const BookList = observer(() => {
  const { bookStore } = useStore();
  const { groupedBooks } = bookStore;

  return (
    <>
      {groupedBooks && groupedBooks.map(([group, books]: [string, Book[]]) => (
        <Fragment key={group}>
          <Header sub color="teal">
            {group}
          </Header>
          {books.map((book: Book) => (
            <BookListItem key={book.id} book={book} />
          ))}
        </Fragment>
      ))}
    </>
  );
});

export default BookList;
