var http=require("http");
var wel=require("./vwelcome");
http.createServer(function(req,res){
    res.writeHead(200,{'Content-Type':"text/html"})
    res.write(wel.hello());
    res.end();
}).listen(8080);