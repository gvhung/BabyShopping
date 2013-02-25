
$(document).ready(function () {
    var countItems = JSON.parse(data);
    fnDisplayShippingDetail(JSON.parse(data1));
    document.getElementById('lblAddCartItems').innerHTML = countItems;
});

var fnDisplayShippingDetail = function (jsondata) {

    if (jsondata != null) {
        document.getElementById('lblName').innerHTML = jsondata.MLoginFirstName +" "+ jsondata.MLoginLastName;
        document.getElementById('lblAddressCity').innerHTML = jsondata.MLoginAddress;
        document.getElementById('lblStateCountry').innerHTML = jsondata.MLoginState + "," + jsondata.MLoginCountry;
        document.getElementById('lblPinCode').innerHTML = jsondata.MLoginZip;
    }
}

var ShowTermCondition = function () {
    window.location.href = jsnUtil.host + "Shop/TermCondition";
}

var ChangeAddress = function () {
    window.location.href = jsnUtil.host + "Shop/ChangeAddress";
}
