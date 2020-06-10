async function getExpedition(id) {
    //Request one expedition
    if (id) {
        try {
            let result = await $.ajax({
                url: '/api/expeditions/' + id,
                method: 'GET'
            })
            return result
        }
        catch (error) {
            console.error(error)
        } 
    }
    //Request all expeditions
    else {
        try {
            let result = await $.ajax({
                url: '/api/expeditions/',
                method: 'GET'
            })
            return result
        }
        catch (error) {
            console.error(error)
        } 
    }    
}

async function deleteExpedition(id) {
    if (id) {
        try {
            let result = await $.ajax({
                url: '/api/expeditions/' + id,
                method: 'DELETE'
            })
            return true
        }
        catch (error) {
            console.error(error)
        }
    }
    //Request all expeditions
    else {

    } 
}

function getParam() {
    var url_string = window.location.href;
    var url = new URL(url_string);
    var c = url.searchParams.get("id");
    return c;
}

function addSorting() {
    $('.table').DataTable({ "bDestroy": true });
    $('.dataTables_length').addClass('bs-select');
}