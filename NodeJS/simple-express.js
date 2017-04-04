var express = require('express');
var app = express();

app.use(express.static('express-site'));

app.get('/', function (req, res) 
{
   res.sendFile( __dirname + "/express-site/" + "index.html" );
})

app.get('/listusers', function (req, res) 
{
   console.log("Got a GET request for /list_user");
   res.sendFile( __dirname + "/express-site/" + "users.html" );
})

var server = app.listen(8090, function () 
{
   var host = server.address().address
   var port = server.address().port
   console.log("Example app listening at http://%s:%s", host, port)
})

