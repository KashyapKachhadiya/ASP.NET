using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.TaskDropDownList
{
    public partial class Demo_DropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(Page.IsPostBack==false)
            //if(!Page.IsPostBack)
            //{
            //    ddlCountry.Items.Add(new ListItem("Bhutan", "98"));
            //    ddlCountry.Items.Add(new ListItem("Pakistan", "99"));
            //    ddlCountry.Items.Add(new ListItem("Tibate", "100"));
            //}

            //ddlCountry.Items.Add("India");

            //ListItem liIndia = new ListItem();
            //liIndia.Text = "India";
            //liIndia.Value = "91";

            //ddlCountry.Items.Add(liIndia);

            //ddlCountry.Items.Add(new ListItem("China", "92"));
        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lblMessage.Text = ddlCountry.SelectedValue;
            //lblMessage. Text ddlCountry.SelectedItem.Text;
            ////lblMessage.Text = ddlCountry.SelectedIndex. ToString().Trim();
            //lblMessage.Text = ddlCountry.SelectedIndex.ToString().Trim() + " - " + dd1Country.SelectedValue.Trim() + " " + dd1Country.SelectedItem.Text.Trim();
            
            foreach (ListItem li in ddlCountry.Items)
            {
                if (li.Selected == true)
                {
                    lblMessage.Text += "<strong>" + li.Value.Trim() + " " + li.Text.Trim() + "</strong><br />";
                }
                else
                {
                    lblMessage.Text += li.Value.Trim() + "-" + li.Text.Trim() + "<br />";
                }
            }

        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            string countryName = txtCountryName.Text;
            string countryCode = txtCountryCode.Text;

            if (!string.IsNullOrEmpty(countryName) && !string.IsNullOrEmpty(countryCode))
            {
                ddlCountry.Items.Add(new ListItem(countryName, countryCode));
            }

            //ddlCountry.Items.Add(new ListItem(txtCountryName.Text, txtCountryCode.Text));
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            ListItem itemToRemove = ddlCountry.Items.FindByValue(txtCountryCode.Text);
            if (itemToRemove != null)
            {
                ddlCountry.Items.Remove(itemToRemove);
            }
            //ddlCountry.Items.Remove(txtCountryName.Text);
        }

    }
}