using GymMe.Controller;
using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.View.Customer
{
    public partial class OrderSupplement : System.Web.UI.Page
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

            if (!IsPostBack)
            {
                
                BindGridView();
            }


        }

        private void BindGridView()
        {
            // Get supplements and their types
            List<MsSupplement> supplements = SupplementController.getAllSupplement();
            List<MsSupplementType> supplementTypes = SupplementController.getAllSupplementType();

            // Join the data to get the TypeName for each supplement
            var query = from supplement in supplements
                        join type in supplementTypes
                        on supplement.SupplementTypeID equals type.SupplementTypeID
                        select new
                        {
                            SupplementID = supplement.SupplementID,
                            SupplementName = supplement.SupplementName,
                            SupplementPrice = supplement.SupplementPrice,
                            SupplementExpiryDate = supplement.SupplementExpiryDate,
                            TypeName = type.SupplementTypeName
                        };

            // Create a DataTable from the LINQ query
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
            new DataColumn("SupplementID", typeof(int)),
            new DataColumn("SupplementName", typeof(string)),
            new DataColumn("SupplementPrice", typeof(int)),
            new DataColumn("SupplementExpiryDate", typeof(DateTime)),
            new DataColumn("TypeName", typeof(string))
            });

            foreach (var item in query)
            {
                dt.Rows.Add(item.SupplementID, item.SupplementName, item.SupplementPrice, item.SupplementExpiryDate, item.TypeName);
            }

            // Bind the DataTable to the GridView
            GV_Supplement.DataSource = dt;
            GV_Supplement.DataBind();
            MsUser us = (MsUser)Session["user"];
            List<MsCart> cart = CartController.getAllCart(us.UserID);
            if (cart != null)
            {
                GV_Cart.DataSource = cart;
                Pnl_Cart.Visible = true;
                Btn_Clear.Visible = true;
                Btn_Orders.Visible = true;
                GV_Cart.DataBind();
            }
        }

        protected void GV_Supplement_SelectedIndexChanged(object sender, EventArgs e)
        {
            MsUser us = (MsUser)Session["user"];
            GridViewRow row = GV_Supplement.SelectedRow;
            int quantity;
            TextBox quantityTextBox = (TextBox)row.FindControl("TB_Quantity");
            if(quantityTextBox.Text == "")
            {
                quantity = 0;
            }
            else
            {
                quantity = Convert.ToInt32(quantityTextBox.Text);
            }

            int userId = us.UserID;
            int supplementId = Convert.ToInt32(row.Cells[0].Text);
            Lbl_Status.Text = CartController.createCart(userId, supplementId, quantity);
            Lbl_Status.ForeColor = System.Drawing.Color.Red;
            if(Lbl_Status.Text == "")
            {
                Response.Redirect("~/View/Customer/OrderSupplement.aspx");
            }

        }

        protected void Btn_Orders_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            TransactionController.createTransactionHeader(user.UserID, DateTime.Now, "unhandled");
            TransactionHeader th = TransactionController.getTransactionId();
            int transactionId = th.TransactionID;
            foreach (GridViewRow row in GV_Cart.Rows)
            {
                int supplementID = Convert.ToInt32(row.Cells[0].Text);
                int quantity = Convert.ToInt32(row.Cells[1].Text);
                TransactionController.createTransactionDetail(transactionId, supplementID, quantity);
            }
            CartController.deleteCart(user.UserID);
            Response.Redirect("~/View/Customer/OrderSupplement.aspx");
        }

        protected void Btn_Clear_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            CartController.deleteCart(user.UserID);
            Response.Redirect("~/View/Customer/OrderSupplement.aspx");
        }
    }
}