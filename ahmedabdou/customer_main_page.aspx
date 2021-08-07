<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customer_main_page.aspx.cs" Inherits="project.customer_main_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
             <h1>//HELLO CUTOMER</h1>


            <br />

            <asp:Button ID="view_products" runat="server" Text="view all products" PostBackUrl="~/all_products.aspx" />
            <br />
            <h1>write the name of the wishlist you want to add</h1>
            
            
            <asp:TextBox ID="wishlist_name" runat="server"></asp:TextBox>
            <asp:Button ID="add_wishlist" runat="server" Text="Add wishlist" OnClick="button_Add_wishlist" />
            <br />
            <h1>to add credit card insert (number,expirydate,cvv)</h1>
            <asp:TextBox ID="creditcardnumber" runat="server"></asp:TextBox>
            <asp:TextBox ID="expirydate" runat="server"></asp:TextBox>
            <asp:TextBox ID="cvv" runat="server"></asp:TextBox>

             <asp:Button ID="add_creditcard" runat="server" Text="Add creditcard" OnClick="button_Add_creditcard" />

          
            <br />
            <h1>to add/remeve product to wishlist insert (wishlistname,serialnum)</h1>
            <asp:TextBox ID="wishlistname_add" runat="server"></asp:TextBox>
            <asp:TextBox ID="serial_add" runat="server"></asp:TextBox>
             <asp:Button ID="add_to_watchlist" runat="server" Text="Add_product_toWatchlist" OnClick="button_Add_productToWatchlist" />
            <br />
            <asp:TextBox ID="wishlistname_remove" runat="server"></asp:TextBox>
            <asp:TextBox ID="serial_remove" runat="server"></asp:TextBox>
             <asp:Button ID="remove_from_watchlist" runat="server" Text="Remove_product_fromWatchlist" OnClick="button_remove_productToWatchlist" />
            <br />


            <h1>to add/remeve product to/from cart insert (serialnum)</h1>
            <asp:TextBox ID="serial_add_cart" runat="server"></asp:TextBox>
            <asp:Button ID="addtocart" runat="server" Text="Add_product_toCart" OnClick="button_Add_productToCart" />
            <br />
             <asp:TextBox ID="serial_remove_cart" runat="server"></asp:TextBox>
             <asp:Button ID="removefromcart" runat="server" Text="Remove_product_fromCart" OnClick="button_remove_productfromCart" />
            <br />


              <br />
            <asp:Label ID="error" runat="server"></asp:Label>

             <br />
             <br />

            <asp:Button ID="make_order" runat="server" Text="Make order" OnClick="make_order_Click" />
        <p>
            <asp:Button ID="cancel_order" runat="server" OnClick="Button1_Click1" Text="CancelOrder" />
        </p>
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />
    </form>
</body>
</html> 