using GymMe.Controller;
using GymMe.Model;
using GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.View
{
    public partial class LoginPage : System.Web.UI.Page
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
                }else if (userfromcookie.UserRole.Equals("admin"))
                {
                    Response.Redirect("~/View/Admin/AdminHome.aspx");

                }
            }
        }

        protected void Btn_login_Click(object sender, EventArgs e)
        {
            String username = TB_Username.Text;
            String password = TB_pass.Text;
            bool RememberMe = CB_RememberMe.Checked;

            Lbl_errorMsg.Text = UserController.validateLogin(username, password);
            Lbl_errorMsg.ForeColor = System.Drawing.Color.Red;


            if (Lbl_errorMsg.Text == "")
            {
                var us = UserController.getUserByUsername(username);
                if (RememberMe)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = us.UserID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                Session["user"] = us;
                if (us.UserRole.Equals("admin"))
                {
                    Response.Redirect("~/View/Admin/AdminHome.aspx");
                }
                else if (us.UserRole.Equals("customer"))
                {
                    Response.Redirect("~/View/Customer/CustHome.aspx");
                }

            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/RegisterPage.aspx");
        }
    }
}