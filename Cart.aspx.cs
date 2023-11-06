using System;
using System.Collections.Generic;
using System.Data;

namespace ShoppingCart
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["selectedBooks"] == null || ((List<int>)Session["selectedBooks"]).Count == 0)
            {
                lblInfo.Text = "Your shopping cart is empty!";
            }
            else
            {
                listViewBooks.DataSource = this.GetData();
                listViewBooks.DataBind();
            }
        }


        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("BookID", typeof(int));
            dt.Columns.Add("ImageUrl", typeof(string));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Author", typeof(string));
            dt.Columns.Add("Publisher", typeof(string));
            dt.Columns.Add("PageNumber", typeof(int));

            List<int> selectedBooks = (List<int>)Session["selectedBooks"];
            Dictionary<int, Book> books = (Dictionary<int, Book>)Session["books"];

            foreach (var selectedBookId in selectedBooks)
            {
                Book book = books[selectedBookId];
                dt.Rows.Add(book.BookID, book.ImageUrl, book.Title, book.Author, book.Publisher, book.PageNumber);
            }

            return dt;
        }
    }
}