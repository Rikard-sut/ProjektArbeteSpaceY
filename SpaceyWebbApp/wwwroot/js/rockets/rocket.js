//Post to backend
const form = document.querySelector('form')
form.addEventListener('submit', (event) => {
    event.preventDefault()
    var jqxhr = $.post('/api/rockets', $('#form').serialize())
        .done(() => {
            //redirect to rockets list
        })
        .fail(() => {

        })
})