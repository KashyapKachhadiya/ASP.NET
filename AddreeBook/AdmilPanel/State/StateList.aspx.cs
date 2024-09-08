using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlTypes;

namespace WebApplication1.AddreeBook.AdmilPanel.State
{
    public partial class StateList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGridView();
            }


        }

        protected void gvState_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteRecord")
            {
                if (!string.IsNullOrEmpty(e.CommandArgument.ToString().Trim()))
                {
                    DeleteState(Convert.ToInt32(e.CommandArgument.ToString().Trim()));
                }
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

                cmdObj.CommandText = "Pr_State_SelectAll";

                SqlDataReader sdrObj = cmdObj.ExecuteReader();
                gvState.DataSource = sdrObj;
                gvState.DataBind();
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

        private void DeleteState (SqlInt32 StateID)
        {
            // Initialize connection object
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
                cmdObj.CommandText = "Pr_State_DeleteByPK";

                // Add parameters for the stored procedure
                cmdObj.Parameters.AddWithValue("@StateID", StateID);

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
            }

            // Refresh the grid view
            FillGridView();
        }
    }
}