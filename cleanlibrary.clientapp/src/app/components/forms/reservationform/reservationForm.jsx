import React, { Fragment, useState } from 'react';
import { Button, Form, FormGroup, Input, Label } from 'reactstrap';

function ReservationForm({ passedBookId, passedAvailableBooks, toggle }) {
    const initialState = {
        bookId: passedBookId,
        reservationStartDate: null,
        reservationEndDate: null,
        bookType: passedAvailableBooks[0],
     
    }

    const [state, setState] = useState(initialState);
    const [quickPickup, setQuickPickup] = useState(false);

    function onChangeCheckbox() {
        setQuickPickup(!quickPickup);
    }
    function onChange(event) {
        console.log(state);
        if (event.target.name === "bookType") {
            setState({
                ...state,[event.target.name]: Number(event.target.value)
            });

        } else {
            setState({
                ...state,[event.target.name]: event.target.value
            });

        }

        console.log(state);
    }
    async function createReservation(event) {
        console.log(state);
        event.preventDefault();
        const response = await fetch('api/reservation', {
            method: "POST",
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                bookId: state.bookId,
                bookType: state.bookType,
                reservationStartDate: state.reservationStartDate,
                reservationEndDate: state.reservationEndDate,
                quickPickup: quickPickup
            })
        })
        const data = await response.json();
        console.log(data);
        toggle();
    }

    return (
        <Fragment>
            <Form onSubmit={createReservation}>
                <FormGroup>
                    <Label for="exampleSelect">
                        Book type
                    </Label>
                    <Input type="select" name="bookType" onChange={onChange}>
                        {passedAvailableBooks.map((type) => {
                                if (type === 0) {

                                    return (<option value={type}> Book</option>);
                                }
                                else if (type == 1) {
                                    return (<option value={type}> Audiobook</option>);

                                }
                            })
                        }
                    </Input>
                </FormGroup>
                <FormGroup>
                    <Label for="ReservationStartDate">Start of Reservation:</Label>
                    <Input required type="date" name="reservationStartDate" onChange={onChange} />
                </FormGroup>
                <FormGroup>
                    <Label for="ReservationEndDate">End of Reservation:</Label>
                    <Input required type="date" name="reservationEndDate" onChange={onChange} />
                </FormGroup>
                <FormGroup check>
                    <Label check>
                        Quick Pickup
                    </Label>
                    <Input name="quickpickup" type="checkbox" onChange={onChangeCheckbox} /> {' '}
                </FormGroup>
                <Button>Reserve</Button>
            </Form>
        </Fragment>

    );


}
export default ReservationForm;