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
    public partial class CustTransactionHistory : System.Web.UI.Page
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
                    if (userFromCookie.UserRole.Equals("admin"))
                    {
                        Response.Redirect("~/View/Admin/AdminHome.aspx");

                    }
                }
            }

            MsUser us = (MsUser)Session["user"];
            int ids = us.UserID;
            GV_History.DataSource = TransactionController.getTransactionHistory(ids);
            GV_History.DataBind();


        }

        protected void GV_History_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = GV_History.SelectedRow.Cells[1].Text;
            Response.Redirect("~/View/Customer/CustHistoryDetail.aspx?Id=" + id);
        }

    }
}