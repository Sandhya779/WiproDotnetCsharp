var http=require("http");
var gree=require("./vgreet.js");
http.createServer(function(req,res){
    res.writeHead(200,{"Content-Type":"text/html"});
    res.write(gree.greet());
    res.end("End of the greetings!!!")
}).listen(8080);