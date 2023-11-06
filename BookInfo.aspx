<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookInfo.aspx.cs" Inherits="ShoppingCart.BookInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.2/css/bootstrap.min.css" />
    <title>Book Info</title>
</head>
<body>

    <div class="container-fluid py-3">

        <asp:Panel ID="pnlBook" runat="server">
            <div class="row">
                <div class="col-md-4 text-center">
                    <asp:Image ID="imgBook" CssClass="img-fluid" Style="max-height: 600px;" runat="server" />
                </div>
                <div class="col-md-8">
                    <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblAuthor" runat="server"></asp:Label><br />
                    <asp:Label ID="lblPublisher" runat="server"></asp:Label><br />
                    <asp:Label ID="lblPages" runat="server"></asp:Label><br />
                    <br />
                    <form id="form1" runat="server">
                        <asp:Label ID="lblCart" runat="server" CssClass="text-info"></asp:Label><br />
                        <asp:LinkButton ID="btnAddCart" CssClass="btn btn-success" runat="server" OnClick="btnAddCart_Click">Add to Cart</asp:LinkButton>
                    </form>
                    <br />
                    <asp:HyperLink ID="hrefCart" runat="server" NavigateUrl="~/Cart.aspx">Display Shopping Cart</asp:HyperLink>
                    <br />
                    <asp:HyperLink ID="hrefDefault" runat="server" NavigateUrl="~/Default.aspx">Return to Home Page</asp:HyperLink>
                    <br />
                </div>
            </div>
        </asp:Panel>

        <asp:Panel ID="pnlError" runat="server">
            <div class="alert alert-danger">
                <asp:Literal ID="ltError" runat="server"></asp:Literal>
            </div>
            <asp:HyperLink ID="hrefDefault2" runat="server" NavigateUrl="~/Default.aspx">Return to Home Page</asp:HyperLink>
        </asp:Panel>

    </div>

</body>
</html>
