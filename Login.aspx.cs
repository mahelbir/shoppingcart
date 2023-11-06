using System;
using System.Web;

namespace ShoppingCart
{
    public partial class Login : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie userCookie = Request.Cookies["UserInfo"];
            if (userCookie != null && userCookie["firstName"] != null && userCookie["lastName"] != null)
                Response.Redirect("Default.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFirstName.Text) && !String.IsNullOrEmpty(txtLastName.Text))
            {
                HttpCookie userCookie = new HttpCookie("UserInfo");
                userCookie["firstName"] = txtFirstName.Text;
                userCookie["lastName"] = txtLastName.Text;
                userCookie.Expires = DateTime.Now.AddMonths(1);
                Response.Cookies.Add(userCookie);
                Response.Redirect("Default.Aspx");
            }
            else
            {
                lblError.Text = "Invalid information!";
            }
        }
    }
}