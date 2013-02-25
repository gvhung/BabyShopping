<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Inner.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    BabyProduct
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContent" runat="server">
    <% var siteroot = Url.Content("~/"); %>
    <script src="<%: siteroot %>Scripts/jquery-1.4.4.min.js" type="text/javascript"></script>
    <script src="<%: siteroot %>Scripts/Product.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="inner-section">
        <div class="shadowBoxSmal fl">
            <div class="shadowTopSmal">
                &nbsp;</div>
            <form id="Form1" action="/Product/ProductDetail" method="post">
            <div class="shadowContSmal">
                <input id="productImage" name="ProductImageURL" type="hidden" value="BlanketOne.jpg" />
                <img src="<%=Url.Content("~/Content/Images/BlanketOne.jpg")%>" width="100%" alt="" />
                <h4 class="blueColr">
                    <input id="productNameOne" name="ProductCategoryName" type="hidden" value="STRIPED COTTON BLANKET" />
                    <input id="Hidden1" name="ProductKId" type="hidden" value="1" />  
                    <label id="lblStrippedOne">
                        STRIPED COTTON BLANKET</label></h4>
                Comfort comes with stripes
                <p>
                    <input id="productPrice" name="ProductPrice" type="hidden" value="82.00" />
                    <label id="lblPriceOne">
                        $82.00</label></p>
                <p>
                    <input type="submit" value="Details" onclick="javascript:fnProductDetailOne();" />
                </p>
            </div>
            </form>
            <div class="shadowBotSmal">
                &nbsp;</div>
        </div>
        <div class="shadowBoxSmal fl">
            <div class="shadowTopSmal">
                &nbsp;</div>
                 <form id="Form2" action="/Product/ProductDetail" method="post">
            <div class="shadowContSmal">
                <input id="productImageTwo" name="ProductImageURL" type="hidden" value="babyswaddle.jpg" />
                <input id="productNameTwo" name="ProductCategoryName" type="hidden" value="BABY SWADDLE BEYBERRY" />
                <input id="productPriceTwo" name="ProductPrice" type="hidden" value="48.00" />
                 <input id="Hidden2" name="ProductKId" type="hidden" value="2" />
                <img src="<%=Url.Content("~/Content/Images/babyswaddle.jpg")%>" width="85%" alt="" />
                <h4 class="blueColr">
                    BABY SWADDLE BEYBERRY</h4>
                Comfort comes with stripes
                <p>
                    $48.00</p>
                <p> <input type="submit" value="Details" onclick="javascript:fnProductDetailTwo();" /></p>
            </div>
            </form>
            <div class="shadowBotSmal">
                &nbsp;</div>
        </div>
        <div class="shadowBoxSmal fl">
            <div class="shadowTopSmal">
                &nbsp;</div>
                 <form id="Form3" action="/Product/ProductDetail" method="post">
            <div class="shadowContSmal">
                <input id="productImageThree" name="ProductImageURL" type="hidden" value="BlanketOne.jpg" />
                <input id="productNameThree" name="ProductCategoryName" type="hidden" value="STRIPED COTTON BLANKET" />
                <input id="productPriceThree" name="ProductPrice" type="hidden" value="82.00" />
                 <input id="Hidden3" name="ProductKId" type="hidden" value="5" />
                <img src="<%=Url.Content("~/Content/Images/BlanketOne.jpg")%>" width="100%" alt="" />
                <h4 class="blueColr">
                    STRIPED COTTON BLANKET</h4>
                Comfort comes with stripes
                <p>
                    $82.00</p>
                <p>
                   <input type="submit" value="Details" onclick="javascript:fnProductDetailThree();" /></p>
            </div>
            </form>
            <div class="shadowBotSmal">
                &nbsp;</div>
        </div>
        <div class="shadowBoxSmal fl">
            <div class="shadowTopSmal">
                &nbsp;</div>
                 <form id="Form4" action="/Product/ProductDetail" method="post">
            <div class="shadowContSmal">
                <input id="productImageFour" name="ProductImageURL" type="hidden" value="BlanketOne.jpg" />
                <input id="productNameFour" name="ProductCategoryName" type="hidden" value="STRIPED COTTON BLANKET" />
                <input id="productPriceFour" name="ProductPrice" type="hidden" value="82.00" />
                 <input id="Hidden4" name="ProductKId" type="hidden" value="7" />
                <img src="<%=Url.Content("~/Content/Images/BlanketOne.jpg")%>" width="100%" alt="" />
                <h4 class="blueColr">
                    STRIPED COTTON BLANKET</h4>
                Comfort comes with stripes
                <p>
                    $82.00</p>
                <p>
                  <input type="submit" value="Details" onclick="javascript:fnProductDetailFour();" /></p>
            </div>
            </form>
            <div class="shadowBotSmal">
                &nbsp;</div>
        </div>
        <div class="shadowBoxSmal fl">
            <div class="shadowTopSmal">
                &nbsp;</div>
                 <form id="Form5" action="/Product/ProductDetail" method="post">
            <div class="shadowContSmal">
                <input id="productImageFive" name="ProductImageURL" type="hidden" value="babyswaddle.jpg" />
                <input id="productNameFive" name="ProductCategoryName" type="hidden" value="BABY SWADDLE BEYBERRY" />
                <input id="productPriceFive" name="ProductPrice" type="hidden" value="48.00" />
                 <input id="Hidden5" name="ProductKId" type="hidden" value="10" />
                <img src="<%=Url.Content("~/Content/Images/babyswaddle.jpg")%>" width="85%" alt="" />
                <h4 class="blueColr">
                    BABY SWADDLE BEYBERRY</h4>
                Comfort comes with stripes
                <p>
                    $48.00</p>
                <p>
                  <input type="submit" value="Details" onclick="javascript:fnProductDetailFive();" /></p>
            </div>
            </form>
            <div class="shadowBotSmal">
                &nbsp;</div>
        </div>
        <div class="shadowBoxSmal fl">
            <div class="shadowTopSmal">
                &nbsp;</div>
                 <form id="Form6" action="/Product/ProductDetail" method="post">
            <div class="shadowContSmal">
                <input id="productImageSix" name="ProductImageURL" type="hidden" value="BlanketOne.jpg" />
                <input id="productNameSix" name="ProductCategoryName" type="hidden" value="STRIPED COTTON BLANKET" />
                <input id="productPriceSix" name="ProductPrice" type="hidden" value="82.00" />
                 <input id="Hidden6" name="ProductKId" type="hidden" value="1" />
                <img src="<%=Url.Content("~/Content/Images/BlanketOne.jpg")%>" width="100%" alt="" />
                <h4 class="blueColr">
                    STRIPED COTTON BLANKET</h4>
                Comfort comes with stripes
                <p>
                    $82.00</p>
                <p>
                   <input type="submit" value="Details" onclick="javascript:fnProdufnProductDetailSixctDetailThree();" /></p>
            </div>
            </form>
            <div class="shadowBotSmal">
                &nbsp;</div>
        </div>
        <div class="cl">
        </div>
    </div>
</asp:Content>
