var express = require('express');
var app = express();
var bodyParser = require('body-parser');

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
   // Prepare output in JSON format
   response = {
      first_name:req.body.firstName,
      last_name:req.body.secondName,
	  user_name:req.body.userName,
	  user_email:req.body.emailAddress
   };
   console.log(response);
   res.end(JSON.stringify(response));
})

var server = app.listen(8090, function () 
{
   var host = server.address().address
   var port = server.address().port
   console.log("Example app listening at http://%s:%s", host, port)
})


