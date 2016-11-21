/* globals console require setTimeout Promise */
'use strict';

const queuesFactory = require("./data-structures/queue");
const constants = require("./config/constants");
const htmlDataExtractor = require("./utils/html-data-extractor");
const asyncPagesCount = 15;

htmlDataExtractor.getMoviesFromUrl(constants.genres, asyncPagesCount);