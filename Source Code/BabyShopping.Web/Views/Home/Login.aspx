<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <% var siteroot = Url.Content("~/"); %>
    <script src="<%: siteroot %>Scripts/jquery-1.4.4.min.js" type="text/javascript"></script>
    <script src="<%: siteroot %>Scripts/jquery.min.js" type="text/javascript"></script>
    <script src="<%: siteroot %>Scripts/Common.js" type="text/javascript"></script>
    <script src="<%: siteroot %>Scripts/Login.js" type="text/javascript"></script>
    <link href="../../Content/Class.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div>
        <div>
            <form action="Login.aspx" method="post">
            <input id="Errors" name="Errors" type="hidden" value='<%=Session["Error"]%>' />
            <div class="divTable" style="width: 30%; position: relative; height: 180px; left: 35%;
                top: 100px;">
                <div class="divRow" style="width: 100%;">
                    <div class="divCell" style="width: 100%; border-bottom: 1px solid #808076; margin-bottom: 10px;
                        padding-bottom: 10px;">
                        <div style="position: relative; top: 20px;">
                            <span class="header-label">Log In</span></div>
                        <div style="position: relative; float: right;">
                            For New User|<a href="#" onclick="javascript:fnRegister();" title="Register Here"><span style="color: #DD4B39; font-weight: bold">Register.</span></a>
                        </div>
                    </div>
                </div>
                <div class="divRow" style="width: 100%;">
                    <span id="error_Message" class="msg-error"></span>
                    <div class="divCell" style="width: 100%;">
                        <label>
                            <strong class="email-label">User Id :</strong>
                            <input type="text" name="MLoginRightsUserID" id="MLoginRightsUserID" class="lblinput"
                                value="" />
                            <span id="error_MLoginRightsUserID" class="msg-error"></span>
                        </label>
                    </div>
                </div>
                <div class="divRow" style="width: 100%; height: 5px;">
                    <div class="divCell" style="width: 100%;">
                        <label>
                            <strong class="email-label">Password : </strong>
                            <input type="password" name="MLoginRightsPassword" class="lblinput" id="MLoginRightsPassword" />
                            <span id="error_MLoginRightsPassword" class="msg-error"></span>
                        </label>
                    </div>
                </div>
                <div class="divRow" style="height: 50px;">
                    <div class="divCell" style="width: 23%;">
                        <input type="submit" class="e-button e-button-submit" name="signIn" id="signIn" value="Sign In >>"
                            title="Sign In" />
                    </div>
                    <div class="divCell" style="position: relative; left: 15%; top: 10px;">
                        <a href="#" title="Forget Password"><span style="color: #87877D; font-size: 13px;
                            text-decoration: underline;">Forget Password ?</span></a>
                    </div>
                </div>
            </div>
            </form>
        </div>
    </div>
</body>
</html>
