﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBeta
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
   
        protected void Page_Load(object sender, EventArgs e)
        {
            gvCart.DataSource = Cart.Instance.Items;
            gvCart.DataBind();
            lblCartCount.Text = Cart.Instance.Items.Count.ToString();
      
         }
       public void gvCart_RowCommand(object sender, EventArgs e)
        {

        }
        public void gvCart_RowDataBound(object sender,GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[4].Text = $"Total: {Cart.Instance.GetSubTotal():C}";
            }
        }
        public void UpdateQuantity(object sender,GridViewCommandEventArgs e)
        {

        }

        protected void btnProceedToCheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConfirmationPage.aspx");
        }
    }
}