


var fnrRegister = function () {
    var mobileNumber = null;
    var faxNumber = null;
    var telephone = null;
    var errorList = new Array();
    var error;
    var input;
    if ($("#MLoginEmailId").val() == "") {
        error = { "PropertyName": "MLoginEmailId", "ErrorDescription": "Field cannot be left blank. " };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    if ($("#MLoginRightsUserID").val() == "") {
        error = { "PropertyName": "MLoginRightsUserID", "ErrorDescription": "Field cannot be left blank. " };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    if ($("#MLoginFirstName").val() == "") {
        error = { "PropertyName": "MLoginFirstName", "ErrorDescription": "Field cannot be left blank. " };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    if ($("#MLoginLastName").val() == "") {
        error = { "PropertyName": "MLoginLastName", "ErrorDescription": "Field cannot be left blank." };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    if ($("#txtCompanyName").val() == "") {
        error = { "PropertyName": "txtCompanyName", "ErrorDescription": "Field cannot be left blank." };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    if ($("#txtJobTitle").val() == "") {
        error = { "PropertyName": "txtJobTitle", "ErrorDescription": "Field be cannot left blank." };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    if ($("#txtAddress").val() == "") {
        error = { "PropertyName": "txtAddress", "ErrorDescription": "Field cannot be left blank." };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    if ($("#txtCity").val() == "") {
        error = { "PropertyName": "txtCity", "ErrorDescription": "Field cannot be left blank." };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    if ($("#txtState").val() == "") {
        error = { "PropertyName": "txtState", "ErrorDescription": "Field cannot be left blank." };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    if ($('#ddlCountry').val()=="--Select--") {
        error = { "PropertyName": "ddlCountry", "ErrorDescription": "Field cannot be left blank." };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    if ($("#txtZip").val() == "") {
        error = { "PropertyName": "txtZip", "ErrorDescription": "Field cannot be left blank." };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    if ($("#MLoginRightsPassword").val() == "") {
        error = { "PropertyName": "MLoginRightsPassword", "ErrorDescription": "Field cannot be left blank." };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    if ($("#CMLoginRightsPassword").val() == "") {
        error = { "PropertyName": "CMLoginRightsPassword", "ErrorDescription": "Field cannot be left blank." };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    if ($("#txtPrimaryPhone").val() == "" || $("#txtPrimaryPhone2").val() == "" || $("#txtPrimaryPhone3").val() == "" || $("#txtPrimaryPhone4").val() == "") {
        error = { "PropertyName": "txtPrimaryPhone", "ErrorDescription": "Field cannot be left blank." };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    else {
        telephone = $("#txtPrimaryPhone").val() + $("#txtPrimaryPhone2").val() + $("#txtPrimaryPhone3").val() + $("#txtPrimaryPhone4").val();
    }
    if ($("#txtMobileNumber").val() == "" || $("#txtMobileNumber2").val() == "") {
        error = { "PropertyName": "txtMobileNumber", "ErrorDescription": "Field cannot be left blank." };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    else {
        mobileNumber = $("#txtMobileNumber").val() + $("#txtMobileNumber2").val();
    }
    if ($("#txtFaxNumber").val() == "" || $("#txtFaxNumber2").val() == "" || $("#txtFaxNumber3").val() == "") {
        error = { "PropertyName": "txtFaxNumber2", "ErrorDescription": "Field cannot be left blank." };
        errorList.push(error);
        $('#Errors').val(JSON.stringify(errorList));
    }
    else {
        faxNumber = $("#txtFaxNumber").val() + $("#txtFaxNumber2").val() + $("#txtFaxNumber3").val();
    }
    if (errorList.length <= 0) {
        var jsnData = new Object();
        jsnData = { "userStatus": { "MLoginPrimaryPhone": telephone, "MLoginMobilePhone": mobileNumber, "MLoginFax": faxNumber, "MLoginFirstName": $('#MLoginFirstName').val().toString(), "MLoginLastName": $('#MLoginLastName').val().toString(), "MLoginCompanyName": $('#txtCompanyName').val().toString(), "MLoginJobTitle": $('#txtJobTitle').val().toString(), "MLoginAddress": $('#txtAddress').val().toString(), "MLoginState": $('#txtState').val().toString(), "MLoginZip": $('#txtZip').val().toString()} };
        fnSvcGet("Ajax/CreateUser", $.postify(jsnData), fnResult);
    }
    else {
        fnShowErrors();
    }
}

var fnResult = function (jsonResult) {
    alert(jsonResult);
    if (jsonResult) {
    }
    else {
    }
}
   
var fnBack = function () {
    window.location.href = jsnUtil.host + "Home/Login";
}