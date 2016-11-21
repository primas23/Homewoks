/* globals console require setTimeout Promise */
'use strict';

const constants = require("./config/constants");
const htmlDataExtractor = require("./utils/html-data-extractor");
const asyncPagesCount = 15;

htmlDataExtractor.getMoviesFromUrl(constants.genres, asyncPagesCount);