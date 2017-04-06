var express = require('express');
var app = express();
var bodyParser = require('body-parser');
var fs = require("fs");

var urlencodedParser = bodyParser.urlencoded({ extended: false })

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


app.post('/adduser', urlencodedParser, function (req, res) 
{
	response = {
    firstName:req.body.firstName,
    secondName:req.body.secondName,
	user_name:req.body.userName,
	user_email:req.body.emailAddress
	}

	var userWrite = JSON.stringify(response);
	var writerStream = fs.createWriteStream('users.json', {flags: 'a'});

	writerStream.write(userWrite);
	writerStream.end();
	res.sendFile( __dirname + "/express-site/" + "users.html" );
});


var server = app.listen(8090, function () 
{
   var host = server.address().address
   var port = server.address().port
   console.log("Example app listening at http://%s:%s", host, port)
})


