$(function () {
    var jqxhr = $.get('/api/expeditions')
        .done(() => {
            populateTable(jqxhr.responseJSON)
        })
        .fail(() => {

        })
})

function populateTable(expeditions) {
    for (const expedition of expeditions) {
        var markup = "<tr><td>" + expedition.departure + "</td><td>" + expedition.destination.name + "</td><td>" + expedition.rocket.name + "</td></tr>";
        $('.table').append(markup)
    }
}