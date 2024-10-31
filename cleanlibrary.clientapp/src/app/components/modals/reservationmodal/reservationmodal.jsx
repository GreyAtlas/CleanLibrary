import React, { Fragment, useState, useEffect } from 'react';
import { Button, Modal, ModalHeader, ModalBody, ModalFooter } from 'reactstrap';
import ReservationForm from '../../forms/reservationform/reservationForm';
function ReservationModal({ show, passedBookId, passedAvailableBooks }) {

    useEffect(() => {
        setState(!state);
    }, [show])

    const [state, setState] = useState(show);

    const toggle = () => setState(!state);

    return (<Fragment>
        <Modal isOpen={!state} >
            <ModalHeader>{passedBookId}</ModalHeader>
            <ModalBody>
                <ReservationForm
                    passedBookId={passedBookId}
                    passedAvailableBooks={passedAvailableBooks}
                    toggle={toggle} />
            </ModalBody>
            <ModalFooter>
                <Button color="secondary" onClick={() => toggle()}>
                    Cancel
                </Button>
            </ModalFooter>
        </Modal>
    </Fragment>
    );

}

export default ReservationModal