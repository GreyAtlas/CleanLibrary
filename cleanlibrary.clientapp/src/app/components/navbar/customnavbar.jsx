import { useEffect, useState } from 'react';
import {
    Navbar,
    NavbarBrand,
    NavbarToggler,
    Collapse,
    Nav,
    NavItem,
    NavLink,
} from 'reactstrap';

function CustomNavBar() {
    const [isOpen, setIsOpen] = useState(false); 

    const toggle = () => {
        setIsOpen(!isOpen);
    } 

    return (
        <Navbar color="dark" dark expand="md">
            <NavbarBrand href="/">
                Book Reservation App
            </NavbarBrand>
            <NavbarToggler onClick={toggle} />
            <Collapse isOpen={isOpen} navbar>
                <Nav className="ml-auto" navbar>
                    <NavItem>
                        <NavLink href="/books">Books</NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink href="/reservations">Reservations</NavLink>
                    </NavItem>
                </Nav>
            </Collapse>
        </Navbar>
    );

}

export default CustomNavBar;