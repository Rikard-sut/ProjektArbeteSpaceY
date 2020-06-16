$(async function () {
    let rockets = await getRockets()
    populateTable(rockets)
    addSorting()
})

function populateTable(rockets) {
    for (const rocket of rockets) {
        if (rocket.range == 50) {
            rocket.range = 'Low'
        }
        else if (rocket.range == 100) {
            rocket.range = 'Medium'
        }
        else {
            rocket.range = 'High'
        }
        const card = document.createElement('div')
        card.className = 'card'

        const img = document.createElement('img')
        img.className = 'card-img-top'
        img.src = '/img/rocket_launch.jpg'

        const cardTitle = document.createElement('h5')
        cardTitle.className = 'card-title'
        cardTitle.innerText = rocket.name

        const cardBody = document.createElement('div')
        cardBody.className = 'card-body'

        const rangeText = document.createElement('p')
        rangeText.className = 'card-text'
        rangeText.innerText = 'Range: ' + rocket.range

        const seatsText = document.createElement('p')
        seatsText.className = 'card-text'
        seatsText.innerText = 'Seats: ' + rocket.seats

        cardBody.append(seatsText)
        cardBody.append(rangeText)

        card.append(img)
        card.append(cardTitle)
        card.append(cardBody)

        $('.cards').append(card)
    }
}