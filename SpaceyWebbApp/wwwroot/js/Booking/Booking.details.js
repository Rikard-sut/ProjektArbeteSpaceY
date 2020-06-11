const expeditionId = getParam()
$(async function () {
    let expedition = await getExpedition(expeditionId)
    populateDetails(expedition)
    populateCustomerTable(expedition.customers)
    addSorting()
})

function populateCustomerTable(customers) {
    for (const customer of customers) {
        const tableRow = document.createElement('tr')
        const fullName = document.createElement('td')
        const seatNumber = document.createElement('td')

        fullName.innerText = customer.fullName
        seatNumber.innerText = customer.seatNumber

        tableRow.append(fullName)
        tableRow.append(seatNumber)

        $('.table').append(tableRow)
    }
}

function populateDetails(details) {
    let departure = details.departure;
    departure = departure.replace('T', ' ');
    document.querySelector('#departure').innerText = 'Departure: ' + departure;
    document.querySelector('#rocket').innerText = 'Rocket: ' + details.rocket.name;
    document.querySelector('#destination').innerText = 'Destination: ' + details.destination.name;
}