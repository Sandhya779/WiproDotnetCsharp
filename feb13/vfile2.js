var fs=require("fs");
fs.appendFile("hi.txt","This is the appended text",
    function(err){
        if(err) throw err;
        console.log("text appended");
    }
)