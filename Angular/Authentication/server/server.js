const express = require('express');
const bodyParser = require('body-parser');
const port = process.env.PORT || 3000;
const app = express();
const api = require('./routes/api');

app.use(bodyParser.urlencoded({ extended: false }))
// parse application/json
app.use(bodyParser.json())
app.use('/api',api);
app.get('/',function(req,res){
    res.send("Server is running");
});
app.listen(port,function(){
    console.log("server is running on localhost:"+port);
});