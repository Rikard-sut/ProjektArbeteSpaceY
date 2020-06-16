$(async function () {
    let destinations = await getDestinations()
    populateTable(destinations)
    addSorting()
})

function populateTable(destinations) {
    for (const destination of destinations) {
        const tableRow = document.createElement('tr')
        const name = document.createElement('td')
        const range = document.createElement('td')

        name.innerText = destination.name
        range.innerText = destination.expeditionRange

        tableRow.append(name)
        tableRow.append(range)

        $('.table').append(tableRow)
    }
}