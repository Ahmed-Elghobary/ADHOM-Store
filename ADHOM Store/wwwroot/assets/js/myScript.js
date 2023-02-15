$.ajax({
    url: "https://localhost:7035/api/Values/GetProducts",
    type: "get",
    contentType: "application/json",
    success: function (result, status, xhr) {
        console.log(result);
        $.each(result.$values, function (index, value) {
            $("tbody").append($("<tr>"));
            appendElement = $("tbody tr").last();
            appendElement.append($("<td>").html(value["id"]));
            appendElement.append($("<td>").html(value["name"]));
            appendElement.append($("<td>").html(value["price"]));
            appendElement.append($("<td>").html(value["qty"]));
            appendElement.append($("<td>").html(value["catname"]));
            appendElement.append($("<td>").html("<a class='btn btn-danger' id=" + value["id"]+"'\">Delete</a>"));
            
        });
    },
    error: function (xhr, status, error) {
        console.log(xhr)
    }
});



$("table").on("click", "img.delete", function () {
    var reservationId = $(this).parents("tr").find("td:nth-child(1)").text();

    $.ajax({
        url: "https://localhost:44324/api/values/removeProduct/" + reservationId,
        type: "delete",
        contentType: "application/json",
        success: function (result, status, xhr) {
            ShowAllReservation();
        },
        error: function (xhr, status, error) {
            console.log(xhr)
        }
    });
});