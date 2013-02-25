var PName = null;
var PImage = null;
var PPrice = null;
var ProductKId = null;
$(document).ready(function () {
    PName = productName;
    PImage = ProductImage;
    PPrice = ProductPrice;
    ProductKId = ProductId;
    fnDisplayCartItem();
    $('#imageZoom').attr('href', jsnUtil.imageZoomDir + PImage);
    $('#imagePropduct').attr('src', jsnUtil.imageDir + PImage);
    document.getElementById('lblPrice').innerHTML = "$" + PPrice;
    $('.jqzoom').jqzoom({
        zoomType: 'standard',
        lens: true,
        preloadImages: false,
        alwaysOn: false
    });
});
var fnSubmbit = function () {
    $('#ProductCartProductKId').val(ProductKId);
    $('#ProductCartPrice').val(PPrice);
}
