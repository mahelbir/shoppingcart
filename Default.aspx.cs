using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI.WebControls;

namespace ShoppingCart
{
    public partial class Default : System.Web.UI.Page
    {

        protected Dictionary<int, Book> BookList()
        {
            if (Session["books"] == null)
            {
                Session.Add("books", new Dictionary<int, Book> {
                    {1,  new Book(1, "ASP.NET 3.5 Unleashed", "Stephen Walther", "Sams", 1920, "book_1.jpg") },
                    {2, new Book(2, "ASP.NET Evolution", "Dan Kent", "Sams", 384, "book_2.jpg") },
                    {3, new Book(3, "Mastering Web Development with Microsoft Visual Studio 2005", "John Paul Mueller", "Sams", 848, "book_3.jpg") },
                    {4, new Book(4, "Beginning ASP.NET 2.0 ", "Chris Hart, John Kauffman, Dave Sussman, Chris Ullman", "Wrox", 792, "book_4.jpg") },
                    {5, new Book(5, "Beginning ASP.NET 3.5 in C# 2008: From Novice to Professional, Second Edition", "Matthew MacDonald", "Apress", 954, "book_5.jpg") }
                });
            }
            return (Dictionary<int, Book>)Session["books"];
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            pnlManage.Visible = false;
            pnlLogin.Visible = false;

            HttpCookie userCookie = Request.Cookies["UserInfo"];
            if (userCookie != null && userCookie["firstName"] != null && userCookie["lastName"] != null)
            {
                pnlManage.Visible = true;
                lblUserInfo.Text = $"Welcome {userCookie["firstName"]} {userCookie["lastName"]}";
                Dictionary<int, Book> bookList = this.BookList();
                foreach (var bookItem in bookList)
                {
                    Book book = bookItem.Value;
                    blistBooks.Items.Add(new ListItem(book.Title, "BookInfo.aspx?id=" + book.BookID));
                }
            }
            else
            {
                pnlLogin.Visible = true;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["UserInfo"] != null)
            {
                HttpCookie userCookie = Request.Cookies["UserInfo"];
                userCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(userCookie);
            }
            Response.Redirect("Default.aspx");
        }
    }
}