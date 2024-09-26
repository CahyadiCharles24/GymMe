using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Layout
{
    public partial class CustomerMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Order_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Customer/OrderSupplement.aspx");
        }

        protected void Btn_History_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Customer/CustTransactionHistory.aspx");
        }

        protected void Btn_Profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Customer/CustProfile.aspx");
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            HttpCookie cookie = Request.Cookies["user_cookie"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddHours(-2);
                Response.Cookies.Add(cookie);
            }
            Response.Redirect("~/View/LoginPage.aspx");
        }
    }
}