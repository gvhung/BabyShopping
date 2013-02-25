$.postify = function (value) {
    var result = {};
    var buildResult = function (object, prefix) {
        for (var key in object) {

            var postKey = isFinite(key)
                ? (prefix != "" ? prefix : "") + "[" + key + "]"
                : (prefix != "" ? prefix + "." : "") + key;

            switch (typeof (object[key])) {
                case "number": case "string": case "boolean":
                    result[postKey] = object[key];
                    break;

                case "object":
                    if (object[key].toUTCString)
                        result[postKey] = object[key].toUTCString().replace("UTC", "GMT");
                    else {
                        buildResult(object[key], postKey != "" ? postKey : key);
                    }
            }
        }
    };

    buildResult(value, "");
    return result;
};
var fnGetQueryString = (function (qs) {
    if (qs == "") return {};
    var qsVal = {};
    for (var i = 0; i < qs.length; ++i) {
        var p = qs[i].split('=');
        if (p.length != 2) continue;
        qsVal[p[0]] = decodeURIComponent(p[1].replace(/\+/g, " "));
    }
    return qsVal;
})(window.location.search.substr(1).split('&'));

//var jsnUtil = {
//    "host": window.location.protocol + "//" + window.location.host + "/BabyShopping/",
//    "imageZoomDir": window.location.protocol + "//" + window.location.host + "/BabyShopping" + "/Content/Zoom/",
//    "imageDir": window.location.protocol + "//" + window.location.host + "/BabyShopping/Content/Images/"
//};

var jsnUtil = {
    "host": window.location.protocol + "//" + window.location.host + "/",
    "imageZoomDir": window.location.protocol + "//" + window.location.host + "/Content/Zoom/",
    "imageDir": window.location.protocol + "//" + window.location.host + "/Content/Images/"

};


/* Start : Ajax Region*/

var jsnAjaxConfig = {
    debugSvcError: true,
    alertError: true,
    debugSvcSuccessData: false,
    alertSvcData: false,
    debugCallComplete: false
};

var fnSvcCallFail = function (XMLHttpRequest, textStatus, errorThrown) {

    if (jsnAjaxConfig.debugSvcError) {
        debugger;
    }
    if (jsnAjaxConfig.alertError) {
        alert("XMLHttpRequest:" + JSON.stringify(XMLHttpRequest));
        alert("textStatus:" + JSON.stringify(textStatus));
        alert("errorThrown:" + JSON.stringify(errorThrown));
    }

};

var fnSvcCallSuccess = function (data, textStatus, jqXHR) {

    if (jsnAjaxConfig.debugSvcSuccessData) {
        debugger;
    }
    if (jsnAjaxConfig.alertSvcData) {
        alert(JSON.stringify(data));
    }
};
var fnSvcCallComplete = function (event, XMLHttpRequest, ajaxOptions) {

    if (jsnAjaxConfig.debugCallComplete) {
        debugger;
    }

};

var fnSvcGet = function (strSvcMethodName, jsnPrm, fnSuccessCallBack) {
    $.ajax({
        type: "GET",
        url: jsnUtil.host + strSvcMethodName,
        data: jsnPrm,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        processdata: true,
        success: function (data, textStatus, jqXHR) {
            fnSvcCallSuccess(data, textStatus, jqXHR);
            fnSuccessCallBack(data, textStatus, jqXHR);
        },
        error: fnSvcCallFail
    });


};
var fnSvcPost = function (strSvcMethodName, jsnPrm, fnSuccessCallBack) {

    $.ajax({
        type: "POST",
        url: jsnUtil.host + strSvcMethodName,
        data: jsnPrm,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        processdata: true,
        success: function (data, textStatus, jqXHR) {
            fnSvcCallSuccess(data, textStatus, jqXHR);
            fnSuccessCallBack(data, textStatus, jqXHR);
        },
        error: fnSvcCallFail
    });
};
var fnSvcGetSynch = function (strSvcMethodName, jsnPrm, fnSuccessCallBack) {
    jQuery.ajaxSetup({ async: false });
    fnSvcGet(strSvcMethodName, jsnPrm, fnSuccessCallBack);
    jQuery.ajaxSetup({ async: true });
};
var fnSvcGetSync = function (strSvcMethodName, jsnPrm, fnSuccessCallBack) {
    $.ajax({
        type: "GET",
        async: true,
        url: jsnUtil.host + strSvcMethodName,
        data: jsnPrm,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        processdata: true,
        success: function (data, textStatus, jqXHR) {
            fnSvcCallSuccess(data, textStatus, jqXHR);
            fnSuccessCallBack(data, textStatus, jqXHR);
        },
        error: fnSvcCallFail
    });
};
var fnAddtoCart = function () {
    var quantity = null;
    var PPrice = null;
    var ProductKId = null;
    window.location.href = jsnUtil.host + "Shop/ShoppingCart?PQuantity=" + 0 + " &PPrice=" + 0 + " &ProductKId=" + 0;
}
var fnDisplayCartItem = function () {
    displayCartItem(JSON.parse(cartItem));
}
var LoadCartItems = function () {
    displayCartItem(JSON.parse(cartItem));
}
var displayCartItem = function (cartItem) {
    if (cartItem != null && cartItem > 0) {
        document.getElementById('lblCartItems').innerHTML = cartItem;
    }
    else {
        document.getElementById('lblCartItems').innerHTML = "0";
    }
}
$(document).ready(function () {
    fnShowErrors();
});
var fnShowErrors = function () {

    if ($('#Errors') && $('#Errors').val() != '') {

        var jsnErrors = JSON.parse($('#Errors').val());
        if (typeof jsnErrors == 'object') {

            if (jsnErrors && jsnErrors.length && jsnErrors.length > 0) {

                var totalError = jsnErrors.length;
                for (var count = 0; count < totalError; count++) {
                    if ($('#error_' + jsnErrors[count].PropertyName)) {
                        $('#error_' + jsnErrors[count].PropertyName).html(jsnErrors[count].ErrorDescription);

                    }
                }
            }

        }
    }
}