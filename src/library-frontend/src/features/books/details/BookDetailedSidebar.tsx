import { Segment, List, Label, Item, Image } from 'semantic-ui-react';
import { Link } from 'react-router-dom';
import { observer } from 'mobx-react-lite';
import { Book } from '../../../app/models/book';
import { Borrower } from '../../../app/models/borrower';

interface Props {
    Book: Book;
}

const BookDetailedSidebar = observer(({ Book }: Props) => {
    if (!Book.borrowers || Book.borrowers.length === 0) return null;

    return (
        <>
            <Segment
                textAlign='center'
                style={{ border: 'none' }}
                attached='top'
                secondary
                inverted
                color='teal'
            >
                {Book.borrowers.length} {Book.borrowers.length === 1 ? 'Borrower' : 'Borrowers'}
            </Segment>
            <Segment attached>
                <List relaxed divided>
                    {Book.borrowers.map((borrower: Borrower) => (
                        <Item key={borrower.username} style={{ position: 'relative' }}>
                            <Label style={{ position: 'absolute' }} color='orange' ribbon='right'>
                                Borrower
                            </Label>
                            <Image size='tiny' src={'/assets/user.png'} />
                            <Item.Content verticalAlign='middle'>
                                <Item.Header as='h3'>
                                    <Link to={`/profiles/${borrower.username}`}>
                                        {borrower.username}
                                    </Link>
                                </Item.Header>
                            </Item.Content>
                        </Item>
                    ))}
                </List>
            </Segment>
        </>
    );
});

export default BookDetailedSidebar;
