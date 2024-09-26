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
    public partial class CustProfile : System.Web.UI.Page
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
                    if (!IsPostBack)
                    {
                        TB_Email.Text = userFromCookie.UserEmail;
                        TB_Username.Text = userFromCookie.UserName;
                        calendar.SelectedDate = userFromCookie.UserDOB;
                        Label_UserDOBnOW.Text = userFromCookie.UserDOB.ToString("dd-MM-yyyy");


                        if (userFromCookie.UserGender.Equals("male"))
                        {
                            GenderBTN.Items.FindByValue("male").Selected = true;
                        }
                        else if (userFromCookie.UserGender.Equals("female"))
                        {
                            GenderBTN.Items.FindByValue("female").Selected = true;
                        }

                    }
                }
                else
                {
                    if (!IsPostBack)
                    {
                        MsUser us = (MsUser)Session["user"];
                        TB_Email.Text = us.UserEmail;
                        TB_Username.Text = us.UserName;
                        calendar.SelectedDate = us.UserDOB;
                        Label_UserDOBnOW.Text = us.UserDOB.ToString("dd-MM-yyyy");


                        if (us.UserGender.Equals("male"))
                        {
                            GenderBTN.Items.FindByValue("male").Selected = true;
                        }
                        else if (us.UserGender.Equals("female"))
                        {
                            GenderBTN.Items.FindByValue("female").Selected = true;
                        }

                    }
                }
            }

        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            MsUser us = (MsUser)Session["user"];

            int userID = us.UserID;
            string Email = TB_Email.Text;
            string username = TB_Username.Text;
            DateTime DOB = calendar.SelectedDate;
            string Gender = GenderBTN.SelectedValue;
            bool isTrue = PasswordSection.Visible;

            if (!isTrue)
            {
                string password = us.UserPassword;

                Lbl_ErorMsg.Text = UserController.validateUpdate(userID, Email, username, Gender, DOB, password);
                if (Lbl_ErorMsg.Text == "")
                {
                    Lbl_ErorMsg.Text = "Successfull Update";
                }
            }
            else
            {
                string oldpass = TB_OldPass.Text;
                Lbl_ErorMsg.Text = UserController.validateOldPassword(userID, oldpass);

                if (Lbl_ErorMsg.Text == "")
                {
                    string password = TB_NewPass.Text;
                    Lbl_ErorMsg.Text = UserController.validateUpdate(userID, Email, username, Gender, DOB, password);
                    if (Lbl_ErorMsg.Text == "")
                    {
                        Lbl_ErorMsg.Text = "Successfull Update";

                    }
                }

            }


        }

        protected void Btn_ChangePass_Click(object sender, EventArgs e)
        {
            PasswordSection.Visible = true;

        }
    }
}