import { ErrorMessage, Form, Formik, Field } from "formik";
import { observer } from "mobx-react-lite";
import { Button, Header } from "semantic-ui-react";
import MyTextInput from "../../app/common/form/MyTextInput";
import * as Yup from "yup";
import { useStore } from "../store";
import ValidationError from "../errors/ValidationError";

export default observer(function RegisterForm() {
  const { userStore } = useStore();

  return (
    <Formik
      initialValues={{
        displayName: "",
        username: "",
        email: "",
        password: "",
        IsLibrarian: false,
        error: null,
      }}
      onSubmit={(values, { setErrors }) =>
        userStore.register(values).catch((error) => setErrors({ error: error }))
      }
      validationSchema={Yup.object({
        displayName: Yup.string().required(),
        username: Yup.string().required(),
        email: Yup.string().required(),
        password: Yup.string().required(),
      })}
    >
      {({ handleSubmit, isSubmitting, errors, isValid, dirty }) => (
        <Form className="ui form error" onSubmit={handleSubmit} autoComplete="off">
          <Header as="h2" content="Sign up" color="teal" textAlign="center" />
          <MyTextInput placeholder="Display Name" name="displayName" />
          <MyTextInput placeholder="Username" name="username" />
          <MyTextInput placeholder="Email" name="email" />
          <MyTextInput placeholder="Password" name="password" type="password" />

          <div className="ui checkbox">
            <Field type="checkbox" name="IsLibrarian" />
            <label>Register as Librarian</label>
          </div>

          <ErrorMessage name="error" render={() => <ValidationError errors={errors.error} />} />

          <Button
            disabled={!isValid || !dirty || isSubmitting}
            loading={isSubmitting}
            positive
            content="Register"
            type="submit"
            fluid
          />
        </Form>
      )}
    </Formik>
  );
});
