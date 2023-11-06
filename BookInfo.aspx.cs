using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    public partial class BookInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlBook.Visible = false;
            pnlError.Visible = false;

            try
            {
                if (Session["books"] == null)
                {
                    pnlError.Visible = true;
                    ltError.Text = "Please login before!";

                }
                else if (String.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    pnlError.Visible = true;
                    ltError.Text = "Please specify a book ID!";
                }
                else
                {
                    int bookId = Convert.ToInt32(Request.QueryString["id"]);
                    Dictionary<int, Book> books = (Dictionary<int, Book>)Session["books"];
                    Book book = books[bookId];
                    pnlBook.Visible = true;
                    imgBook.ImageUrl = "images/" + book.ImageUrl;
                    lblTitle.Text = book.Title;
                    lblAuthor.Text = "Author: " + book.Author;
                    lblPublisher.Text = "Publisher: " + book.Publisher;
                    lblPages.Text = "Pages: " + book.PageNumber;
                }
            }
            catch
            {
                pnlError.Visible = true;
                ltError.Text = "Invalid book ID!";
            }
        }

        protected void btnAddCart_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId = Convert.ToInt32(Request.QueryString["id"]);
                List<int> selectedBooks;
                if (Session["selectedBooks"] == null)
                {
                    selectedBooks = new List<int>();
                    Session.Add("selectedBooks", selectedBooks);
                }
                selectedBooks = (List<int>)Session["selectedBooks"];
                if (selectedBooks.Contains(bookId))
                {
                    lblCart.Text = "Book is in already in the list!";
                }
                else
                {
                    selectedBooks.Add(bookId);
                    Session["selectedBooks"] = selectedBooks;
                    lblCart.Text = "Book is added to shopping cart.";
                }
            }
            catch
            {
                pnlError.Visible = true;
                ltError.Text = "Something went wrong!";
            }
        }
    }
}