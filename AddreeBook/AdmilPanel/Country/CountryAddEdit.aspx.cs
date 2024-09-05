using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.AddreeBook.AdmilPanel.Country
{
    public partial class CountryAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //Declare Local Varialble to Insert Data
            SqlString strCountryName = SqlString.Null;
            SqlString strCountryCode = SqlString.Null;
            SqlString strCountryCapital = SqlString.Null;

            if (txtCountryCode.Text.Trim() == "" || txtCountryName.Text.Trim() == "" || txtCountryCapital.Text.Trim() == "")
            {
                lblMsg.Text += "Enter Required Fields...";
                return;
            }

            //Establish Connection
            SqlConnection Objconn = new SqlConnection("data source=DESKTOP-ELGAHLN;  initial catalog=AddressBookData;  Integrated Security=True;");

            try
            {
                Objconn.Open();

                SqlCommand cmdObj = Objconn.CreateCommand();

                cmdObj.CommandType = CommandType.StoredProcedure;

                cmdObj.CommandText = "Pr_Country_Insert";

                strCountryName = txtCountryName.Text.Trim();
                strCountryCode = txtCountryCode.Text.Trim();
                strCountryCapital = txtCountryCapital.Text.Trim();

                cmdObj.Parameters.AddWithValue("@CountryName", strCountryName);
                cmdObj.Parameters.AddWithValue("@CountryCode", strCountryCode);
                cmdObj.Parameters.AddWithValue("@CapitalCity", strCountryCapital);

                cmdObj.ExecuteNonQuery();

            }
            catch (SqlException sqlEx)
            {
                Response.Write("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {

                Objconn.Close();
                lblMsg.Text = "Data Inserted Successfully...";

                txtCountryCode.Text = "";
                txtCountryName.Text = "";
                txtCountryCapital.Text = "";

                txtCountryCode.Focus();
            }
        }
    }
}