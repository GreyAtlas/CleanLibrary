import { useEffect, useState } from 'react';
import ReservationTable from '../../app/components/tables/reservationtable/reservationtable';
function ReservationPage() {
    const initialReservationsState = {
        reservations: {},
        loading: true
    }

    const initialSearchTerms = {
        name: null,
        publishingYear: null,
        booktypes: []
    }

    const [reservations, setReservations] = useState(initialReservationsState);


    useEffect(() => {
        populateReservationsData();

    }, []);

    const contents = reservations.loading ?
        <p><em>Loading...</em></p> :
        <ReservationTable reservations={reservations.reservations} />


    return (
        <div id="bookpage">
            <h1 id="tabelLabel">Book Reservations</h1>
            {contents}
        </div>
    );

    async function populateReservationsData() {
        const response = await fetch('api/reservation');

        const data = await response.json();
        console.log(data);
        const reservationsState = {
            reservations: data,
            loading: false
        }
        setReservations(reservationsState);
    }
}

export default ReservationPage;