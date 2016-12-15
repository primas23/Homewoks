/* globals Promise */
"use strict";

function wait(time) {
    return new Promise((resolve) => {
        setTimeout(() => {
            resolve();
        }, time);
    });
}

module.exports.wait = time => {
    return wait(time);
};