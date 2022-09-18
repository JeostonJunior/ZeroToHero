//Para usar o servidor http deve-se dar um require no modulo http do nodeJs
const http = require("http");

//REQ = Request --- RES = Response
//req.url pega o cabeçalho do url
//res.end responde ao req diretamente no navegador
//A função createServer é uma função que recebe 2 parametros de entrada, uma request e uma response
//A request é responsavel por pegar as informações passadas no cabeçalho da página(url), e a response é as informações
//que serão respondidas quando for solicitada uma request

/*
A request nescessita de um status que é passado no cabeçalho da página
-- Ex http://localhost:3000/Contatos
Ela também depende de um host nessa caso um IP e PORTA
-- Ex localhost:3000

> new URL(request.url, `http://${request.getHeaders().host}`)
URL {
  href: 'http://localhost:3000/contato',
  origin: 'http://localhost:3000',
  protocol: 'http:',
  host: 'localhost:3000',
  port: '3000',
}
*/

// Esse processo é feito por um GET, ou seja as informações são requisitadas e não passadas
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

/*
--res.end é um função que quando ocorre uma request com o status solicitado, o res.end responde atraves
de um response diretamente dentro da pagina html do server http
*/

//Listen precisa de uma porta e um endereço para funcionar
//O servidor http está rodando na porta 3001 e no endereço localhost
/*
O server listen é uma função assincrona que recebe a PORTA e IP em que o servidor será iniciado,
portanto fica 'observando' a porta e o ip até que o servidor seja encerrado ou ocorra um erro que quebre o código
*/
server.listen(3000, "localhost", () => {
    console.log("Hospedado em http://localhost:3000");
    console.log("ctrl + c para sair");
});
