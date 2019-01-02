'use strict';
const User = require('../models/user');
const passport = require('passport');
const LocalStrategy = require('passport-local').Strategy;

var init = function(){

    passport.serializeUser(function(user, done) {
        done(null, user.id);
      });
      
      passport.deserializeUser(function(id, done) {
        User.findById(id, function(err, user) {
            done(err, user);
        });
      });

    passport.use('local-login', new LocalStrategy({
        usernameField : 'email',
        passwordField : 'password',
        passReqToCallback : true ,
        session: false

    } , function(req, username, password, done ){

        User.findOne({ email: username , password : password } , function(err,user){

            if(err) { return done(err); }

            if(!user) {
                return done(null, false, { message: 'Incorrect username or password.' } );
            }
            return done(null , user);

        //     user.validatePassword(password, function(err, isMatch) {

        //         if (err) { return done(err); }
                
	    //     	if (!isMatch){
	    //     		return done(null, false, { message: 'Incorrect username or password.' });
        //         }
                
	    //     	return done(null, user);
        //   });
          
        });
    }));

    return passport;
}
module.exports = init();