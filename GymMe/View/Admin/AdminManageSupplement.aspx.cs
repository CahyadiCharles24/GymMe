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
    public partial class AdminManageSupplement : System.Web.UI.Page
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
            GV_Supplement.DataSource = SupplementController.getAllSupplement();
            GV_Supplement.DataBind();
        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/AdminInsertSupplement.aspx");
        }

        protected void GV_Supplement_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GV_Supplement.Rows[e.NewEditIndex];
            String id = row.Cells[1].Text;
            Response.Redirect("~/View/Admin/AdminSupplementUpdate.aspx?ID="+id);
        }

        protected void GV_Supplement_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GV_Supplement.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[1].Text);
            SupplementRepository.deleteSupplement(id);
            Response.Redirect("~/View/Admin/AdminManageSupplement.aspx");
        }

    }
}