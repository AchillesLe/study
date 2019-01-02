var Express = require('express');
var ExpressHandlebars = require('express-handlebars');
var ExpressValidator = require('express-validator');
var ExpressSession = require('express-session');
var Passport = require('passport');
var LocalStrategy = require('passport-local').Strategy;
var Mongo = require('mongodb');
var Mongoose = require('mongoose');
var Flash = require('connect-flash');
var Path = require('path');
var CookieParser = require('cookie-parser');
var BodyParser = require('body-parser');

Mongoose.connect('mongodb://localhost/loginapp');
var db = Mongoose.connection;