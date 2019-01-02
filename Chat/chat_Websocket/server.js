var express = require('express');
var app     = express();
var server  = require('http').Server(app);
var io      = require('socket.io')(server);

server.listen(process.env.PORT || 3000 , function(){
    console.log('Server is running .....');
});
var users       = [];
var connections = [];

app.use(express.static('public'));
app.get('/',function(req,res){
    res.sendFile(__dirname + '/index.html');
});

io.sockets.on('connection',function(socket){
    connections.push(socket);
    console.log('User  %s connected .', socket.id);

    socket.on('send_message' ,function(data){
        io.sockets.emit('new_message', data );
    });

    socket.on('new user' , function(data , callback){
        callback(true);
        socket.username = data ;
        users.push(socket.username);
        updateListUser();
    }); 

    function updateListUser(){
        io.sockets.emit('listUser',{ users : users , new_user : socket.username });
    }   

    socket.on('disconnect',function(){
        if(!socket.username) return;
        users.splice(users.indexOf(socket.username), 1);
        connections.splice( connections.indexOf(socket) , 1);
        console.log('User %s disconnected', socket.id);
    });
    

});
