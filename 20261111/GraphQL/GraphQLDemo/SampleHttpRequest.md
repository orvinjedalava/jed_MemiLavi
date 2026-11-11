# Sample Javascript client code

'''
const response = await fetch("https://localhost:<port>/graphql", {
method: "POST",
headers: { "Content-Type": "application/json" },
body: JSON.stringify({
query: `
query GetMyBooks {
booksWithH: books(nameContains: "H") {
...bookFields
author { name }
}
booksWithM: books(nameContains: "M") {
...bookFields
}
}

      fragment bookFields on Book {
        bookId
        name
        genre
      }
    `,
    variables: { bookName: "l" }, // only used if query references $bookName
    operationName: "GetMyBooks"

})
});

const result = await response.json();
console.log(result.data.booksWithH, result.data.booksWithM);
'''
