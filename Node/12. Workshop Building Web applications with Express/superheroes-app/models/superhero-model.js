/* globals require module */

function validator (v) {
  return v.length > 5;
}

const mongoose = require("mongoose");

let schema = new mongoose.Schema({
    name: {
        type: String,
        required: true,
        validate: [validator, 'my error type']
    },
    secretIdentity: {
        type: String,
        required: true,
        unique : true
    },
    alignment: {
        enum: ["good", "evil", "neutral"],
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