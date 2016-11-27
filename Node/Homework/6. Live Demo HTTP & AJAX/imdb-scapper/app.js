/* globals console require setTimeout Promise */
'use strict';

const constants = require("./config/constants");
const dataCreator = require("./utils/data-creator");
const asyncPagesCount = 15;

dataCreator.insertMoviesInDb(constants.genres, asyncPagesCount);