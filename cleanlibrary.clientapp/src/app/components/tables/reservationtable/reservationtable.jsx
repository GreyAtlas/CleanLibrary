import { Table } from 'reactstrap';
import "../../tables/table.css";

function ReservationTable({reservations}) {



    return (
        <Table striped hover>
            <thead>
                <tr>
                    <th>Reserved Book</th>
                    <th>Book Type</th>
                    <th>Reservation Date</th>
                    <th>Reservation End Date</th>
                    <th>Quick Pick Up</th>
                    <th>Price</th>
                </tr>
            </thead>
            <tbody>
                {!reservations || reservations.length <= 0 ?
                    <tr>
                        <td colSpan="3" align="center"><b>No Books yet</b></td>
                    </tr>
                    :
                    reservations.map(reservation =>
                        <tr key={reservation.id}>
                            <td>{reservation.bookId}</td>
                            <td>{reservation.bookType}</td>
                            <td>{reservation.reservationStartDate}</td>
                            <td>{reservation.reservationEndDate}</td>
                            <td>{reservation.quickPickup ? "Yes" : "No"}</td>
                            <td>{reservation.reservationPrice}</td>
                        </tr>
                    )}
            </tbody>
        </Table>
    );
    
}

export default ReservationTable;