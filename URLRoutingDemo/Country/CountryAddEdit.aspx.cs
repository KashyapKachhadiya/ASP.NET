using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.URLRoutingDemo.Country
{
    public partial class CountryAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Page.RouteData.Values["OperationName"] != null)
                {
                    lblMessage.Text += Page.RouteData.Values["OperationName"].ToString().Trim();
                }
                if (Page.RouteData.Values["CountryID"] != null)
                {
                    lblMessage.Text += "<br />CountryID = " + Page.RouteData.Values["CountryID"].ToString().Trim();
                }
            }
        }
    }
}