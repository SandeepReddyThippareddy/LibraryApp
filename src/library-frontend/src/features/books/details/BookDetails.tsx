import { Grid } from "semantic-ui-react";
import { observer } from 'mobx-react-lite';
import LoadingComponent from '../../../app/layout/LoadingComponent';
import { useParams } from "react-router-dom";
import { useEffect } from "react";
import { useStore } from "../../store";
import BookDetailedHeader from "./BookDetailedHeader";
import BookDetailedSidebar from "./BookDetailedSidebar";
import BookDetailedChat from "./BookDetailedChat";
import BookDetailedInfo from "./BookDetailedInfo";



export default observer(function BookDetails() {
    const { bookStore } = useStore();
    const { selectedBook: Book, loadBook, loadingInitial, clearSelectedBook } = bookStore;
    const { id } = useParams();

    useEffect(() => {
        if (id) loadBook(id);
        return () => clearSelectedBook();
    }, [id, loadBook, clearSelectedBook]);

    if (loadingInitial || !Book) return <LoadingComponent />

    return (
        <Grid>
            <Grid.Column width='10'>
                <BookDetailedHeader Book={Book} />
                <BookDetailedInfo Book={Book} />
                <BookDetailedChat BookId={Book.id} />
            </Grid.Column>
            <Grid.Column width='6'>
                <BookDetailedSidebar Book={Book}/>
            </Grid.Column>
        </Grid>
    )
})