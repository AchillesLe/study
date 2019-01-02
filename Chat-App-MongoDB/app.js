const app  = require('express')();
const http = require('http').Server(app);
const io   = require('socket.io')(http);
const MongoClient = require('mongodb').MongoClient;

const url = 'mongodb://localhost:27017';
const dbName = 'mongochatapp';

    http.listen(3000 , function(err){
        if(err){
            throw err;
        }
        console.log('server is runing on port 3000....');
    });

    app.get('/',function(req,res){
        res.sendFile(__dirname + '/index.html');
    });

    MongoClient.connect( url , function(err, client) {

        console.log("Connected successfully to server");
        
        io.on('connection' , function(socket){

            console.log('a user .' + socket.id );
            console.log(socket );

            socket.on('disconnect' , function(){
                console.log('disconnected.');
            });
            let db = client.db(dbName);
            let chats = db.collection('chats');

            chats.find().limit(100).toArray(function(err,res){
                if(err){
                    throw err;
                }
                socket.emit('output' , res);
            });
            
            socket.on('send',function(data){
                chats.insert({ user : data.username , message : data.message });
                io.sockets.emit('rep',data);
            });

        });

    });



