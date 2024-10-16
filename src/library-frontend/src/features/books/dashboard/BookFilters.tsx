import { observer } from 'mobx-react-lite';
import { Header, Menu, Input } from 'semantic-ui-react';
import { useStore } from '../../store';

const BookFilters = observer(() => {
    const { bookStore } = useStore();
    const { setPredicate, predicate } = bookStore;

    return (
        <>
            <Menu vertical size="large" style={{ width: '100%', marginTop: 25 }}>
                <Header icon="filter" attached color="teal" content="Filters" />
                <Menu.Item
                    content="All Books"
                    active={predicate.has('all')}
                    onClick={() => setPredicate('all', 'true')}
                />
                <Menu.Item
                    content="Available Books"
                    active={predicate.has('isAvailable')}
                    onClick={() => setPredicate('isAvailable', 'true')}
                />
                <Menu.Item
                    content="Borrowed Books"
                    active={predicate.has('isBorrowed')}
                    onClick={() => setPredicate('isBorrowed', 'true')}
                />
            </Menu>
            <Header />
            <Input
                icon="search"
                placeholder="Search by title..."
                onChange={(e) => setPredicate('title', e.target.value)}
            />
        </>
    );
});

export default BookFilters;
