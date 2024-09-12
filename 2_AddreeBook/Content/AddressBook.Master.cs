using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.AddreeBook.Content
{
    public partial class AddressBook : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("~/AddreeBook/Default.aspx", true);
            }

            if (!Page.IsPostBack)
            {
                if (Session["DisplayName"] != null)
                    lblUserName.Text = "Hi" + Session ["DisplayName"] + "!";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/AddreeBook/Default.aspx", true);
        }
    }
}