/* globals console require setTimeout Promise */
'use strict';

const httpRequester = require("./http-requester");
const htmlParser = require("./html-parser");
const queuesFactory = require("./../data-structures/queue");
const modelsFactory = require("./../models");
const constants = require("./../config/constants");
const timeOut = require("./time-out-helper");
const urlGenerator = require("./url-generator");

require("./../config/mongoose")(constants.connectionString);

let urlsQueue = queuesFactory.getQueue();

function getMoviesFromUrl(url) {
    console.log(`Working with ${url}`);
    httpRequester.get(url)
        .then((result) => {
            const selector = constants.simpleMovieClassSelector;
            const html = result.body;
            return htmlParser.parseSimpleMovie(selector, html);
        })
        .then(movies => {
            let dbMovies = movies.map(movie => {
                return modelsFactory.getSimpleMovie(movie.title, movie.url);
            });

            modelsFactory.insertManySimpleMovies(dbMovies);

            return timeOut.wait(1000);
        })
        .then(() => {
            if (urlsQueue.isEmpty()) {
                return;
            }

            getMoviesFromUrl(urlsQueue.pop());
        })
        .catch((err) => {
            console.dir(err, { colors: true });
        });
}

module.exports.insertMoviesInDb = (genres, pageCount) => {    
    genres.forEach(genre => {
    for (let i = 0; i < constants.pagesCount; i += 1) {
        let url = urlGenerator.getSimpleMovieUrl(genre, i+1);        
        urlsQueue.push(url);
        }
    });    

    Array.from({ length: pageCount })
        .forEach(() => getMoviesFromUrl(urlsQueue.pop()));
};

module.exports.InserMovieDetailsInDb = (genres, pageCount) => {    
    // Nqmah vreme da go napravq ;(
};

module.exports.InserActorInDb = (genres, pageCount) => {    
    // Nqmah vreme da go napravq ;(
};