'use strict';

const express	 	= require('express');
const router 		= express.Router();
const passport 		= require('../auth/auth.js');

var user = require('../models/user.js');
var room = require('../models/room.js');

router.get('/',function(req,res,next){
    if(req.isAuthenticated()){
        res.redirect('/home');
    }
    res.redirect('/login');
});

router.get('/login',function(req,res,next){
    if(req.isAuthenticated()){
        res.redirect('/home');
    }
    else{
        res.render('login' , {
            message : req.flash('message')
        });
    }
});

// router.post('/login', function(req,res,next){
//     var email  = ( req.body.email ).trim();
//     var password  = ( req.body.password ).trim();

//     user.findOne({ 'email' : email , 'password' : password } , function(err , data ){
//         if( data ){
//             res.redirect('/home');
//         }
//         else{
//             req.flash('message',' email or password incorrect !');
//             res.redirect('login');
//         }
//     });
// });
router.post('/login', function(req,res,next){

    passport.authenticate('local-login', function(err, user, info) {
        if (err) { return next(err); }

        if (!user) { 

            req.flash('message',' email or password incorrect !');
            return res.redirect('/login'); 
        }

        req.logIn(user, function(err) {
            if (err) { return next(err); }
            return res.redirect('/home');
        });
    })(req, res, next);

});

router.get('/logout',function(req,res,next){
    req.logout();
    res.redirect('/login');
});

router.get('/register',function(req,res,next){
    res.render('register',{
        message_regis : req.flash('message_regis')
    });
});

router.post('/register',function(req,res,next){
    // valide input
    var email    = ( req.body.email ).trim();
    var username = ( req.body.username ).trim();
    var password = ( req.body.password ).trim();
    
    user.findOne({ 'email' : email } , function(err , data ){
        if(data){
            req.flash('message_regis','Email has existed !');
            res.redirect('/register');
        }else{
            var user_temp = {
                'email' : email ,
                'username' : username ,
                'password' : password
            };
            user.create( user_temp , function(err , NULL ){    
                res.redirect('/login');
            });
        }
    });

});

router.get('/home',   function(req,res,next){
    if(req.isAuthenticated()){
        res.render('page/home',{
            user_name : req.user.username
        });
    }else{
        res.redirect('/login');
    }
});
router.post('/room',   function(req,res,next){
    if(req.isAuthenticated()){
        if(typeof req.user !== 'undefined'){

            let user_id = req.user.id;
            let room_name = req.body.room_name;
            let data = {
                name : room_name ,
                create_id : user_id ,
            };
    
            room.findOne(data,function(err,_data){
                
                if(err){
                    res.json({
                        message : 'Has an error when creating room , try again .',
                        success_code : 0
                    });
                }
                if(_data){
                    res.json({
                        message : room_name + ' room already exists , try again .',
                        success_code : 1
                    });
                }
                else{
                    room.create( data , function(err,result){
                        if(err){
                            res.json({
                                message : 'Has an error when creating room , try again .',
                                success_code : 0
                            });
                        }
                        res.json({
                            room_id : result.id,
                            message : ' Created ' + room_name + ' successfully .',
                            success_code : 2,
                        });
                    });
                }
            });
        }
    }
    
});

module.exports = router;