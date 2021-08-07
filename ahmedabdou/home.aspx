<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="ahmedabdou.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<asp:TextBox ID="tphone" runat="server" Width="275px"></asp:TextBox>
            &nbsp;<asp:Button ID="Button1" runat="server" Text="Add a telephone number" OnClick="addphone" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="taddress" runat="server" style="margin-left: 0px" Width="391px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Add an address" OnClick="add_address" />
        </div>
    </form>
</body>
</html>
