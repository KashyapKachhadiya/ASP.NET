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

namespace WebApplication1.AddreeBook.AdmilPanel.State
{
    public partial class StateAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillDropDownList();
            }
        }

        private void FillDropDownList()
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

                connObj.Close();
            }
            catch (SqlException sqlEx)
            {
                Response.Write("Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //Declare Local Varialble to Insert Data
            
            SqlString strStateName = SqlString.Null;
            SqlString strStateCode = SqlString.Null;
            SqlInt32 strCountryID = SqlInt32.Null;
            SqlString strStateCapital = SqlString.Null;

            if (ddlCountryID.SelectedValue == "-1")
            {
                lblMsg.Text += "Select Country...";
                return;
            }

            if ( txtStateCode.Text.Trim() == "" || txtStateName.Text.Trim() == "" || txtStateCapital.Text.Trim() == "" || ddlCountryID.SelectedValue.Trim() == ""
            )
            {
                lblMsg.Text += "Enter Required Fields...";
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

                cmdObj.CommandText = "Pr_State_Insert";

                strStateName = txtStateName.Text.Trim();
                strStateCode = txtStateCode.Text.Trim();
                strCountryID = Convert.ToInt32(ddlCountryID.SelectedValue.Trim());
                strStateCapital = txtStateCapital.Text.Trim();
                

                
                cmdObj.Parameters.AddWithValue("@StateName", strStateName);
                cmdObj.Parameters.AddWithValue("@StateCode", strStateCode);
                cmdObj.Parameters.AddWithValue("@CountryID", strCountryID);
                cmdObj.Parameters.AddWithValue("@StateCapital", strStateCapital);
                

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

                txtStateCode.Text = "";
                txtStateName.Text = "";
                txtStateCapital.Text = "";

                txtStateCode.Focus();
            }
        }
    }
}