var exp=require("express");
var app=exp();

app.get("/",(req,res)=>{
    res.send("Welcome to express js....");
})
app.listen(3000,()=>{
    console.log("File running on 3000...");
})