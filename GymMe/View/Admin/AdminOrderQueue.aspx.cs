using GymMe.Controller;
using GymMe.Model;
using GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.View.Admin
{
    public partial class AdminOrderQueue : System.Web.UI.Page
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
                    string id = Request.Cookies["user_cookie"].Value;
                    MsUser userFromCookie = UserController.getUserById(id);
                    Session["user"] = userFromCookie;
                    if (userFromCookie.UserRole.Equals("customer"))
                    {
                        Response.Redirect("~/View/Customer/CustHome.aspx");
                    }
                }
            }

            if (!IsPostBack)
            {
                GV_Order.DataSource = TransactionController.getAllTransactionHeader();
                GV_Order.DataBind();
            }

        }

        protected void GV_Order_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string status = DataBinder.Eval(e.Row.DataItem, "Status").ToString();

                Button handleButton = (Button)e.Row.FindControl("Btn_Handle");

                if (status == "unhandled")
                {
                    handleButton.Visible = true;
                }
                else
                {
                    handleButton.Visible = false;
                }
            }
        }
        protected void GV_Order_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Handle")
            {
                int transactionID = Convert.ToInt32(e.CommandArgument);
                Label1.Text = Convert.ToString(transactionID);
                TransactionController.changeStatus(transactionID);
                Response.Redirect("~/View/Admin/AdminOrderQueue.aspx");
            }else if(e.CommandName == "View")
            {
                int transactionID = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("~/View/Admin/AdminTransactionDetail.aspx?ID=" + transactionID);
            }

        }
    }
}