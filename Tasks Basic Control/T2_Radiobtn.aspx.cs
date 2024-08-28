using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Tasks_Basic_Control
{
    public partial class T2_Radiobtn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            if (rbtnDEPSTAR.Checked)
            {
                lblTest.Text = "DEPSTAR Selected";
                rbtnBranch1.Text = "DCE";
                rbtnBranch2.Text = "DCSE";
                rbtnBranch3.Text = "DIT";
                rbtnBranch1.Visible = true;
                rbtnBranch2.Visible = true;
                rbtnBranch3.Visible = true;
            }
            if (rbtnCSPIT.Checked)
            {
                lblTest.Text = "CSPIT Selected";
                rbtnBranch1.Text = "CE";
                rbtnBranch2.Text = "CSE";
                rbtnBranch3.Text = "IT";
                rbtnBranch1.Visible = true;
                rbtnBranch2.Visible = true;
                rbtnBranch3.Visible = true;
            }
        }
    }
}