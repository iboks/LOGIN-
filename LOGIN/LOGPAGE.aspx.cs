using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUSLAY;

namespace LOGINSYSTEM
{
    public partial class LOGPAGE : System.Web.UI.Page
    {
       
        public operations opr = new operations();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            opr.USERNAME = txtUsername.Text;
            opr.PASSWORD = txtPassword.Text;

            if (opr.getUser())
            {
                Session["User"] = opr.USERNAME;
                Response.Redirect("MAINPAGE.aspx");
            }
            else
            {
                Label1.Visible = true;
            }

        }
    }
}