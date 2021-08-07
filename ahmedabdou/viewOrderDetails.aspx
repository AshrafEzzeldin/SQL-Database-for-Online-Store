<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewOrderDetails.aspx.cs" Inherits="ahmedabdou.viewOrderDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button Text="Go To Payment" runat="server" PostBackUrl="~/ChoosePaymentMethod.aspx" />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:Button Text="Show" runat="server" OnClick="Unnamed_Click" />
        </div>
    </form>
</body>
</html>