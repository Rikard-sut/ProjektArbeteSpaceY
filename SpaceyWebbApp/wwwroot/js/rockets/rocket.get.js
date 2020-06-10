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
        const tableRow = document.createElement('tr')
        const name = document.createElement('td')
        const range = document.createElement('td')
        const seats = document.createElement('td')

        name.innerText = rocket.name
        range.innerText = rocket.range
        seats.innerText = rocket.seats

        tableRow.append(name)
        tableRow.append(range)
        tableRow.append(seats)

        $('.table').append(tableRow)
    }
}