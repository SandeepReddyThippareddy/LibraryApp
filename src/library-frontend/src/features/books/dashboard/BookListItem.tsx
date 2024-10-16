import { Button, Item, Segment } from "semantic-ui-react";
import { Link } from "react-router-dom";
import { Book } from "../../../app/models/book";

interface Props {
    book: Book;
}

const BookListItem = ({ book }: Props) => {
    return (
        <Segment.Group>
            <Segment>
                <Item.Group>
                    <Item>
                        <Item.Image size="tiny" src="/assets/placeholder.png" />
                        {/* <Item.Image size="tiny" src={book.coverImage || "/assets/book-placeholder.png"} /> */}
                        <Item.Content>
                            <Item.Header as={Link} to={`/book/${book.id}`}>
                                {book.title}
                            </Item.Header>
                            <Item.Description>Author: {book.author}</Item.Description>
                            <Item.Description>Category: {book.category}</Item.Description>
                        </Item.Content>
                    </Item>
                </Item.Group>
            </Segment>
            <Segment clearing>
                <Button as={Link} to={`/book/${book.id}`} color="teal" floated="right" content="View" />
            </Segment>
        </Segment.Group>
    );
};

export default BookListItem;
