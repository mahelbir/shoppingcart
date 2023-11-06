<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShoppingCart.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.2/css/bootstrap.min.css" />
    <title>Home</title>
</head>
<body>
    <div class="container-fluid py-3">
        <asp:Panel ID="pnlLogin" runat="server">
            <span>You are not logged in.</span>
            <br />
            <asp:HyperLink ID="hrfLogin" runat="server" NavigateUrl="~/Login.aspx">Please log in here.</asp:HyperLink>
        </asp:Panel>
        <asp:Panel ID="pnlManage" runat="server" BorderStyle="None">
            <form id="form1" runat="server">
                <div class="row">
                    <div class="col-md-5">
                        <asp:Label ID="lblUserInfo" runat="server" Font-Bold="True"></asp:Label>
                        <br />
                        <br />
                        <asp:HyperLink ID="hrefCart" runat="server" NavigateUrl="~/Cart.aspx">Display Shopping Cart</asp:HyperLink>
                        <br />
                        <br />
                        <asp:LinkButton ID="btnLogout" runat="server" OnClick="btnLogout_Click" CssClass="btn btn-danger">Logout</asp:LinkButton>

                    </div>
                    <div class="col-md-7">
                        <asp:Label ID="lblBooks" runat="server" Text="Select a book:"></asp:Label>
                        <br />
                        <asp:BulletedList ID="blistBooks" runat="server" DisplayMode="HyperLink"></asp:BulletedList>
                    </div>
                </div>
            </form>
        </asp:Panel>
    </div>
</body>
</html>
