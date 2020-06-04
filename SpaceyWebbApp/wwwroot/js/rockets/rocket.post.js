//Post to backend
const form = document.querySelector('form')
form.addEventListener('submit', (event) => {
    console.log($('#form').serialize())
    event.preventDefault()
    var jqxhr = $.post('/api/rockets', $('#form').serialize())
        .done(() => {
            window.location = '/admin/rockets'
        })
        .fail(() => {

        })
})