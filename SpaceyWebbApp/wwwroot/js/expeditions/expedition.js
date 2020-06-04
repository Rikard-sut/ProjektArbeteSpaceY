function getParam() {
    var url_string = window.location.href;
    var url = new URL(url_string);
    var c = url.searchParams.get("id");
    return c;
}

$(function () {
    var jqxhr = $.get('/api/expeditions/' + getParam())
        .done(() => {
            populateCustomerTable(jqxhr.responseJSON.customers)
        })
        .fail(() => {

        })
})

function populateCustomerTable(customers) {
    for (const customer of customers) {
        var markup = "<tr><td>" + customer.fullName + "<td></tr> ";
        $('.table').append(markup)
    }
}