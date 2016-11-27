"use strict";

function getSimpleMovieUrl (genre, id){
    return `http://www.imdb.com/search/title?genres=${genre}&title_type=feature&0sort=moviemeter,asc&page=${id}&view=simple&ref_=adv_nxt`
}

module.exports.getSimpleMovieUrl = (genre, id) => {
    return getSimpleMovieUrl(genre,id);
};