const http = require("http");

const server = http.createServer((req, res) => {
    switch (req.url.toUpperCase()) {
        case "/":
            res.end("<h1>HOME</h1>");
            break;
        case "/CONTATOS":
            res.end("<h1>CONTATOS</h1>");
            break;
        case "/SOBRE":
            res.end("<h1>SOBRE</h1>");
            break;
        default:
            res.end("<h1>404 - NOT FOUND</h1>");
            break;
    }
});

server.listen(3001, "localhost", () => {
    console.log("Hospedado em http://localhost:3001");
    console.log("ctrl + c para sair");
});
