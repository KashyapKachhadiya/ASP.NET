using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.AddreeBook.AdmilPanel.City
{
    public partial class CityList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FillGridView();
            }

        }

        private void FillGridView()
        {
            SqlConnection Objconn = new SqlConnection();
            Objconn.ConnectionString = ConfigurationManager.ConnectionStrings["AddressbookConnectionString"].ConnectionString;
            try
            {
                Objconn.Open();

                SqlCommand cmdObj = new SqlCommand();


                cmdObj.Connection = Objconn;

                cmdObj.CommandType = CommandType.StoredProcedure;

                cmdObj.CommandText = "Pr_City_SelectAll";

                SqlDataReader sdrObj = cmdObj.ExecuteReader();

                gvCity.DataSource = sdrObj;
                gvCity.DataBind();
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
            }
        }

        protected void gvCountry_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteRecord")
            {
                if (e.CommandArgument.ToString().Trim() != "")
                {
                    DeleteCityRecord(e.CommandArgument.ToString().Trim());
                }
            }
        }

        private void DeleteCityRecord (string CityID)
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
                cmdObj.CommandText = "Pr_City_DeleteByPK";

                // Add parameters for the stored procedure
                cmdObj.Parameters.AddWithValue("@CityID", CityID);

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