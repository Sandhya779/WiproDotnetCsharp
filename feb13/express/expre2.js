var exp=require("express");
var app=exp();

app.get("/combine/:firstname/:lastname",(req,res)=>{
    const firstname=req.params.firstname;
    const lastname=req.params.lastname;
    let fullname=firstname +" " + lastname;
    res.send(fullname);

})

app.get("/place/:name/:city",(req,res)=>{
    const name=req.params.name;
    const city=req.params.city;
    res.send("hello " + name + " living at " + city );
})

app.get("/show/:name",(req,res)=>{
    const name=req.params.name;
    res.send("hi "+name+" how are you??");
})

app.get("/",(req,res)=>{
    res.send("HEllO this is home page!!!");
})

app.get("/sandhya",(req,res)=>{
    res.send("Hello Im Sandhya from Wipro!!");
})

app.listen(1111,(req,res)=>{
    console.log("This file is running on 1111");
})