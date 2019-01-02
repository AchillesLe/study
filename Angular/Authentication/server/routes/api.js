const express = require('express');
const router = express.Router();
const mongoose = require('mongoose');
const User = require('../models/user');
const url_db = "mongodb://admin:haithanhf1@ds111804.mlab.com:11804/eventsdb";

mongoose.connect(url_db , err=>{
    if(err){
        console.error('Error '+err);
    }else{
        console.log("connected to mongodb");
    }
});

router.get('/',function(req,res){
    res.send("message from server");
});
router.post('/register',function(req,res){
    let userdata = req.body
    let user = new User(userdata);
    user.save( (err,registerUser)=>{
        if(err){
            console.log(err);
        }else{
            res.status(200).send(registerUser);
        }
    });
});
router.post('/login',function(req,res){
    let userdata = req.body;
    User.findOne({
        email : userdata.email,
        password : userdata.password
    },function(err,user){
        if(err){
            console.log(err);
        }else{
            if(!user){
                res.status(401).send("User name or password not correct .");
            }
            else{
                res.status(200).send(user);
            }
        }
    });
});
router.get('/events',(req,res)=>{
    let events = [
        {
            "_id": 1,
            "name":"Auto Expo",
            "description": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
            "date": "2012-04-23T18:25:43.511Z"
        },
        {
            "_id": 2,
            "name":"Auto Expo",
            "description": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
            "date": "2012-04-23T18:25:43.511Z"
        },
        {
            "_id": 3,
            "name":"Auto Expo",
            "description": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
            "date": "2012-04-23T18:25:43.511Z"
        },
        {
            "_id": 4,
            "name":"Auto Expo",
            "description": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
            "date": "2012-04-23T18:25:43.511Z"
        },
        {
            "_id": 5,
            "name":"Auto Expo",
            "description": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
            "date": "2012-04-23T18:25:43.511Z"
        },
        {
            "_id": 6,
            "name":"Auto Expo",
            "description": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
            "date": "2012-04-23T18:25:43.511Z"
        },
        {
            "_id": 7,
            "name":"Auto Expo",
            "description": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
            "date": "2012-04-23T18:25:43.511Z"
        },
    ];
    // res.status(200).send(events);
    res.json(events);
});
module.exports = router;