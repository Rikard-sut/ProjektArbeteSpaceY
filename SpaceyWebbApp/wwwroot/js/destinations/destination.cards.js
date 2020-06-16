$(async function () {
    let destinations = await getDestinations()
    populateCards(destinations)
})

function populateCards(destinations) {
    for (const destination of destinations) {
        if (destination.expeditionRange == 50) {
            destination.expeditionRange = 'Low'
        }
        else if (destination.expeditionRange == 100) {
            destination.expeditionRange = 'Medium'
        }
        else {
            destination.expeditionRange = 'High'
        }
        const card = document.createElement('div')
        card.className = 'card'

        const img = document.createElement('img')
        img.className = 'card-img-top'
        img.src = '/img/satelite_sand.jpg'

        const cardTitle = document.createElement('h5')
        cardTitle.className = 'card-title'
        cardTitle.innerText = destination.name

        const cardBody = document.createElement('div')
        cardBody.className = 'card-body'

        const rangeText = document.createElement('p')
        rangeText.className = 'card-text'
        rangeText.innerText = 'Range: ' + destination.expeditionRange

        cardBody.append(rangeText)

        card.append(img)
        card.append(cardTitle)
        card.append(cardBody)

        $('.cards').append(card)
    }
}