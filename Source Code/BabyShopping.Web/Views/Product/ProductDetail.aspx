<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Inner.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    ProductDetail
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContent" runat="server">
    <% var siteroot = Url.Content("~/"); %>
    <script type="text/javascript">
        var productName = '<%= ViewData["productName"] %>';
        var ProductImage = '<%= ViewData["image"] %>';
        var ProductPrice = '<%= ViewData["price"] %>';
        var ProductId = '<%= ViewData["ProductId"] %>';
       
    </script>
    <script src="<%: siteroot %>Scripts/jquery-1.4.4.min.js" type="text/javascript"></script>
    <script src="<%: siteroot %>Scripts/ProductDetail.js" type="text/javascript"></script>
    <script src="<%: siteroot %>Scripts/jquery.jqzoom-core.js" type="text/javascript"></script>
    <link href="<%: siteroot %>Content/jquery.jqzoom.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="Form1" action="/Shop/ShoppingCart" method="post" onsubmit="javascript:fnSubmbit();">
    <div class="inner-section">
        <input id="ProductCartProductKId" name="ProductCartProductKId" type="hidden" value="" />
        <input id="ProductCartPrice" name="ProductCartPrice" type="hidden" value="" />
        <div class="shadowBox fl">
            <div class="shadowTop">
                &nbsp;</div>
            <div class="shadowCont">
                <div class="clearfix">
                    <a id="imageZoom" href="" class="jqzoom" rel='gal1' title="">
                        <img id="imagePropduct" src="" title="" alt="" />
                    </a>
                </div>
                <div class="cl">
                </div>
                <div class="rollthumb clearfix">
                    <p class="rollTxt">
                        Roll over image to zoom in
                    </p>
                    <ul id="thumblist" class="clearfix">
                        <%-- <li><a class="zoomThumbActive" href='javascript:void(0);' rel="{gallery: 'gal1', smallimage: '<%=Url.Content("~/Content/Images/thumb_small1.jpg")%>',largeimage: '<%=Url.Content("~/Content/Zoom/BlanketOne.jpg")%>'}">
                            <img src='<%=Url.Content("~/Content/Images/rollimgThumb.jpg")%>'></a></li>--%>
                        <li><a href='javascript:void(0);' rel="{gallery: 'gal1', smallimage: '<%=Url.Content("~/Content/Images/thumb_small2.jpg")%>',largeimage: '<%=Url.Content("~/Content/Zoom/thumb_big2.jpg")%>'}">
                            <img src='<%=Url.Content("~/Content/Images/rollimgThumb2.jpg")%>'></a></li>
                        <li><a href='javascript:void(0);' rel="{gallery: 'gal1', smallimage: '<%=Url.Content("~/Content/Images/thumb_small3.jpg")%>',largeimage: '<%=Url.Content("~/Content/Zoom/thumb_big3.jpg")%>'}">
                            <img src='<%=Url.Content("~/Content/Images/rollimgThumb5.jpg")%>'></a></li>
                        <%--<li><a class="zoomThumbActive" href='javascript:void(0);' rel="{gallery: 'gal1', smallimage: '<%=Url.Content("~/Content/Images/detailThumb.jpg")%>',largeimage: '<%=Url.Content("~/Content/Images/BlanketOne.jpg")%>'}">
                            <img src='<%=Url.Content("~/Content/Images/rollimgThumb.jpg")%>'></a></li>--%>
                        <li><a href='javascript:void(0);' rel="{gallery: 'gal1', smallimage: '<%=Url.Content("~/Content/Images/thumb_small2.jpg")%>',largeimage: '<%=Url.Content("~/Content/Zoom/thumb_big2.jpg")%>'}">
                            <img src='<%=Url.Content("~/Content/Images/rollimgThumb2.jpg")%>'></a></li>
                        <li><a href='javascript:void(0);' rel="{gallery: 'gal1', smallimage: '<%=Url.Content("~/Content/Images/thumb_small3.jpg")%>',largeimage: '<%=Url.Content("~/Content/Zoom/thumb_big3.jpg")%>'}">
                            <img src='<%=Url.Content("~/Content/Images/rollimgThumb5.jpg")%>'></a></li>
                        <%--<li><a class="zoomThumbActive" href='javascript:void(0);' rel="{gallery: 'gal1', smallimage: '<%=Url.Content("~/Content/Images/detailThumb.jpg")%>',largeimage: '<%=Url.Content("~/Content/Zoom/BlanketOne.jpg")%>'}">
                            <img src='<%=Url.Content("~/Content/Images/rollimgThumb.jpg")%>'></a></li>--%>
                    </ul>
                    <div class="cl">
                    </div>
                </div>
            </div>
            <div class="shadowBot">
                &nbsp;</div>
        </div>
        <div class="shadowBox fr">
            <div class="shadowTop">
                &nbsp;</div>
            <div class="shadowCont">
                <div class="detailCont">
                    <h3>
                        Striped Cotton Blanket</h3>
                    <div class="cartRow">
                        <div class="price fl">
                            <b>Details</b></div>
                        <div class="price blueColr fl">
                            <b>Fabric &amp; Care</b></div>
                        <div class="price blueColr fl">
                            <b>Shipping</b></div>
                        <div class="cl">
                        </div>
                    </div>
                    <p>
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                        Ipsum has been the industry's standard dummy text ever since the 1500s, when an
                        unknown printer took a galley of type and scrambled it to make a type specimen book.
                    </p>
                </div>
                <div class="detailCont">
                    <div class="cartRow">
                        <b>Ordering</b>
                    </div>
                    </br>
                    <form action="" method="get" class="formCont">
                    <div class="formRow">
                        <label>
                            Size</label>&nbsp;&nbsp;
                        <select name="">
                            <option>Choose an Option</option>
                        </select>
                        <div class="cl">
                        </div>
                    </div><br />
                    <div class="formRow">
                        <label>
                            Color</label>
                        <select name="">
                            <option selected="selected">Choose an Option</option>
                        </select>
                        <div class="cl">
                        </div>
                    </div><br />
                    <div class="formRow">
                        <label>
                            Price</label>
                        <label id="lblPrice">
                        </label>
                        <div class="cl">
                        </div>
                    </div>
                    <div class="formRow">
                        <label>
                            Quantity</label>
                        <input name="ProductCartQuantity" id="productQuantity" type="text" value="1" style="width: 50px;" />
                        <button type="submit"  name="EditUtility" id="EditUtility" style="position: relative;width: 43%; left:20%;border:0px thin #ffffff;">
                            <img src='<%=Url.Content("~/Content/Images/cartBtn.jpg")%>' style="position: relative; left:-5%" alt="" /> 
                        </button>
                        <div class="cl">
                        </div>
                    </div>
                    </form>
                </div>
            </div>
            <div class="shadowBot">
                &nbsp;</div>
        </div>
        <div class="cl">
        </div>
    </div>
    </form>
</asp:Content>
