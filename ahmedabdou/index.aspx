 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ahmedabdou.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbl_username" runat="server" Text="Username: "></asp:Label>
    
        <asp:TextBox ID="txt_username" runat="server" Width="242px"></asp:TextBox>
    
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    
        <br />
    
        <br />
        <asp:Label ID="lbl_password" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="txt_password" runat="server" TextMode="Password" Width="240px"></asp:TextBox>
    
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    
        <br />
    
        <br />
        <asp:Button ID="btn_login" runat="server" Text="Login" onclick="login" Width="90px"/>
    
        <br />
        <br />
        <a href="/register.aspx" ID="HeadregisterStatus" runat="server">create customer account</a>
        <br />
        <br />
        <a href="/vendorRegister.aspx" ID="A1" runat="server">create vendor account</a>
    </div>
    </form>
</body>
</html>
