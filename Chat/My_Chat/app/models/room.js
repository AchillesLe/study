'use strict';
const User      = require('../models/user');
const RoomModel = require('../database/connection').models.room;

var create = function(data,callback){
    var room = new RoomModel(data);
    room.save(callback);
    return room;
}
var find = function(data,callback){
    RoomModel.find(data,callback);
}
var findOne = function(data,callback){
    RoomModel.findOne(data,callback);
}
var findById = function(id,callback){
    RoomModel.findById(id,callback);
}
var findByIdAndUpdate = function(id,data,callback){
    RoomModel.findByIdAndUpdate(id,data,{new:true},callback);
}
var addUser = function(room, socket, callback){
    var userId = socket.request.session.passport.user;
    var conn = { userId: userId, socketId: socket.id};
    room.connection.push(conn);
    room.save(callback);
}

// var getUsers = function(room,socket,callback){
//     var users = [] , vis   = {} , cunt  = 0;
//     var userId = socket.request.session.passport.user;   
    
//     room.connection.forEach(function(conn){
//         if(conn.userId === userId){
//             cunt++;
//         }
//     });
// }

module.exports = {
    create ,
    find ,
    findOne ,
    findById ,
    findByIdAndUpdate ,
    addUser
}