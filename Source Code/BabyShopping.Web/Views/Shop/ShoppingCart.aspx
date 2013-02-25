<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Inner.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    ShoppingCart
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContent" runat="server">
    <% var siteroot = Url.Content("~/"); %>
    <script type="text/javascript">
        var data = '<%= ViewData["Data"] %>';
    </script>
    <script src="<%: siteroot %>Scripts/ShoppingCart.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="roundedTop">
        <img src="<%=Url.Content("~/Content/Images/roundtopLft.png")%>" alt="" class="fl" />
        <img src="<%=Url.Content("~/Content/Images/roundtopRght.png")%>" alt="" class="fr" />
    </div>
    <div class="roundedBg">
        <div class="divTable" style="width: 95%">
            <div class="divHeaderRow" style="width: 100%; border-bottom: 2px solid black;">
                <span style="font-size: 25px; color: #000000; font-weight: bold;">Shopping Cart</span>
            </div>
            <div class="divRow">
                <div class="lstView">
                    <ul id="productCartList">
                    </ul>
                </div>
            </div>
            <div class="divRow">
                <div class="cntShopng fl">
                    <a href="#" title="Continue Shopping" onclick="javascript:fnContinueShopping();">Continue
                        Shopping</a></div>
                <div class="fr">
                    <a href="#" title="Check out" onclick="javascript:CheckOut();">
                        <img src="<%=Url.Content("~/Content/Botton/checkout.png")%>" alt="Check Out" /></a></div>
                <div class="cl">
                </div>
            </div>
        </div>
    </div>
    <div class="roundedBot">
        <img src="<%=Url.Content("~/Content/Images/roundBotLft.png")%>" alt="" class="fl" />
        <img src="<%=Url.Content("~/Content/Images/roundBotRght.png")%>" alt="" class="fr" />
    </div>
</asp:Content>
