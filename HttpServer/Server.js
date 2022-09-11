const http = require("http");

//REQ = Request --- RES = Response
//req.url pega o cabeçalho do url
//res.end responde ao req diretamente no navegador
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

//Listen precisa de uma porta e um endereço para funcionar
//O servidor http está rodando na porta 3001 e no endereço localhost
server.listen(3001, "localhost", () => {
    console.log("Hospedado em http://localhost:3001");
    console.log("ctrl + c para sair");
});
