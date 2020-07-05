<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FirstWebApplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="Scripts/MyDetails.js"></script>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <h1>UserName 
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </h1>
            <h1>Password 
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </h1>
            <asp:Button ID="btnMyName" OnClick="btnLogin" OnClientClick="valuecheck();" runat="server" Text="Login"   />
            <label id="lblResult" title=""></label>
        </div>
    </form>
</body>
</html>
