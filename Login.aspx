<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ShoppingCart.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.2/css/bootstrap.min.css" />
    <title>Login</title>
</head>
<body>
    <div class="container-fluid py-3">
        <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
        <form id="form1" runat="server" autocomplete="off">
            <div class="mb-3">
                <label>First Name</label>
                <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" EnableViewState="False" required="True"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label>Last Name</label>
                <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" EnableViewState="False" required="True"></asp:TextBox>
            </div>
            <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-primary btn-lg" EnableViewState="False" OnClick="btnLogin_Click" Text="Login" />
        </form>
    </div>
</body>
</html>
