var http = require("http");
var fs = require("fs");
var writedata = 'This is another new line written to the file';
var readdata = '';


var writerStream = fs.createWriteStream('serverdata.txt');

writerStream.write(writedata,'UTF8');
writerStream.end();

writerStream.on('finish', function() {
    console.log("Write completed.");
});
