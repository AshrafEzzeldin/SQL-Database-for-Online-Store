<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProceedToCheckOut.aspx.cs" Inherits="WepApp.ProceedToCheckOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>You made the order succesfully </h3>
            <asp:Button Text="Cansel Order" runat="server" PostBackUrl="~/CancelOrder.aspx" />
        </div>
    </form>
</body>
</html>