<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>
<div class="main-footer">
    <div class="fl footerLinks">
        <ul>
            <li><a href="#">terms &amp; conditions</a></li>
            <li><a href="#">privacy policy</a></li>
            <li><a href="#">refund policy</a></li>
            <li><a href="#">site map</a></li>
            <li><a href="#">conatct us</a></li>
            <li><a href="#">blog</a></li>
            <li><a href="#">
                <img src="<%=Url.Content("~/Content/Images/spacer.gif")%>" alt="" class="twitter" /></a><a
                    href="#"><img src="<%=Url.Content("~/Content/Images/spacer.gif")%>" alt="" class="facebook" /></a><a
                        href="#"><img src="<%=Url.Content("~/Content/Images/spacer.gif")%>" alt="" class="thirdicon" /></a></li>
            <div class="cl">
            </div>
        </ul>
    </div>
    <div class="fr padT10">
        &copy; 2011 Hush Pure Sleep</div>
</div>
