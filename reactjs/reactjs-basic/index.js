const express = require("express");
const app = express();

app.use(express.static("public"));
app.set("view engine","ejs");
app.set("views","./views");

app.listen(3000,x=>{
    console.log("server is running on port " , process.env.PORT || 3000);
});

app.get('/',(req,res)=>{
    res.render("home");
});