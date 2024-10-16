import { format } from 'date-fns';
import { observer } from 'mobx-react-lite';
import { Button, Header, Item, Segment, Image, Label } from 'semantic-ui-react';
import { Book } from '../../../app/models/book';
import { useStore } from '../../store';

const BookImageStyle = {
    filter: 'brightness(30%)',
};

const BookImageTextStyle = {
    position: 'absolute',
    bottom: '5%',
    left: '5%',
    width: '100%',
    height: 'auto',
    color: 'white',
};

interface Props {
    Book: Book;
}

const BookDetailedHeader = observer(({ Book }: Props) => {
    const { bookStore: { updateBookStatus, loading } } = useStore();

    return (
        <Segment.Group>
            <Segment basic attached='top' style={{ padding: '0' }}>
                {Book.isBorrowed && (
                    <Label
                        style={{ position: 'absolute', zIndex: 1000, left: -14, top: 20 }}
                        ribbon color='red'
                        content='Currently Borrowed'
                    />
                )}
                <Image src={Book.coverImage || '/assets/placeholder.png'} fluid style={BookImageStyle} />
                <Segment style={BookImageTextStyle} basic>
                    <Item.Group>
                        <Item>
                            <Item.Content>
                                <Header size='huge' content={Book.title} style={{ color: 'white' }} />
                                <p>{Book.author}</p>
                                <p>Published on {format(new Date(Book.publicationDate!), 'dd MMM yyyy')}</p>
                                <p>Category: {Book.category}</p>
                            </Item.Content>
                        </Item>
                    </Item.Group>
                </Segment>
            </Segment>
            <Segment clearing attached='bottom'>
                {Book.isBorrowed ? (
                    <Button
                        color='red'
                        floated='right'
                        onClick={() => updateBookStatus(Book.id, false)}
                        loading={loading}
                    >
                        Mark as Returned
                    </Button>
                ) : (
                    <Button
                        color='teal'
                        floated='right'
                        onClick={() => updateBookStatus(Book.id, true)}
                        loading={loading}
                    >
                        Borrow Book
                    </Button>
                )}
            </Segment>
        </Segment.Group>
    );
});

export default BookDetailedHeader;