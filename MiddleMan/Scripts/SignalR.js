var hub = $.connection.middleManHub;

hub.client.broadcastMessage = function (message) {
    $("#textfieldres").val(message);
}

$.connection.hub.start()
 .done(function () {
     $("#textfield").on('change keyup paste mouseup',function () {
         var texty = $("#textfield").val();

         hub.server.announce(texty);
     });
 })
.fail(function () { alert("Failed Connection.") });

