using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOGINSYSTEM
{
    public partial class MAINPAGE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (Session["User"]!= null)
            {
                txtuser.Text = "WELCOME  " + Session["User"].ToString();
           }
            else
            {
                Response.Redirect("LOGPAGE.aspx");
           }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("LOGPAGE.aspx");
        }
    }
}