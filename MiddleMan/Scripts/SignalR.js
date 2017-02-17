var hub = $.connection.middleManHub;
$.connection.hub.start()
 .done(function () {
     $.connection.middleManHub.server.Announce = function (message) { alert(message); };
   

})
.fail(function () { alert("Failed Connection.") });
$("#btn").click(function () {
    hub.server.Announce("hey this is a client talking to the other ones.")
});



//$.connection.MiddleManHub.client.Announce = function (message) { alert(message) };
//console.log($.signalR);