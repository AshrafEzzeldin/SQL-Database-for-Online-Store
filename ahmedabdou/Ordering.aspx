<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ordering.aspx.cs" Inherits="ahmedabdou.Ordering" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
               
                
                  <asp:Button runat="server"  Text="MakeOrder" OnClick="make_order" />
                   <br />
                    <br />
                    <asp:Button Text ="View order detail please " runat="server" PostBackUrl="~/viewOrderDetails.aspx"/> 

            <br />
            <br />
            <br />
            <br />

             <asp:Button runat="server" Text="ChoosePaymentMrthod" PostBackUrl="~/ChoosePaymentMethod.aspx" />
            

      
            </div>
       </form>
    </body>
</html>