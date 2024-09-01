using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.TaskDropDownList
{
    public partial class Task_ListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void libCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in libCountry.Items)
            {
                if (li.Selected == true)
                {
                    lblMessage.Text += "<strong>" + li.Value.Trim() + " - " + li.Text.Trim() + "</strong><br />";
                }
                else
                {
                    lblMessage.Text += li.Value.Trim() + " - " + li.Text.Trim() + "<br />";
                }
            }
        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            string countryName = txtCountryName.Text;
            string countryCode = txtCountryCode.Text;

            if (!string.IsNullOrEmpty(countryName) && !string.IsNullOrEmpty(countryCode))
            {
                libCountry.Items.Add(new ListItem(countryName, countryCode));
            }
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            ListItem itemToRemove = libCountry.Items.FindByValue(txtCountryCode.Text);
            if (itemToRemove != null)
            {
                libCountry.Items.Remove(itemToRemove);
            }
        }

        protected void btnAddSelected_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in libCountry.Items)
            {
                if (li.Selected)
                {
                    libox2.Items.Add(li);
                }
            }

        }

        protected void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in libCountry.Items)
            {
                libox2.Items.Add(li);
            }
        }

        protected void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            List<ListItem> itemsToRemove = new List<ListItem>();

            foreach (ListItem li in libox2.Items)
            {
                if (li.Selected)
                {
                    itemsToRemove.Add(li);
                }
            }

            foreach (ListItem item in itemsToRemove)
            {
                libox2.Items.Remove(item);
            }

        }

        protected void btnRemoveAll_Click(object sender, EventArgs e)
        {
            List<ListItem> itemsToRemove = new List<ListItem>();

            foreach (ListItem li in libox2.Items)   
            {
                    itemsToRemove.Add(li);
            }

            foreach (ListItem item in itemsToRemove)
            {
                libox2.Items.Remove(item);
            }
        }

        protected void btnChangeValue_Click(object sender, EventArgs e)
        {
            //ListItem itemToChange = libCountry.Items.FindByValue(txtOldCname.Text);
            

            foreach(ListItem item in libCountry.Items)
            {
                if(item.Text == txtOldCname.Text)
                {
                    item.Text = txtNewCname.Text;
                    item.Value = txtNewCcode.Text;
                }
            }
            //for (int i = libCountry.Items.Count - 1; i >= 0; i--)
            //{
            //    if (libCountry.Items[i].Text == itemToChange.Text  && libCountry.Items[i].Value == itemToChange.Value)
            //    {
            //        libCountry.Items[i].Text = txtNewCname.Text;
            //        libCountry.Items[i].Value = txtNewCcode.Text;
            //    }
            //}

            lblcmsg.Text = "Value is Changed !!";
        }
    }
}