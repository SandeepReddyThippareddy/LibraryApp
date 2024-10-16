import { observer } from "mobx-react-lite";
import { useEffect } from "react";
import { Grid, Loader } from "semantic-ui-react";
import BookList from "./BookList";
import BookFilters from "./BookFilters";
import BookListItemPlaceholder from "./BookListItemPlaceholder";
import { useStore } from "../../store";
import BookSearch from "./BookSearch";

const BookDashboard = observer(() => {
  const { bookStore } = useStore();
  const { loadBooks, loadingInitial } = bookStore;

  useEffect(() => {
    loadBooks();
  }, [loadBooks]);

  return (
    <Grid>
      <Grid.Column width="10">
        {loadingInitial ? (
          <>
            <BookListItemPlaceholder />
            <BookListItemPlaceholder />
            <BookListItemPlaceholder />
            <BookListItemPlaceholder />
          </>
        ) : (
          <>
            {" "}
            <BookSearch />
            <BookList />
          </>
        )}
      </Grid.Column>
      <Grid.Column width="6">
        <BookFilters />
      </Grid.Column>
    </Grid>
  );
});

export default BookDashboard;
