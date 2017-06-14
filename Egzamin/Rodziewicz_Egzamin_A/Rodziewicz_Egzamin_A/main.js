/* A.3 */
$(document).ready(function (e) {
    $('#submitButton').click(showAlert);
    $('#mainHeader').text(student.name); /* A.5 */
    $('#hideButton').click(hidePage);
});

function showAlert(e) {
    e.preventDefault();
    alert("halo");
}

var student = { 'index': '226105', 'name': 'Bartosz Rodziewicz' }; /* A.4 */

function hidePage(e) {
    e.preventDefault();
    $('#mainBody').hide('slow');
}