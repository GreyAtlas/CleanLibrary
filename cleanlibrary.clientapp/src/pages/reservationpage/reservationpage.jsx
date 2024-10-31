import { useEffect, useState } from 'react';
import ReservationTable from '../../app/components/tables/reservationtable/reservationtable';
function ReservationPage() {
    const initialReservationsState = {
        reservations: {},
        loading: true
    }

    const [reservations, setReservations] = useState(initialReservationsState);


    useEffect(() => {
        populateReservationsData();

    }, []);
    async function populateReservationsData() {
        const response = await fetch('api/reservation');

        const data = await response.json();
        const reservationsState = {
            reservations: data,
            loading: false
        }
        setReservations(reservationsState);
    }

    const contents = reservations.loading ?
        <p><em>Loading...</em></p> :
        <ReservationTable reservations={reservations.reservations} />


    return (
        <div id="bookpage">
            <h1 id="tabelLabel">Book Reservations</h1>
            {contents}
        </div>
    );

}

export default ReservationPage;