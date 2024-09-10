using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.URLRoutingDemo.State
{
    public partial class StateAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                if (Page.RouteData.Values["OperationName"] != null)
                {
                    lblMessage.Text += Page.RouteData.Values["OperationName"].ToString().Trim();
                }
                if (Page.RouteData.Values["StateID"] != null)
                {
                    lblMessage.Text += "<br />StateID = " + Page.RouteData.Values["StateID"].ToString().Trim();
                }
            }
        }
    }
}