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
            if (value["cat"]) {
                appendElement.append($("<td>").html(value["cat"]["catId"]));
            }
        appendElement.append($("<td>").html(""));
            
        });
    },
    error: function (xhr, status, error) {
        console.log(xhr)
    }
});