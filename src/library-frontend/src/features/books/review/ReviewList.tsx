// import { observer } from "mobx-react-lite";
// import { Segment, List, Header, Rating, Comment } from "semantic-ui-react";
// import { useEffect } from "react";
// import { useStore } from "../../store";

// interface Props {
//   bookId: string;
// }

// export default observer(function ReviewList({ bookId }: Props) {
//   const { reviewStore } = useStore();

//   useEffect(() => {
//     if (bookId) reviewStore.loadReviews(bookId);
//   }, [bookId, reviewStore]);

//   return (
//     <Segment>
//       <Header as="h3" content="Reviews" />
//       <List>
//         {reviewStore.reviews.map((review) => (
//           <Segment key={review.id}>
//             <Comment>
//               <Comment.Content>
//                 <Comment.Author>{review.username}</Comment.Author>
//                 <Comment.Metadata>
//                   <Rating icon="star" defaultRating={review.rating} maxRating={5} disabled />
//                 </Comment.Metadata>
//                 <Comment.Text>{review.body}</Comment.Text>
//               </Comment.Content>
//             </Comment>
//           </Segment>
//         ))}
//       </List>
//     </Segment>
//   );
// });
export {}