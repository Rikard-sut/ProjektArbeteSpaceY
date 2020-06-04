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
        const bookedSeats = expedition.customers.length
        var markup = "<tr class='table-row' data-href='/admin/expedition/?id=" + expedition.expeditionId + "'><td>" + expedition.departure + "</td><td>" + expedition.destination.name + "</td><td>" + expedition.rocket.name + "</td><td>" + bookedSeats + "/" + expedition.rocket.seats + "</td> </tr> ";
        $('.table').append(markup)
    }
    addListener();
}

function addListener() {
    const rows = document.querySelectorAll('.table-row')
    for (const row of rows) {
        row.addEventListener('click', () => {
            window.document.location = row.getAttribute("data-href")
        })
    }
}
