import React, { Component, Fragment, useEffect, useState } from 'react';
import { Button, Form, FormGroup, Input, Label } from 'reactstrap';
function ReservationForm({ passedBookId, passedAvailableBooks, toggle }) {
    const initialState = {
        bookId: passedBookId,
        reservationStartDate: null,
        reservationEndDate: null,
        bookType: null,
        quickPickup: false
    }

    const [state, setState] = useState(initialState); 

    function onChange(event) {
        setState({ [event.target.name]: event.target.value })
    }
    async function createReservation(event) {
        event.preventDefault();
        const response = await fetch('api/book', {
            method: "POST",
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                bookId: state.bookId,
                bookType: state.bookType,
                reservationStartDate: state.reservationStartDate,
                reservationEndDate: state.reservationEndDate,
                quickPickup: state.quickPickup
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
                        Room Type
                    </Label>
                    <Input type="select" name="bookType" onChange={onChange}>
                        {passedAvailableBooks.map(type =>
                            <option value={type} > Book </option> ? type == 0 :
                                <option value={type} > Audiobook </option>
                        )}
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
                    <Input name="quickpickup" type="checkbox" onChange={onChange} /> {' '}
                </FormGroup>
                <Button>Reserve</Button>
            </Form>
        </Fragment>

    );


}
export default ReservationForm;