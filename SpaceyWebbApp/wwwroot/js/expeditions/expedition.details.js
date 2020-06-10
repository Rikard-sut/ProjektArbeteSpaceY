function getParam() {
    var url_string = window.location.href;
    var url = new URL(url_string);
    var c = url.searchParams.get("id");
    return c;
}

$(function () {
    var jqxhr = $.get('/api/expeditions/' + getParam())
        .done(() => {
            populateDetails(jqxhr.responseJSON)
            populateCustomerTable(jqxhr.responseJSON.customers)
        })
        .fail(() => {

        })
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

const deleteButton = document.querySelector("#deleteButton")
deleteButton.addEventListener('click', () => {
    $.ajax({
        url: '/api/expeditions/' + getParam(),
        method: 'DELETE'
    })
        .done(() => {
            console.log('deleted')
        })
        .fail(() => {
            console.log('fail')
        })
})


$(document).ajaxComplete(function () {
    $('.table').DataTable({});
    $('.dataTables_length').addClass('bs-select');
});