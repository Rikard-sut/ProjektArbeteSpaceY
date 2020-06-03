const destinationSelect = document.querySelector('#destinationSelect')
const rocketSelect = document.querySelector('#rocketSelect')

fetchDestinations()
fetchRockets()

function fetchDestinations() {
    $.get("https://localhost:44314/api/destinations", function (data) {
        console.log(data)
        for (const item of data) {
            const option = document.createElement('option')
            option.value = item.destinationId
            option.innerText = item.name

            destinationSelect.append(option)
        }
    });
}

function fetchRockets() {
    $.get("https://localhost:44314/api/rockets", function (data) {
        console.log(data)
        for (const item of data) {
            const option = document.createElement('option')
            option.value = item.rocketId
            option.innerText = item.name

            rocketSelect.append(option)
        }
    });
}
//Den behöver bara detta. resten är för att logga errrors osv, får inte det att funka.
$("#form").submit(function () {
    var jqxhr = $.post('/api/expeditions', $('#form').serialize()) /*.success(function () {
        console.log("Sucess")
        console.log(jqxhr);
         })
        .error(function () {
            console.log("Error posting the update.")
            $('#message').html("Error posting the update.");
        });
        return false; */
});







/*
const form = document.querySelector('form')
form.addEventListener('submit', (event) => {
    var fd = new FormData(document.querySelector("form"));
    $.ajax({
        url: "api/expeditions",
        type: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        data: JSON.stringify(fd),
        processData: false,  // tell jQuery not to process the data
        contentType: false   // tell jQuery not to set contentType
    });
})*/





/*
const form = document.querySelector('form')
form.addEventListener('submit', (event) => {
    event.preventDefault();
    var result = {};
    $.each($('form').serializeArray(), function () {
        result[this.name] = this.value;
    });

    var settings = {
        "url": "https://localhost:44314/api/expeditions",
        "method": "POST",
        "timeout": 0,
        "headers": {
            "Content-Type": "application/json"
        },
        "data": JSON.stringify(result)
    }

    $.ajax(settings).done(function (response) {
        console.log(response);
    });
})*/
