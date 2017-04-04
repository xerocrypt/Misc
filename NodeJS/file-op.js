

var http = require("http");
var fs = require("fs");
var data = fs.readFileSync('serverdata.txt');

http.createServer(function (request, response) 
{
   response.writeHead(200, {'Content-Type': 'text/plain'});
   response.end(data.toString());
}).listen(8090);

console.log('Server running at http://127.0.0.1:8090/');