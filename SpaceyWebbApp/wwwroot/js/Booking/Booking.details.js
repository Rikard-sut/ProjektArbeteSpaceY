const expeditionId = getParam()
$(async function () {
    let expedition = await getExpedition(expeditionId)
    populateDetails(expedition)
    populateSeats(expedition)
    addSorting()
})

function populateDetails(details) {
    let departure = details.departure;
    departure = departure.replace('T', ' ');
    document.querySelector('#departure').innerText = 'Departure: ' + departure;
    document.querySelector('#rocket').innerText = 'Rocket: ' + details.rocket.name;
    document.querySelector('#destination').innerText = 'Destination: ' + details.destination.name;
}

function populateSeats(expedition) {
    const list = document.querySelector('.cabin')
    const expeditionIdInput = document.createElement('input')
    expeditionIdInput.value = expeditionId
    expeditionIdInput.name = 'expeditionId'
    expeditionIdInput.hidden = true

    list.append(expeditionIdInput)
    for (let i = 1; i <= expedition.rocket.seats; i++) {
        const li = document.createElement('li')

        const input = document.createElement('input')
        input.id = i
        input.type = 'checkbox'
        input.value = i
        input.name = 'seats'

        const label = document.createElement('label')
        label.className = 'seat'
        label.htmlFor = i
        label.innerText = i

        li.append(input)
        li.append(label)
        list.append(li)
    }
    for (customer of expedition.customers) {
        document.querySelector('#' + customer.seat).disabled = true
    }
}