var jsnUtil = {
    "host": window.location.protocol + "//" + window.location.host + "/",
    "imageZoomDir": window.location.protocol + "//" + window.location.host + "/Content/Zoom/",
    "imageDir": window.location.protocol + "//" + window.location.host + "/Content/Images/"
};

var LoadCartItems = function () {
    displayCartItem();
};

var displayCartItem = function () {
    document.getElementById('lblCartItems').innerHTML = sessionStorage.cartItemCount;
};

var fnAddtoCart = function () {
    if (sessionStorage.cartItemCount > 0) {
        window.location.href = jsnUtil.host + "Shop/ShoppingCart?PQuantity=" + 0 + " &PPrice=" + 0 + " &ProductKId=" + 0;
    }
};

var fnSvcGet = function (strSvcMethodName, jsnPrm) {
    $.ajax({
        type: "GET",
        url: jsnUtil.host + strSvcMethodName,
        data: jsnPrm,
        traditional: true,
        dataType: "json",
        processdata: true,
        success: function (data, textStatus, jqXHR) {
            fnSvcCallSuccess(data, textStatus, jqXHR);
        },
        error: fnSvcCallFail
    });
};

var fnSvcCallFail = function (XMLHttpRequest, textStatus, errorThrown) {
    alert("XMLHttpRequest:" + JSON.stringify(XMLHttpRequest));
    alert("textStatus:" + JSON.stringify(textStatus));
    alert("errorThrown:" + JSON.stringify(errorThrown));
};

var fnSvcCallSuccess = function (data, textStatus, jqXHR) {
};

var setQuantity = function (quantity) {
    sessionStorage.quantity = quantity.value;
}

var editQuantityHandler = function (productId) {
    $("#txtQuantity" + productId).attr('class', 'show');
    $("#divQuantity" + productId).attr('class', 'hide');
    $("#editButton" + productId).attr('class', 'hide');
    $("#updateCancelButton" + productId).attr('class', 'show');
};

var cancelQuantityHandler = function (productId) {
    $("#txtQuantity" + productId).attr('class', 'hide');
    $("#divQuantity" + productId).attr('class', 'show');
    $("#editButton" + productId).attr('class', 'show');
    $("#updateCancelButton" + productId).attr('class', 'hide');
};

var updateQuantityHandler = function (productId) {
    $.ajax({
        type: "POST",
        url: "../Shop/UpdateQuantityInCart",
        data: {
            'productCartId': productId,
            'quantity': sessionStorage.quantity
        },
        success: function (response) {
            cancelQuantityHandler(productId);
            populateGridHandler();
            $('#shoppingCartForm').submit();
        },
        error: function (response) {

            cancelQuantityHandler(productId);

            $('#shoppingCartForm').submit();
            //populateGridHandler();
        },
        dataType: "json",
        traditional: true
    });
};

var populateGridHandler = function () {
    $.ajax({
        type: "POST",
        url: "../Shop/PopulateGrid",
        success: function (response) {
        },
        error: function (response) {
        },
        dataType: "json",
        traditional: true
    });
};