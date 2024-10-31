import React, { Fragment } from "react";
import {
    BrowserRouter,
    Routes,
    Route,
} from "react-router-dom";
import BookPage from "../../pages/bookpage/bookpage"
import ReservationPage from "../../pages/reservationpage/reservationpage"
import CustomNavBar from "../components/navbar/customnavbar"


const App = () => {
    return (
        <Fragment>
            <BrowserRouter>
                <CustomNavBar />
                <Routes>
                    <Route path="/" element={<BookPage />} />
                    <Route path="/books" element={<BookPage />} />
                    <Route path="/reservations" element={<ReservationPage />} />
                </Routes>
            </BrowserRouter>
        </Fragment>
    )
}

export default App