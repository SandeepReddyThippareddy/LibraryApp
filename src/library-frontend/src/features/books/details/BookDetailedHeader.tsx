import { observer } from "mobx-react-lite";
import { Button, Header, Item, Segment, Image, Label } from "semantic-ui-react";
import { Book } from "../../../app/models/book";
import { useStore } from "../../store";
import { useState } from "react";
import { useNavigate } from "react-router-dom"; 

interface Props {
  Book: Book;
}

const BookDetailedHeader = observer(({ Book }: Props) => {
  const { bookStore: { updateBookStatus, deleteBook, loading } } = useStore();
  const { userStore } = useStore();
  const { user } = userStore; 

  const [showManageOptions, setShowManageOptions] = useState(false);
  const navigate = useNavigate();

  const handleUpdate = () => {
    navigate(`/manage/${Book.id}`); 
  };

  const handleDelete = async (id: string) => {
    await deleteBook(id);
    navigate('/books'); 
  };

  return (
    <Segment.Group>
      <Segment basic attached="top" style={{ padding: "0" }}>
        {Book.isBorrowed && (
          <Label
            style={{ position: "absolute", zIndex: 1000, left: -14, top: 20 }}
            ribbon
            color="red"
            content="Currently Borrowed"
          />
        )}
        <Image src={Book.coverImage || "/assets/placeholder.png"} fluid />
        <Segment basic>
          <Item.Group>
            <Item>
              <Item.Content>
                <Header size="huge" content={Book.title} style={{ color: "teal" }} />
                <p>{Book.author}</p>
              </Item.Content>
            </Item>
          </Item.Group>
        </Segment>
      </Segment>

      <Segment clearing attached="bottom">
        {!user?.isLibrarian && (
          <>
            {Book.isBorrowed ? (
              <Button
                color="red"
                floated="right"
                onClick={() => updateBookStatus(Book.id, false)}
                loading={loading}
              >
                Mark as Returned
              </Button>
            ) : (
              <Button
                color="teal"
                floated="right"
                onClick={() => updateBookStatus(Book.id, true)}
                loading={loading}
              >
                Borrow Book
              </Button>
            )}
          </>
        )}

        {user?.isLibrarian && (
          <>
            {!showManageOptions && (
              <Button
                color="blue"
                floated="right"
                onClick={() => setShowManageOptions(true)}
              >
                Manage Book
              </Button>
            )}
            {showManageOptions && (
              <>
                <Button
                  color="orange"
                  floated="right"
                  onClick={handleUpdate}
                  loading={loading}
                >
                  Update Book
                </Button>
                <Button
                  color="red"
                  floated="right"
                  onClick={() => handleDelete(Book.id)}
                  loading={loading}
                >
                  Delete Book
                </Button>
              </>
            )}
          </>
        )}
      </Segment>
    </Segment.Group>
  );
});

export default BookDetailedHeader;
