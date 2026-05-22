fetch("http://localhost:3030/jsonstore/blog")
    .then((responce) => responce.json())
    .then((result) => console.log(result));


fetch("http://localhost:3030/jsonstore/blog")
    method: "POST",
    headers: {
        'Content'
    }