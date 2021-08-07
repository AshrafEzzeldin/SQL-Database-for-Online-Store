<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CancelOrder.aspx.cs" Inherits="ahmedabdou.CancelOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Cancel" Text="Cancel an Order" runat="server" OnClick="Cancel_Click" />
            <asp:TextBox ID="OID" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>