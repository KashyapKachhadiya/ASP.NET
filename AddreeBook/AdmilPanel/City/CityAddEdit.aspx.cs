using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlTypes;

namespace WebApplication1.AddreeBook.AdmilPanel.City
{
    public partial class CityAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillCountryDropDownList();
                FillStateDropDownList();
            }
        }

        private void FillCountryDropDownList()
        {
            SqlConnection connObj = new SqlConnection("data source=DESKTOP-ELGAHLN;  initial catalog=AddressBookData;  Integrated Security=True;");
            try
            {
                connObj.Open();

                SqlCommand cmdObj = connObj.CreateCommand();
                cmdObj.CommandType = CommandType.StoredProcedure;
                cmdObj.CommandText = "Pr_Country_SelectForDDL";
                SqlDataReader sdrObj = cmdObj.ExecuteReader();

                if (sdrObj.HasRows)
                {
                    ddlCountryID.DataSource = sdrObj;
                    ddlCountryID.DataValueField = "CountryID";
                    ddlCountryID.DataTextField = "CountryName";
                    ddlCountryID.DataBind();
                }
                ddlCountryID.Items.Insert(0, new ListItem("Select Country", "-1"));

            }
            catch (SqlException sqlEx)
            {
                Response.Write("Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                connObj.Close();
            }
        }

        private void FillStateDropDownList()
        {
            SqlConnection connObj = new SqlConnection("data source=DESKTOP-ELGAHLN;  initial catalog=AddressBookData;  Integrated Security=True;");
            try
            {
                connObj.Open();

                SqlCommand cmdObj = connObj.CreateCommand();
                cmdObj.CommandType = CommandType.StoredProcedure;
                cmdObj.CommandText = "Pr_State_SelectForDDL";
               // cmdObj.Parameters.AddWithValue("@CountryCode", str.ToString());
                SqlDataReader sdrObj = cmdObj.ExecuteReader();

                if (sdrObj.HasRows)
                {
                    ddlStateID.DataSource = sdrObj;
                    ddlStateID.DataValueField = "StateID";
                    ddlStateID.DataTextField = "StateName";
                    ddlStateID.DataBind();
                }
                ddlStateID.Items.Insert(0, new ListItem("Select State", "-1"));

            }
            catch (SqlException sqlEx)
            {
                Response.Write("Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                connObj.Close();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //Declare Local Varialble to Insert Data
            SqlInt32 strStateID = SqlInt32.Null;
            SqlString strCityName = SqlString.Null;
            SqlInt32 strCountryID = SqlInt32.Null;

            if (txtCityName.Text.Trim() == "" || ddlStateID.SelectedValue.Trim() == "" || ddlCountryID.SelectedValue.Trim()=="")
            {
                lblMsg.Text += "Enter Required Fields...";
                return;
            }


            if (ddlCountryID.SelectedValue == "-1")
            {
                lblMsg.Text += "Select Country...";
                return;
            }

            SqlConnection connObj = new SqlConnection("data source=DESKTOP-ELGAHLN;  initial catalog=AddressBookData;  Integrated Security=True;");

            try
            {
                connObj.Open();

                //SqlCommand cmdObj = new SqlCommand();
                //cmdObj.Connection = connObj;

                //---------OR-----------------

                SqlCommand cmdObj = connObj.CreateCommand();


                cmdObj.CommandType = CommandType.StoredProcedure;

                cmdObj.CommandText = "Pr_City_Insert";

                strCityName = txtCityName.Text.Trim();
                strStateID = Convert.ToInt32(ddlStateID.SelectedValue.Trim());
                strCountryID = Convert.ToInt32(ddlCountryID.SelectedValue.Trim());

                cmdObj.Parameters.AddWithValue("@CityName", strCityName);
                cmdObj.Parameters.AddWithValue("@StateID", strStateID);
                cmdObj.Parameters.AddWithValue("@CountryID", strCountryID);

                cmdObj.ExecuteNonQuery();

            }
            catch (SqlException sqlEx)
            {
                Response.Write("Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                connObj.Close();
                lblMsg.Text = "Data Inserted Successfully...";

                txtCityName.Text = "";

                txtCityName.Focus();
            }

           
        }

    }
}