using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.ResultCalc
{
    public partial class ResultCalc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btngetresult_Click(object sender, EventArgs e)
        {
            int sub1 = Convert.ToInt32(txtbox1.Text);
            int sub2 = Convert.ToInt32(txtbox2.Text);
            int sub3 = Convert.ToInt32(txtbox3.Text);
            int sub4 = Convert.ToInt32(txtbox4.Text);
            int sub5 = Convert.ToInt32(txtbox5.Text);

            float sum = ((sub1 + sub2 + sub3 + sub4 + sub5)/5);

            txtPercentage.Text = Convert.ToString(sum);

            if(sum >= 80)
            {
                txtClass.Text = "Distinction";
            }
            else if(sum >70 && sum <=79)
            {
                txtClass.Text = "FirstClass";
            }
            else if(sum >50 && sum <=69)
            {
                txtClass.Text = "Second Class";
            }
            else if(sum >33 && sum <=50)
            {
                txtClass.Text = "Pass";
            }
            else
            {
                txtClass.Text = "Fail";
            }
            
        }
    }
}