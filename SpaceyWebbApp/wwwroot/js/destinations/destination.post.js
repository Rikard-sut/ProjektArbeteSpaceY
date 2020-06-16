//Post to backend
const form = document.querySelector('form')
form.addEventListener('submit', (event) => {
    event.preventDefault()
    if (addDestination($('#form').serialize())) {
        location.reload()
    }
    else {
        //Display error
    }
})