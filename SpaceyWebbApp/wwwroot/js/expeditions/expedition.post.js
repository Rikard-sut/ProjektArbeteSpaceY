const destinationSelect = document.querySelector('#destinationSelect')
const rocketSelect = document.querySelector('#rocketSelect')

fetchDestinations()
fetchRockets()

function fetchDestinations() {
    $.get("/api/destinations", function (data) {
        for (const item of data) {
            const option = document.createElement('option')
            option.value = item.destinationId
            option.innerText = item.name
            option.setAttribute('range', item.expeditionRange)

            destinationSelect.append(option)
        }
    });
}

function fetchRockets() {
    $.get("/api/rockets", function (data) {
        for (const item of data) {
            const option = document.createElement('option')
            option.value = item.rocketId
            option.innerText = item.name
            option.setAttribute('range', item.range)

            rocketSelect.append(option)
        }
    });
}

//Post to backend
const form = document.querySelector('form')
form.addEventListener('submit', (event) => {
    event.preventDefault()
    const rockRange = Number($("#rocketSelect :selected").attr('range'))
    const destRange = Number($("#destinationSelect :selected").attr('range'))

    if (rockRange >= destRange) {
        var jqxhr = $.post('/api/expeditions', $('#form').serialize())
            .done(() => {
                window.location = '/admin/'
            })
            .fail(() => {

            })
    }
    else {
        alert('Rocket range is to short for this destination.')
    }
})