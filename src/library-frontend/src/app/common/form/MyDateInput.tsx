import { useField } from 'formik';
import { Form, Label } from 'semantic-ui-react';
import ReactDatePicker from 'react-datepicker';
import 'react-datepicker/dist/react-datepicker.css';

interface Props {
    placeholder: string;
    name: string;
    label?: string;
    showTimeSelect?: boolean;
    dateFormat?: string;
}

export default function MyDateInput(props: Props) {
    const [field, meta, helpers] = useField(props.name);

    return (
        <Form.Field error={meta.touched && !!meta.error}>
            {props.label && <label>{props.label}</label>}
            <ReactDatePicker
                {...field}
                {...props}
                selected={(field.value && new Date(field.value)) || null}
                onChange={(value) => helpers.setValue(value)}
            />
            {meta.touched && meta.error ? (
                <Label basic color="red">{meta.error}</Label>
            ) : null}
        </Form.Field>
    );
}
