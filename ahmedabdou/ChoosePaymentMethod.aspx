<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChoosePaymentMethod.aspx.cs" Inherits="ahmedabdou.ChoosePaymentMethod" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />

            <asp:TextBox ID="TB2" Text="" runat="server" >enter order id </asp:TextBox>
            <br />
             <br />
            <asp:Button ID="CasheT" Text="Pay in Cashe Totally" runat="server"  PostBackUrl="~/ProceedToCheckOut.aspx" />
            <br />
             <br />
              <asp:Button ID="casheP" Text="Pay in Cashe partially" runat="server" OnClick="CasheT_Click" />
            
            <asp:TextBox ID="CshP" Text="specify cash amount on poth credit and cahs  " runat="server" ></asp:TextBox>
            
            <br />
             <br />
             <asp:Button ID="CreditF" Text="Pay Using One Credit" runat="server" OnClick="CasheT_Click"/>
           <asp:Button Text="CHoose a credit" runat="server" PostBackUrl="~/ChooseCreditCard.aspx" />
            <br />
             <br />
             <asp:Button ID="CreditP" Text="Pay Partially using Credit" runat="server" OnClick="CasheT_Click" />
            <asp:TextBox ID="Points" Text="specify cash amount on poth credit and cahs " runat="server" ></asp:TextBox>
           <asp:Button Text="CHoose a credit" runat="server" PostBackUrl="~/ChooseCreditCard.aspx" />
            <br />
             <br />
            <asp:Button Text="proceed to check out " runat="server" PostBackUrl="~/ProceedToCheckOut.aspx" />
            
        </div>
    </form>
</body>
</html>