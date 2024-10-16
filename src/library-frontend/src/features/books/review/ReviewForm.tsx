// import { observer } from "mobx-react-lite";
// import { Formik, Form } from "formik";
// import * as Yup from "yup";
// import { Button, Header, Segment, Rating } from "semantic-ui-react";
// import MyTextArea from "../../../app/common/form/MyTextArea";
// import { useStore } from "../../store";

// interface Props {
//   bookId: string;
// }

// export default observer(function ReviewForm({ bookId }: Props) {
//   const { reviewStore } = useStore();

//   const validationSchema = Yup.object({
//     body: Yup.string().required("Review message is required"),
//     rating: Yup.number().min(1, "Rating must be at least 1").max(5, "Rating can be no more than 5").required(),
//   });

//   return (
//     <Segment clearing>
//       <Header content="Leave a Review" sub color="teal" />
//       <Formik
//         initialValues={{ body: "", rating: 0 }}
//         validationSchema={validationSchema}
//         onSubmit={(values, { resetForm }) => {
//           reviewStore.createReview(bookId, values).then(() => resetForm());
//         }}
//       >
//         {({ isSubmitting, isValid, dirty, setFieldValue, values }) => (
//           <Form className="ui form" autoComplete="off">
//             <MyTextArea rows={3} name="body" placeholder="Write your review..." />
//             <Header content="Rating" sub color="teal" />
//             <Rating
//               icon="star"
//               maxRating={5}
//               rating={values.rating}
//               onRate={(e, { rating }) => setFieldValue("rating", rating)}
//             />
//             <Button
//               disabled={isSubmitting || !dirty || !isValid}
//               loading={isSubmitting}
//               floated="right"
//               positive
//               type="submit"
//               content="Submit"
//             />
//           </Form>
//         )}
//       </Formik>
//     </Segment>
//   );
// });
export {}