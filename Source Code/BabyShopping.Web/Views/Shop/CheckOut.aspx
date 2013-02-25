<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Payment.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    CheckOut
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="BoxTable" cellpadding="0" cellspacing="0" border="0" width="100%">
        <tr>
            <td class="BoxHeader">
                Checkout
            </td>
        </tr>
        <tr>
            <td class="FormDetailCell">
                <table class="TableFormInside" cellpadding="0" cellspacing="0" border="0">
                    <tr>
                        <td class="FormDetailBoxHeader" colspan="2">
                        <br />
                            Shipping Address
                        </td>
                    </tr>
                    <tr>
                        <td class="CelLeft" colspan="2">
                            <label id="lblName">
                            </label>
                        </td>
                    </tr>
                    <tr>
                        <td class="CelLeft" colspan="2">
                            <label id="lblAddressCity">
                            </label>
                        </td>
                    </tr>
                    <tr>
                        <td class="CelLeft" colspan="2">
                            <label id="lblStateCountry">
                            </label>
                        </td>
                    </tr>
                    <tr>
                        <td class="CelLeft" colspan="2">
                            <label id="lblPinCode">
                            </label>
                        </td>
                    </tr>
                    <tr>
                        <td height="10" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="CelLeft" colspan="2">
                            <a href="#" class="link-button-regular"  title="Change Address::BabyShop"
                                onclick="javascript:ChangeAddress();">Change Address</a>
                        </td>
                    </tr>
                    <tr style="width: 100%;">
                        <td class="AbowLine" colspan="2">
                        </td>
                    </tr>
                    <tr style="width: 100%;">
                        <td class="CellLine" style="width: 100%;" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="BelowLine" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="FormDetailBoxHeader" colspan="2">
                            Shopping Information
                        </td>
                    </tr>
                    <tr>
                        <td class="CelLeft" style="width:30%;">
                            Quantity of item(s):
                        </td>
                        <td class="CellRight">
                         <label id="lblAddCartItems"></label>
                        </td>
                    </tr>
                    <tr>
                        <td class="CelLeft">
                            Total Amount:
                        </td>
                        <td class="FormCellRight">
                            <strong>
                                <label id="lblAmount">
                                </label>
                            </strong>
                        </td>
                    </tr>
                    <tr>
                        <td class="CelLeft">
                            Order No:
                        </td>
                        <td class="CellRight">
                            <label id="lblOrder">
                            </label>
                        </td>
                    </tr>
                    <tr>
                        <td class="CelLeft">
                            Order Date:
                        </td>
                        <td class="CellRight">
                            <%= DateTime.Now.ToString() %>
                        </td>
                    </tr>
                    <tr>
                        <td class="AbowLine" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="CellLine" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="BelowLine" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="FormDetailBoxHeader" colspan="2">
                            Payment Type
                        </td>
                    </tr>
                    <tr>
                        <td class="CelLeftCheck" colspan="2">
                            <input id="radioBank" type="radio"  name="radio" class="Radio" checked="checked" />
                            Bank Transfer
                        </td>
                    </tr>
                    <tr>
                        <td class="CelLeftCheck" colspan="2">
                            <input id="radioPaypal" type="radio"  name="radio" class="Radio" />
                            Paypal
                        </td>
                    </tr>
                    <tr>
                        <td class="AbowLine" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="CellLine" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="BelowLine" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="CelLeftCheck" colspan="2">
                            <input id="checkAgree" type="checkbox" />
                            I accept the <a href="#" target="_blank"  style="color: #DD4B39" onclick="javascript:ShowTermCondition();"
                                title="Show Terms & Condition :: BabyShop"><u>Terms & Condition</u></a>
                        </td>
                    </tr>
                    <tr>
                        <td class="BelowLine" colspan="2">
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="BoxFooterLeft">
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContent" runat="server">
    <% var siteroot = Url.Content("~/"); %>
    <script src="<%: siteroot %>Scripts/CheckOut.js" type="text/javascript"></script>
    <script type="text/javascript">
        var data = '<%= ViewData["AddToCartItems"]%>'
        var data1 = '<%= ViewData["UserDetail"]%>'    
    </script>
</asp:Content>
