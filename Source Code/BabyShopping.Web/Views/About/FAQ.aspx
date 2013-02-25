<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Inner.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    FAQ
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="inner-section">
        <div class="roundedTop">
            <img src="<%=Url.Content("~/Content/Images/roundtopLft.png")%>" alt="" class="fl" />
            <img src="<%=Url.Content("~/Content/Images/roundtopRght.png")%>" alt="" class="fr" />
        </div>
        <div class="roundedBg">
            <h1>
                <b>FAQ</b></h1>
            <h2>
                We don't use pure cotton because it sounds good, we use pure cotton because it <b>is</b>
                good.</h2>
            <p>
                Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                Ipsum has been the industry's standard dummy text ever since the 1500s, when an
                unknown <a href="#">printer took a</a> galley of type and scrambled it to make a
                type specimen book. It has survived not only five centuries, but also the leap into
                electronic typesetting, remaining essentially unchanged. It was popularised in the
                1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more
                recently with desktop publishing software like Aldus PageMaker including versions
                of Lorem Ipsum.</p>
        </div>
        <div class="roundedBot">
            <img src="<%=Url.Content("~/Content/Images/roundBotLft.png")%>" alt="" class="fl" />
            <img src="<%=Url.Content("~/Content/Images/roundBotRght.png")%>" alt="" class="fr" />
        </div>
    </div>
    <div class="cl">
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
