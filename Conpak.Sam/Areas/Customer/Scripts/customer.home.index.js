$(function () {
    $("#hi").click(function () {
        $.get("/Customer/Home/List", function (data) {

            $("#customerList").html(data);
        });
    });

    $("#getJson").click(function () {
        //var url = "/api/webapi";
        var url = "/Customer/Home/List?format=json";
        $.get(url, function (data) {
            for (var i = 0; i < data.length; i++) {
                var customer = data[i];
                $("#customerList").append("<li>" + customer.Name + "(" + customer.Id + ")</li>");
            }
        });
    });
})