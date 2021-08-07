<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChooseCreditCard.aspx.cs" Inherits="ahmedabdou.ChooseCreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="select" Text="Enter" runat="server" OnClick="select_Click" />
            <asp:TextBox ID="CCN" runat="server">enter credit card number</asp:TextBox>
             <asp:TextBox ID="OID" runat="server">enter order id </asp:TextBox>
            <br />
              <asp:Button ID="Button1" Text="Proceed to check out" runat="server" PostBackUrl="~/ProceedToCheckOut.aspx" />
        </div>
    </form>
</body>
</html>