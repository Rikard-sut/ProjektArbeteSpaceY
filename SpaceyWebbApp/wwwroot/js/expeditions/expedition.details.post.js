const destinationSelect = document.querySelector('#destinationSelect')
const rocketSelect = document.querySelector('#rocketSelect')

fetchDestinations()
fetchRockets()

function fetchDestinations() {
    $.get("https://localhost:44314/api/destinations", function (data) {
        console.log(data)
        for (const item of data) {
            const option = document.createElement('option')
            option.value = item.destinationId
            option.innerText = item.name

            destinationSelect.append(option)
        }
    });
}

function fetchRockets() {
    $.get("https://localhost:44314/api/rockets", function (data) {
        console.log(data)
        for (const item of data) {
            const option = document.createElement('option')
            option.value = item.rocketId
            option.innerText = item.name

            rocketSelect.append(option)
        }
    });
}

//Post to backend
const form = document.querySelector('form')
form.addEventListener('submit', (event) => {
    event.preventDefault()
    var jqxhr = $.post('/api/expeditions', $('#form').serialize())
        .done(() => {
            //redirect to rockets list
        })
        .fail(() => {

        })
})