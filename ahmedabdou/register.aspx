<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="ahmedabdou.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Registration"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="fname" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Last Name"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="lname" runat="server"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="Label3" runat="server" Text="username"></asp:Label>
            <br />
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="Label4" runat="server" Text="password"></asp:Label>
            <br />
        <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
    
            <br />
            <br />
             <asp:Label ID="Label5" runat="server" Text="email"></asp:Label>
            <br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="registerto" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Log in" OnClick="login" style="direction: ltr" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
