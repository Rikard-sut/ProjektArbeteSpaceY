$(function () {
    var jqxhr = $.get('/api/expeditions')
        .done(() => {
            populateTable(jqxhr.responseJSON)
        })
        .fail(() => {

        })
})

function populateTable(expeditions) {
    for (const expedition of expeditions) {
        const bookedseats = 0;
        if (expedition.customers) {
            bookedseats = expedition.customers.length;
        }
        
        
        console.log(bookedseats);
        var markup = "<tr><td>" + expedition.departure + "</td><td>" + expedition.destination.name + "</td><td>" + expedition.rocket.name + "</td><td>" + bookedseats + "/" + expedition.rocket.seats + "</td> </tr> ";
        $('.table').append(markup)
    }
}