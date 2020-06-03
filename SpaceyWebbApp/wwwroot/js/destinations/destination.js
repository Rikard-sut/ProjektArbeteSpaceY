//Den behöver bara detta. resten är för att logga errrors osv, får inte det att funka.
$("#form").submit(function () {
    var jqxhr = $.post('/api/destinations', $('#form').serialize()) /*.success(function () {
        console.log("Sucess")
        console.log(jqxhr);
         })
        .error(function () {
            console.log("Error posting the update.")
            $('#message').html("Error posting the update.");
        });
        return false; */
});
