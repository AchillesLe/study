'use strict';
var Mongoose  = require('mongoose');
var config = require('../config/config.json');

// var url = 'mongodb://' +
//         encodeURIComponent(config)
//         config.db.host + '/';
var url ="mongodb://127.0.0.1/My_Chat";

Mongoose.connect(url);

var Connect = function(callback){
	Mongoose.connect(url,callback);
}

module.exports = { Mongoose, 
	Connect ,
	models: {
		user: require('./schemas/user.js'),
		room: require('./schemas/room.js')
	}
};