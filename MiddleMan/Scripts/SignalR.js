var hub = $.connection.middleManHub;

hub.client.broadcastMessage = function (message) {
    $("#namnam").val(message);
};

//$.connection.hub.start()
// .done(function () {

// })
//.fail(function () { alert("Failed Connection.") });

//$(document.onScroll(), function () {
//    var texty = $("#namnam").val();
//    hub.server.announce($("#namnam").val());
//}));