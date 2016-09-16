function task02() {
    var divElemnt = document.getElementById('map');
    document.getElementById('titleId').innerText = 'Popup';
    divElemnt.innerText = 'Testing the code';

    // Create content
    var bodyContent = '<div id="myModal" class="modal">'
        + '     <div class="modal-content">'
        + '         <span class="close">×</span>'
        + '         <p>The Popup will close and redirect you automaticly</p>'
        + '     </div>'
        + '</div>';

    divElemnt.innerHTML = bodyContent;

    // Hide the popup
    var modal = document.getElementById('myModal');
    var span = document.getElementsByClassName("close")[0];

    span.onclick = function () {
        modal.style.display = "none";
    };

    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    };

    // The Promise
    var promisPopup = new Promise(
        function (resolve, reject) {
            modal.style.display = "block";
            setTimeout(function () {
                window.location.assign("http://9gag.com/");
            }, 3000);
        }
    );

    promisPopup();
}