var fs=require("fs");

fs.writeFile("hi.txt","Hello World",
    function(err){
        if(err) throw err;
        console.log("File created.....");
    }
);
