var http=require("http");
var url=require("url");
http.createServer(function(req,res){
    res.writeHead(200,{"Content-Type":"text/html"});
    var q=url.parse(req.url,true).query;
    var op= q.first +" " +q.last;
    res.write(op);
    res.end();
}).listen(8080);