$(function () {
    var jqxhr = $.get('/api/rockets')
        .done(() => {
            populateTable(jqxhr.responseJSON)
        })
        .fail(() => {

        })
})

function populateTable(rockets) {
    for (const rocket of rockets) {
        var markup = "<tr><td>" + rocket.name + "</td><td>" + rocket.range + "</td><td>" + rocket.seats + "</td></tr>";
        $('.table').append(markup)
    }
}