$(document).ajaxComplete(function () {
    $('.table').DataTable({ "bDestroy": true });
    $('.dataTables_length').addClass('bs-select');
});