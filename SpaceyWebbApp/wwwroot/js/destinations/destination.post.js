//Post to backend
const form = document.querySelector('form')
form.addEventListener('submit', (event) => {
    event.preventDefault()
    var jqxhr = $.post('/api/destinations', $('#form').serialize())
        .done(() => {
            location.reload()
        })
        .fail(() => {

        })
})