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
    public partial class AdminSupplementUpdate : System.Web.UI.Page
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
                String id = Request.QueryString["id"];
                MsSupplement supp = SupplementController.getSupplementById(Convert.ToInt32(id));
                TB_SuppName.Text = supp.SupplementName;
                TB_ExpiryDate.Text = supp.SupplementExpiryDate.ToString("dd-MM-yyyy");
                Cldr_Expiry.SelectedDate = supp.SupplementExpiryDate;
                TB_SuppPrice.Text = supp.SupplementPrice.ToString();
                TB_SuppTypeID.Text = supp.SupplementTypeID.ToString();                
            }
            if (Cldr_Expiry.SelectedDate != DateTime.MinValue)
            {
                TB_ExpiryDate.Text = Cldr_Expiry.SelectedDate.ToString("dd-MM-yyyy");
            }
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            String id = Request.QueryString["id"];
            String name = TB_SuppName.Text;
            DateTime expiryDate = Cldr_Expiry.SelectedDate;
            String price = TB_SuppPrice.Text;
            String typeID = TB_SuppTypeID.Text;

            Lbl_status.Text = SupplementController.validateUpdate(Convert.ToInt32(id), name, expiryDate, price, typeID);
            Lbl_status.ForeColor = System.Drawing.Color.Red;
            if (Lbl_status.Text == "")
            {
                Response.Redirect("~/view/admin/adminmanagesupplement.aspx");
            }
        }

        protected void Btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/AdminManageSupplement.aspx");
        }
    }
}