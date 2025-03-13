var http=require("http");
var vari=require("./vvarex");
http.createServer(function(req,res){
    res.writeHead(200,{"Content-Type":"text/html"});
    res.write(vari.show("sandhya","sagar"));
}).listen(8080);