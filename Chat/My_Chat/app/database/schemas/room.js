'use strict';
var Mongoose  = require('mongoose');

var roomSchema = Mongoose.Schema({
    name : { type : String , require : true },
    connection : { type: [{ userId: String, socketId: String }]},
    create_id :{ type:String , default:null },
    create_date : { type : Date , default : Date.now },
    isDelete : { type : Number , default : 0 }
});

var roomModel = Mongoose.model('rooms',roomSchema);
module.exports = roomModel;