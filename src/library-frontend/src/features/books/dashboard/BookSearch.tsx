import { observer } from "mobx-react-lite";
import { Input } from "semantic-ui-react";
import { useStore } from "../../store";

const BookSearch = observer(() => {
  const { bookStore } = useStore();
  const { setPredicate } = bookStore;

  return (
    <Input
      fluid
      icon="search"
      placeholder="Search books by title..."
      onChange={(e) => setPredicate('title', e.target.value)}
    />
  );
});

export default BookSearch;
