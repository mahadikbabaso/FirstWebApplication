<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SingUp.aspx.cs" Inherits="FirstWebApplication.MyDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    <title>SingUp</title>
    <script src="Scripts/MyDetails.js"></script>
    <style type="text/css">
        .cssWidth {
            width: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <span>SingUp</span>
        <div  style="padding-top: 10px;">
            <span>UserName      
                <asp:TextBox ID="txtUserName" CssClass="cssWidth" runat="server"></asp:TextBox>
            </span>
        </div>
        <div>
            <span style="padding-top: 10px;">Password    
                <asp:TextBox ID="txtPassword" CssClass="cssWidth" runat="server"></asp:TextBox>
            </span>
        </div>
        <div style="padding-top: 20px;">
            <span>
                <asp:Button ID="btnCreateLogin" OnClick="btnCreateLoginClick" OnClientClick="valuecheck();" runat="server" Text="Create Login" />
                <label id="lblResult" title=""></label>
            </span>
        </div>
        <div  style="padding-top: 20px;">
            <span>
                <a href="Login.aspx">Click here to go to Login</a>
            </span>
        </div>
    </form>
</body>
</html>
