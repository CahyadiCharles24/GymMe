using GymMe.Controller;
using GymMe.Model;
using GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null ||
                Request.Cookies["user_cookie"] != null)
            {

                string id = Request.Cookies["user_cookie"].Value;
                MsUser userfromcookie = UserController.getUserById(id);
                if (userfromcookie.UserRole.Equals("customer"))
                {
                    Response.Redirect("~/View/Customer/CustHome.aspx");
                }
                else if (userfromcookie.UserRole.Equals("admin"))
                {
                    Response.Redirect("~/View/Admin/AdminHome.aspx");

                }
            }
        }

        protected void Btn_Regis_Click(object sender, EventArgs e)
        {
            String username = TB_Username.Text;
            String email = TB_Email.Text;
            String gender = genderradiobuttonlist.SelectedValue;
            String pass = TB_Pass.Text;
            String Cpass = TB_Cpass.Text;
            DateTime DOB = calender.SelectedDate;

            Lbl_errorMsg.Text = UserController.validateNewUser(username, email, gender, pass, 
                Cpass, DOB, "customer");
            Lbl_errorMsg.ForeColor = System.Drawing.Color.Red;

            if (Lbl_errorMsg.Text == "")
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/LoginPage.aspx");
        }
    }
}