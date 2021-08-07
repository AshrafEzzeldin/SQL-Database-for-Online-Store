<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vendor_home.aspx.cs" Inherits="ahmedabdou.vendor_home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            &nbsp;<asp:TextBox ID="tphone" runat="server" Width="275px"></asp:TextBox>
            &nbsp;<asp:Button ID="Button1" runat="server" Text="Add a telephone number" OnClick="addphone" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="taddress" runat="server" style="margin-left: 0px" Width="391px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Add an address" OnClick="add_address" />
            <br />
            <br />
        </div>
        <asp:Panel ID="p_on_sys" runat="server" BackColor="#00FF99">
            <asp:Label ID="Label1" runat="server" Text="The Products on the Store"></asp:Label>
        <asp:GridView ID="showproducts" runat="server">
        </asp:GridView>
        </asp:Panel>
        
        <asp:Panel ID="Panel5" runat="server">
            <asp:Label ID="Label15" runat="server" Text="Posting Products on the System"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label16" runat="server" Text="Product name"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox1" runat="server" style="direction: ltr"></asp:TextBox>

            &nbsp;
            <br />
            <br />
            <asp:Label ID="Label17" runat="server" Text="Category"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;
            <br />
            <br />
            <asp:Label ID="Label18" runat="server" Text="product description"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="Label19" runat="server" Text="Color"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label20" runat="server" Text="Price"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button8" runat="server" Text="Post" OnClick="post" Width="85px" />
            <br />
        </asp:Panel>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="MY PRODUCTS"></asp:Label>
        <br />
        <asp:GridView ID="ven_products" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Please enter the id of the product you want to delete"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="delete" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="delete" OnClick="delete_product" />
        <br />
        <asp:Panel ID="Panel1" runat="server" BackColor="#33CCFF">
            <h3 > For updating products</h3>
            <asp:Label ID="Label4" runat="server" Text="Pruduct serial number"></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="sn" runat="server"></asp:TextBox>
            
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Prudct name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Category"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="cat" runat="server"></asp:TextBox>
&nbsp;
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="product description"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="pd" runat="server"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="Label8" runat="server" Text="Color"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="color" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Price"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="price" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Height="54px" Text="Update product" Width="237px" OnClick="update_product" />
            <br />
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel2" runat="server" BackColor="#66FF33" BorderColor="#FF3300" BorderStyle="Ridge" BorderWidth="10px">
            <h3> Creating an OFFER</h3>
            
            <h3>
                <asp:Label ID="Label10" runat="server" Text="Offer amount"></asp:Label>
                &nbsp;
                <asp:TextBox ID="offer" runat="server"></asp:TextBox>
            </h3>
            
            <p>
                <asp:Label ID="Label11" runat="server" Text="Expiry date of the offer" Font-Bold="True" Font-Size="Large"></asp:Label>
                &nbsp;
                <asp:TextBox ID="ex_date" runat="server"></asp:TextBox>
            </p>
            
            <p>
                <asp:Button ID="Button5" runat="server" Text="create" Font-Bold="True" Font-Italic="True" Font-Size="Large" OnClick="create_offer" />
            </p>
            
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" BackColor="#66FF33" BorderColor="#FF3300" BorderStyle="Ridge" BorderWidth="10px">
            <h3> Applying an OFFER on a Product</h3>
            
            <h3>
                <asp:Label ID="Label12" runat="server" Text="Offer id"></asp:Label>
                &nbsp;
                <asp:TextBox ID="id" runat="server"></asp:TextBox>
            </h3>
            
            <p>
                <asp:Label ID="Label13" runat="server" Text="Product serial number" Font-Bold="True" Font-Size="Large"></asp:Label>
                &nbsp;
                <asp:TextBox ID="num" runat="server"></asp:TextBox>
            </p>
            
            <p>
                <asp:Button ID="Button6" runat="server" Text="Apply" Font-Bold="True" Font-Italic="True" Font-Size="Large" OnClick="Apply_offer" />
            </p>
            
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server" BackColor="#66FF33" BorderColor="#FF3300" BorderStyle="Ridge" BorderWidth="10px">
            <h3> Removing an expired OFFER </h3>
            
            <h3>
                <asp:Label ID="Label14" runat="server" Text="Offer id"></asp:Label>
                &nbsp;
                <asp:TextBox ID="off" runat="server"></asp:TextBox>
            </h3>
            
            
            <p>
                <asp:Button ID="Button7" runat="server" Text="Remove" Font-Bold="True" Font-Italic="True" Font-Size="Large" OnClick="remove" />
            </p>
            
        </asp:Panel>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="Button9" runat="server" Text="logout" OnClick="Button9_Click" />
        </p>
    </form>
</body>
</html>
