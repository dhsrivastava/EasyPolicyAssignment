var custDisc = {
    CalculateNetPayment: function () {
        var totalBill = $("#txtTotalBill").val();
        var customerType = $("#ddlCustomerType").val();
        var isGrocery = $("#chkGroceries").is(':checked');
        var customerAssociation = $("#txtCustomerAssociation").val();
        var objData = {
            "totalBill": totalBill,
            "customerType": customerType,
            "customerAssociation": customerAssociation,
            "isGrocery": isGrocery
        };
        $.ajax({
            type: "GET",
            url: "/Customer/GetNetPayment",
            data: objData,
            cache: false,
            success: function (data) {
                alert("net payable amount for the customer is " + data);
            }
        });
    }
}