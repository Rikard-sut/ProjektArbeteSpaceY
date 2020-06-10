async function getRockets() {
    try {
        let result = await $.ajax({
            url: '/api/rockets/',
            method: 'GET'
        })
        return result
    }
    catch (error) {
        console.error(error)
        return false
    } 
}

async function deleteRocket(id) {
    try {
        let result = await $.ajax({
            url: '/api/rockets/' + id,
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
async function addRocket(rocket) {
    try {
        let result = await $.ajax({
            url: '/api/rockets/',
            method: 'POST',
            data: rocket
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