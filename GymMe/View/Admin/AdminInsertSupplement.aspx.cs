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
    public partial class AdminInsertSupplement : System.Web.UI.Page
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
        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            String name = TB_SuppName.Text;
            DateTime expiry = Cldr_Expiry.SelectedDate;
            String price = TB_SuppPrice.Text;
            String typeID = TB_SuppTypeID.Text;

            Lbl_status.Text = SupplementController.validateSupplement(name,expiry,price,
                typeID);
            Lbl_status.ForeColor = System.Drawing.Color.Red;

            if(Lbl_status.Text == "")
            {
                Response.Redirect("~/View/Admin/AdminManageSupplement.aspx");
            }
        }

        protected void Btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/AdminManageSupplement.aspx");
        }
    }
}