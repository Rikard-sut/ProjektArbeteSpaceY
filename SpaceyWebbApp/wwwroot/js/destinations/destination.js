async function getDestinations() {
    try {
        let result = await $.ajax({
            url: '/api/destinations/',
            method: 'GET'
        })
        return result
    }
    catch (error) {
        console.error(error)
        return false
    }
}

async function deleteDestination(id) {
    try {
        let result = await $.ajax({
            url: '/api/destinations/' + id,
            method: 'DELETE'
        })
        return true
    }
    catch (error) {
        console.error(error)
        return false
    }
}

//NOT USED YET
async function addDestination(destination) {
    try {
        let result = await $.ajax({
            url: '/api/destinations/',
            method: 'POST',
            data: destination
        })
        return true
    }
    catch (error) {
        console.error(error)
        return false
    }
}

function addSorting() {
    $('.table').DataTable({ "bDestroy": true });
    $('.dataTables_length').addClass('bs-select');
}