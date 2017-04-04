
var http = require("http");
var fs = require("fs");
var data = '';
var readerStream = fs.createReadStream('serverdata.txt');

readerStream.setEncoding('UTF8');

readerStream.on('data', function(chunk) 
{
   data += chunk;
});

http.createServer(function (request, response) 
{
   response.writeHead(200, {'Content-Type': 'text/plain'});
   response.end(data.toString());
}).listen(8090);

console.log('Server running at http://127.0.0.1:8090/');

