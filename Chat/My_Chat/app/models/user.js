'use strict';

// const user = require('../database/schemas/user');
const user = require('../database/connection').models.user;


var create = function( data , callback ){
	
	var user_temp = new user(data);
	user_temp.save( callback );
};
var findById = function( id , callback){
    user.findById(id , callback);
};
var findOne = function( data , callback){
    user.findOne( data , callback );
};
module.exports = { 
	create, 
	findOne, 
	findById, 
	// findOrCreate, 
	// isAuthenticated 
};
