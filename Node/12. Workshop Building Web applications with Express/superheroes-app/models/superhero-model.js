/* globals require module */

const mongoose = require("mongoose");

let schema = new mongoose.Schema({
    name: {
        type: String,
        required: true
    },
    secretIdentity: {
        type: String,
        required: true,
        unique : true
    },
    alignment: {
        type: String,
        required: true
    },
    story: {
        type: String,
        required: true
    },
    imgUrls: {
        type: [String],
        required: true
    }
});
mongoose.model("Superhero", schema);

module.exports = mongoose.model("Superhero");