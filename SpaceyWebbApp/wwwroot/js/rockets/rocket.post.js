//Post to backend
const form = document.querySelector('form')
form.addEventListener('submit', async (event) => {
    event.preventDefault()
    if(await addRocket($('#form').serialize())){
        location.reload()
    }
    else {
        //Display error
    }
})