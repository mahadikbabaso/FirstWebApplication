<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyDetails.aspx.cs" Inherits="FirstWebApplication.MyDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<script src="Scripts/MyDetails.js"></script>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>My Details</h1>
            <h1>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </h1>
            <h1>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </h1>
            <h1>
                <asp:Button ID="btnMyName" OnClick="btnMyName_Click" OnClientClick="valuecheck();" runat="server" Text="My Name" />
                <label id="lblResult" title=""></label>
            </h1>
            
        </div>
    </form>
</body>
</html>
