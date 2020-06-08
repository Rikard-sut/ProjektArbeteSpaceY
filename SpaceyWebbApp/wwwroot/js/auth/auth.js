const form = document.querySelector('form')
form.addEventListener('submit', (event) => {
    console.log($('#form').serialize())
    event.preventDefault()
    var jqxhr = $.post('/api/users', $('#form').serialize())
        .done(() => {
            console.log("true")
        })
        .fail(() => {
            console.log("hh")
        })
})