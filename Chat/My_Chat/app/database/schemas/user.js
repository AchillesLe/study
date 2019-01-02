'use strict';
var Mongoose  = require('mongoose');
const DEFAULT_USER_PICTURE = "/img/user.jpg";
var userSchema = Mongoose.Schema({
    email : { type : String , require : true },
    username : { type : String , require : true },
    password : { type : String , require : true },
    socialId: { type: String, default: null },
    picture:  { type: String, default:  DEFAULT_USER_PICTURE} ,
    create_date : {type : Date , default : Date.now },
    isDelete  : { type : Number , default : 0 },
});
var userModel = Mongoose.model('users',userSchema);
module.exports = userModel;
