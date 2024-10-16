import { observer } from 'mobx-react-lite';
import { Segment, Grid, Icon } from 'semantic-ui-react';
import { Book } from '../../../app/models/book';

interface Props {
    Book: Book;
}

const BookDetailedInfo = observer(({ Book }: Props) => {
    return (
        <Segment.Group>
            <Segment attached='top'>
                <Grid>
                    <Grid.Column width={1}>
                        <Icon size='large' color='teal' name='info' />
                    </Grid.Column>
                    <Grid.Column width={15}>
                        <p>{Book.description}</p>
                    </Grid.Column>
                </Grid>
            </Segment>
            <Segment attached>
                <Grid verticalAlign='middle'>
                    <Grid.Column width={1}>
                        <Icon name='book' size='large' color='teal' />
                    </Grid.Column>
                    <Grid.Column width={15}>
                        <span>ISBN: {Book.ISBN}</span>
                    </Grid.Column>
                </Grid>
            </Segment>
            <Segment attached>
                <Grid verticalAlign='middle'>
                    <Grid.Column width={1}>
                        <Icon name='marker' size='large' color='teal' />
                    </Grid.Column>
                    <Grid.Column width={11}>
                        <span>Publisher: {Book.publisher}</span>
                    </Grid.Column>
                </Grid>
            </Segment>
        </Segment.Group>
    );
});

export default BookDetailedInfo;
