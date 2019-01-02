

'use strict';
const express      = require('express');
const app          = express();
const path         = require('path');
const bodypaser    = require('body-parser');

const user         = require('./app/models/user');
const room         = require('./app/models/room');

const session      = require('express-session');
const flash        = require('connect-flash');
const cookieParser = require('cookie-Parser');
const router       = require('./app/routes/router');
const passport     = require('./app/auth/auth');
const port         = process.env.PORT || 3000;

const http         = require('http').Server(app);
const ioServer     = require('socket.io')(http);

// set view

app.engine('ejs', require('express-ejs-extend'));
app.set('view engine' , 'ejs');
app.set('views',path.join(__dirname,'app/views'));
// use pulic
app.use(express.static('public'));
app.use(bodypaser.json());
app.use(bodypaser.urlencoded( {extended : false} ) );
// user cookie , session , flash..
app.use(cookieParser());
app.use(session({ 
    secret : '12345678',
    saveUninitialized :true,
    resave : true
 }));
app.use(flash());
app.use(passport.initialize());
app.use(passport.session());
// user route
app.use('/' , router);

app.use( function(req,res,next){
    res.status(404).sendFile(process.cwd() + '/app/views/404.html');
});


var users  = []; // list user online
var rooms  = []; 
ioServer.sockets.on('connection',function(socket){

    console.log('User '+ socket.id + ' connected.');
    
    socket.on('disconnect' , function(){
        console.log('User '+ socket.id + ' disconnected.');
    });

    var _data = room.find({},function(err , data ){
        if(err) {
            throw err;
        }
        ioServer.sockets.emit('list_room',data);
    });

    socket.on( 'join_room_client' , function(data){
        var room_id   = data.room_id;
        var room_name = data.room_name;
        var user_name = data.user_name;
        var id = socket.id;
        socket.phong = room_name;
        socket.join( room_name );
        ioServer.to(room_name).emit('user_join', { id : id , user_name :user_name });

        users.push()
    
    });
   
    socket.on('chat-message-in-room' , function(data){
        let message = data.message;
        let room_name = data.room_name;
        let user_name = data.user_name;
        ioServer.to(room_name).emit('server-chat-message-in-room' , { from_id : socket.id , message : message , user_name:user_name } );
    });

});


http.listen(port ,function(err){
    if(err) {
        throw err;
    }
    console.log('Server is running on port ', port );
});
