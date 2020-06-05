$(function () {
    var jqxhr = $.get('/api/destinations')
        .done(() => {
            populateTable(jqxhr.responseJSON)
        })
        .fail(() => {

        })
})

function populateTable(destinations) {
    for (const destination of destinations) {
        var markup = "<tr><td>" + destination.name + "</td><td>" + destination.expeditionRange + "</td></tr>";
        $('.table').append(markup)
    }
}