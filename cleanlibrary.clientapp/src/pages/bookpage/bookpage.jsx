import { useEffect, useState } from 'react';
import BookTable from '../../app/components/tables/booktable/booktable';
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

    const [searchTerms, setSearchTerms] = useState(initialSearchTerms);

    useEffect(() => {
        populateBooksData();

    }, []);

    const contents = books.loading ?
        <p><em>Loading...</em></p> :
        <BookTable books={books.books} />


    return (
        <div id= "bookpage">
            <h1 id="tabelLabel">Library Book List</h1>
            {contents}
        </div>
    );

    async function populateBooksData() {
        console.log(JSON.stringify({
            name: searchTerms.name,
            publishingDate: searchTerms.publishingYear,
            availableBookTypes: searchTerms.booktypes
        }));
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
        console.log(data);
        const booksState = {
            books: data,
            loading: false
        }
        setBooks(booksState);
    }
}

export default BookPage;