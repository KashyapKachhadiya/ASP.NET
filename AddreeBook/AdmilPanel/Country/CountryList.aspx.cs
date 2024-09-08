using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Security.AccessControl;

namespace WebApplication1.AddreeBook.AdmilPanel.Country
{
    public partial class CountryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillGridView();
            }

        }

        private void FillGridView()
        {
            // Step-1: Establish Connection--------------------------------------------------------------------------------------
            // SqlConnection Objconn = new SqlConnection();

            // Option 1: Using Windows Authentication
            //  Objconn.ConnectionString = "data source=DESKTOP-ELGAHLN;  initial catalog=AddressBookData;  Integrated Security=True;";

            // Option 2: Using SQL Server Authentication
            // connObj.ConnectionString = "data source=AMAN;initial catalog=AddressBook;Integrated Security=False;User ID=yourUsername;Password=yourPassword;";

            SqlConnection Objconn = new SqlConnection();
            Objconn.ConnectionString = ConfigurationManager.ConnectionStrings["AddressbookConnectionString"].ConnectionString;

            try
            {
                //Open the Connection
                Objconn.Open();


                //Step-2 : Do Your Work--------------------------------------------------------------------------------------


                //Prepare the Command Object
                SqlCommand cmdObj = new SqlCommand();

                //Map command Object with Connection Object
                cmdObj.Connection = Objconn;

                //Define Command Type
                cmdObj.CommandType = CommandType.StoredProcedure;
                //cmdObj.CommandType = CommandType.TableDirect;
                //cmdObj.CommandType = CommandType.Text;

                //Write Query / Store Procedure
                cmdObj.CommandText = "Pr_Country_SelectAll";

                //Step-3 : Read and Display Data--------------------------------------------------------------------------------------

                //cmdObj.ExecuteReader(); //Selet Queries
                //cmdObj.ExecuteNonQuery(); //Insert/Update/Delete
                //cmdObj.ExecuteScalar(); //Only one Scalar Value is return
                //cmdObj.ExecuteXmlReader(); //XML Format Data

                // Define which Command to Read
                SqlDataReader sdrObj = cmdObj.ExecuteReader();

                // Define where to Display Data
                gvCountry.DataSource = sdrObj;
                gvCountry.DataBind();
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
                // Close the Connection
                Objconn.Close();
            }
        }

        protected void gvCountry_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteRecord")
            {
                if (e.CommandArgument.ToString().Trim() != "")
                {
                    DeleteCountryRecord(e.CommandArgument.ToString().Trim());
                }
            }
        }

        private void DeleteCountryRecord(string CountryID)
        {
            SqlConnection Objconn = new SqlConnection();
            Objconn.ConnectionString = ConfigurationManager.ConnectionStrings["AddressbookConnectionString"].ConnectionString;

            try
            {
                // Open the connection
                Objconn.Open();

                // Create and set up the command object
                SqlCommand cmdObj = new SqlCommand();
                cmdObj.Connection = Objconn; // Assign the connection to the command object
                cmdObj.CommandType = CommandType.StoredProcedure;
                cmdObj.CommandText = "Pr_Country_DeleteByPK";

                // Add parameters for the stored procedure
                cmdObj.Parameters.AddWithValue("@CountryID", CountryID);

                // Execute the command
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
                // Ensure the connection is closed
                Objconn.Close();
                FillGridView();
            }
        }
    }
}
