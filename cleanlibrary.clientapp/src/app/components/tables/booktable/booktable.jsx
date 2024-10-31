import React, {useState, Fragment } from 'react';
import { Table } from 'reactstrap';
import "../../tables/table.css";
import ReservationModal from "../../modals/reservationmodal/reservationmodal";


function BookTable({books}) {
    const [selectedRow, setSelectedRow] = useState();
    const [selectedAvailableBooks, setSelectedAvailableBooks] = useState([-1]);
    const [modal, setModal] = useState(false);

    const toggleModal = (id, availableBooks) => {
        setSelectedAvailableBooks(availableBooks)
        setSelectedRow(id)
        setModal(!modal)
    }



    return (
        <Fragment>
            <ReservationModal
                show={modal}
                passedBookId={selectedRow}
                passedAvailableBooks={selectedAvailableBooks} />
            <Table striped hover>
                <thead>
                    <tr>
                        <th>Picture</th>
                        <th>Name</th>
                        <th>Publishing Date</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    {!books || books.length <= 0 ?
                        <tr>
                            <td colSpan="3" align="center"><b>No Books yet</b></td>
                        </tr>
                        :
                        books.map(book =>
                            <tr key={book.id} onClick={() => toggleModal(book.id, book.availableBookTypes)} >
                                <td>
                                    <img className="img-fluid" src={`data:image/jpg;base64,${book.picture}`} />
                                </td>
                                <td>{book.name}</td>
                                <td>{book.publishingDate}</td>
                            </tr>
                        )}
                </tbody>
            </Table>
        </Fragment>
    );
    
}

export default BookTable;