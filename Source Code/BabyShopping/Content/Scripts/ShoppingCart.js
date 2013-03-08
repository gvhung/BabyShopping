var LoadProductCart = function (jsonData) {
    $("#productCartList").val('');
    var cartIteimList = new Array();
    var SubTotal = 0;
    var netPayAmount = 0;
    cartIteimList.push("<li><div style='background-color:#ffffff;'>");
    cartIteimList.push("<table style='width: 100%;'><tr><td></td><td>Item</td><td></td><td>Qty</td><td>Price</td></tr>");
    for (i = 0; i < jsonData.length; i++) {

        cartIteimList.push("<tr style='background-color:#F3F2F0'><td style='vertical-align:middle'>");
        cartIteimList.push("<a href='#' title='Remove Item' onclick='fnDelete(" + jsonData[i].Id + ");'><img  src='");
        cartIteimList.push(jsnUtil.host + "Content/Images/removeImg.jpg");
        cartIteimList.push("'/></a></td><td style='width: 10%;vertical-align:middle'>");
        cartIteimList.push("<img src='");
        cartIteimList.push(jsnUtil.host + "Content/Images/" + jsonData[i].ImageURL);
        cartIteimList.push("' class='double-border' width='80px' height='60px' /></td>");
        cartIteimList.push("<td><strong class='white-label'>");
        cartIteimList.push(jsonData[i].CategoryName);
        cartIteimList.push("</strong></td><td><strong class='white-label'>");
        cartIteimList.push(jsonData[i].Quantity);
        cartIteimList.push("</strong></td><td>$<strong class='white-label'>");
        cartIteimList.push(jsonData[i].Price);
        cartIteimList.push("</strong></td></tr>");
        SubTotal = SubTotal + parseInt(jsonData[i].Quantity) * parseInt(jsonData[i].Price);

    }
    netPayAmount = SubTotal + 10;
    cartIteimList.push("<tr><td></td><td></td><td></td><td></td><td></td></tr>")
    cartIteimList.push("<tr style='background-color:#CFD0CB'><td></td><td></td><td></td><td>SubTotal</td><td>$" + SubTotal + "</td></tr>")
    cartIteimList.push("<tr><td></td><td></td><td></td><td>Shipping</td><td>$10</td></tr>");
    cartIteimList.push("<tr  style='background-color:#646464;height:50px;color:#ffffff'><td></td><td></td><td></td><td>Total</td><td>$" + netPayAmount + "</td></tr></table></div></li>")
    $("#productCartList").html(cartIteimList.join(""));
}

var fnDelete = function (productCartId) {
    var jsnData = { "productCartId": productCartId };
    fnSvcGet('Shop/DeleteShoppingCart', jsnData);
}