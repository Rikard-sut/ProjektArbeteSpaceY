﻿//Post to backend
const form = document.querySelector('form')
form.addEventListener('submit', (event) => {
    console.log($('#form').serialize())
    event.preventDefault()
    var jqxhr = $.post('/api/rockets', $('#form').serialize())
        .done(() => {
            location.reload()
        })
        .fail(() => {
            console.log("GICK INTE ATT POSTA ROCKET.")
        })
})