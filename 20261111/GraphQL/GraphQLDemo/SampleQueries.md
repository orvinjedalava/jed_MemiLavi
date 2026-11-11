# Use Unions

```graphql
{
  things {
    __typename
    ... on Book {
      name
      publishDate
      reviews {
        rating
      }
    }
    ... on Magazine {
      name
      genre
    }
  }
}
```
