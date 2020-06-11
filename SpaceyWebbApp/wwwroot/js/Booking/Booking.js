$(async function () {
    let expedition = await getExpedition()
    populateTable(expedition)
    addSorting()
})

function populateTable(expeditions) {
    for (const expedition of expeditions) {
        let departureTime = expedition.departure
        departureTime = departureTime.replace('T', ' ')
        const bookedSeats = expedition.customers.length

        const tableRow = document.createElement('tr')
        tableRow.className = 'table-row'
        tableRow.setAttribute('data-href', '/booking/bookpage/?id=' + expedition.expeditionId)

        const departure = document.createElement('td')
        departure.innerText = departureTime

        const destination = document.createElement('td')
        destination.innerText = expedition.destination.name

        const rocket = document.createElement('td')
        rocket.innerText = expedition.rocket.name

        const seats = document.createElement('td')
        seats.innerText = bookedSeats + "/" + expedition.rocket.seats

        tableRow.append(departure)
        tableRow.append(destination)
        tableRow.append(rocket)
        tableRow.append(seats)

        $('.table').append(tableRow)

        tableRow.addEventListener('click', () => {
            window.document.location = tableRow.getAttribute("data-href")
        })
    }
}