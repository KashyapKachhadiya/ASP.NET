using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.ServeraControlsDemo
{
    public partial class CheckBoxDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            if (chkCricket.Checked == true)
                lblMessage.Text += "Cricket";
            if (chkDancing.Checked == true)
                lblMessage.Text += "Dancing";
            if (chkReading.Checked) 
                lblMessage.Text += "Reading";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rbtnMale.Checked == true)
            {
                lblMsg.Text = "Male";
            }
            else if (rbtnFemale.Checked)
            {
                lblMsg.Text = "Female";
            }
            else
            { 
                lblMsg.Text = "Kindly Select Gender";
            }
        }
    }
}