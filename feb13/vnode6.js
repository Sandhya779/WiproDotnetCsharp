var http=require("http");
var vd=require("./vdatetime");
http.createServer(function(req,res){
    res.writeHead(200,{"Content-Type":"text/html"});
    res.write(vd.mydate());
}).listen(8080);