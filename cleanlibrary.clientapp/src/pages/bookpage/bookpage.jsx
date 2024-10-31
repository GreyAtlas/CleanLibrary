import { useEffect, useState } from 'react';
import BookTable from '../../app/components/tables/booktable/booktable';
import { Col, Container, Row, Button, FormGroup, Label, Input} from 'reactstrap';
import "./bookpage.css"

function BookPage() {
    const initialBooksState = {
        books: {},
        loading: true
    }

    const initialSearchTerms = {
        name: null,
        publishingYear: null,
        booktypes: []
    }

    const [books, setBooks] = useState(initialBooksState);
    const [searchToggle, setSearchToggle] = useState(false)
    const [searchTerms, setSearchTerms] = useState(initialSearchTerms);


    useEffect(() => {
        populateBooksData();

    }, [searchToggle]);

    function onChange(event) {
        console.log(searchTerms );
        if (event.target.name === "book") {
            if (searchTerms.booktypes.includes(0))
            {
                searchTerms.booktypes.splice(searchTerms.booktypes.indexOf(0), 1);
            }
            else {
                searchTerms.booktypes.push(0);

            }
        }
        else if (event.target.name === "audiobook") {
            if (searchTerms.booktypes.includes(1)) {
                searchTerms.booktypes.splice(searchTerms.booktypes.indexOf(1), 1);
            }
            else {
                searchTerms.booktypes.push(1);

            }
        }
        else {
            setSearchTerms({ ...searchTerms,[event.target.name]: event.target.value });
        }
        console.log(searchTerms);
    }
    async function populateBooksData() {
        console.log(searchTerms);
        const response = await fetch('api/book', {
            method: "POST",
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                name: searchTerms.name,
                publishingDate: searchTerms.publishingYear,
                availableBookTypes: searchTerms.booktypes
            }),
        });
        const data = await response.json();
        const booksState = {
            books: data,
            loading: false
        }
        setBooks(booksState);
    }

    const contents = books.loading ?
        <p><em>Loading...</em></p> :
        (<Container style={{ paddingTop: "100px" }}>
            <Row>
                <Col>
                    <h3>Library Book List</h3>
                </Col>
                <Col>
                    <FormGroup>
                        <Input id="name" name="name" placeholder="Search Name" onChange={onChange}/>
                        <Input id="publishingYear" name="publishingYear" type="number" nplaceholder="Publishing Year" onChange={onChange}/>
                    </FormGroup>

                    <FormGroup>
                        <Label for="book">Books</Label>
                        <Input id="book" name="book" type="checkbox" onChange={onChange} />
                        <Label for="audiobook">Audiobooks</Label>
                        <Input id="audiobook" name="audiobook" type="checkbox" onChange={onChange} />
                    </FormGroup>
                    <Button onClick={() => { setSearchToggle(!searchToggle) }}> Search </Button>
                </Col>
            </Row>
            <Row>
                <Col>
                    <BookTable books={books.books} />
                </Col>
            </Row>
        </Container>
        )


    return (
        <div id= "bookpage">
            {contents}
        </div>
    );

}

export default BookPage;