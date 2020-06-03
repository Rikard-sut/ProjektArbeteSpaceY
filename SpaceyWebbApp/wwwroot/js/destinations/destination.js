//Post to backend
const form = document.querySelector('form')
form.addEventListener('submit', (event) => {
    event.preventDefault()
    var jqxhr = $.post('/api/destinations', $('#form').serialize())
        .done(() => {
            //redirect to rockets list
        })
        .fail(() => {

        })
})
//HEJ ÄR DEHÄR MSATER NU??? 