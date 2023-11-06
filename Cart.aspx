<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ShoppingCart.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.2/css/bootstrap.min.css" />
    <title>Shopping Cart</title>
</head>
<body>
    <div class="container-fluid py-3">
        <div class="row">

            <div class="col-12">
                <asp:Label ID="lblInfo" runat="server" CssClass="text-primary" Font-Bold="True" Font-Size="Large"></asp:Label>
            </div>

            <asp:ListView ID="listViewBooks" runat="server">
                <ItemTemplate>
                    <div class="col-md-4 text-center">
                        <img class="img-fluid" src="images/<%# Eval("ImageUrl") %>" style="max-height: 600px;" />
                    </div>
                    <div class="col-md-8">
                        <h5><%# Eval("Title") %></h5>
                        <br />
                        <br />
                        <div>Author: <%# Eval("Author") %></div>
                        <div>Publisher: <%# Eval("Publisher") %></div>
                        <div>Pages: <%# Eval("PageNumber") %></div>

                    </div>
                    <hr />
                </ItemTemplate>
            </asp:ListView>

            <div class="col-12">
                <br />
                <asp:HyperLink ID="hrefDefault" runat="server" NavigateUrl="~/Default.aspx">Return to Home Page</asp:HyperLink>
            </div>
        </div>
    </div>
</body>
</html>
