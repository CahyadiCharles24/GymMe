using GymMe.Controller;
using GymMe.Model;
using GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.View.Customer
{
    public partial class CustHistoryDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
            else
            {
                if (Session["user"] == null)
                {
                    String id = Request.Cookies["user_cookie"].Value;
                    MsUser userFromCookie = UserController.getUserById(id);
                    Session["user"] = userFromCookie;
                    if (userFromCookie.UserRole.Equals("admin"))
                    {
                        Response.Redirect("~/View/Admin/AdminHome.aspx");

                    }
                }
            }
            String ids = Request.QueryString["id"];
            GV_detail.DataSource = TransactionController.getTransactionDetailByID(Convert.ToInt32(ids));
            GV_detail.DataBind();
        }

        protected void Btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Customer/CustTransactionHistory.aspx");
        }
    }
}