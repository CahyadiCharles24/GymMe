using GymMe.Controller;
using GymMe.Dataset;
using GymMe.Model;
using GymMe.Report;
using GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.View.Admin
{
    public partial class Report : System.Web.UI.Page
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
            CrystalReport report = new CrystalReport();
            DataSet1 data = DataSetController.getDataSet(TransactionController.getAllTransactionHeader());
            report.SetDataSource(data);
            CrystalReportViewer1.ReportSource = report;
        }
    }
}