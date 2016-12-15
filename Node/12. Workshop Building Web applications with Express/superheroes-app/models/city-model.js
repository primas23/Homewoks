/* globals require module */

const mongoose = require("mongoose");

let schema = new mongoose.Schema({
    name: {
        type: String,
        required: true,
        unique : true
    }    
});
mongoose.model("City", schema);

module.exports = mongoose.model("City");