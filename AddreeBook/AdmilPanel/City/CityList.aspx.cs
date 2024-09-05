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
            SqlConnection Objconn = new SqlConnection();

            Objconn.ConnectionString = "data source=DESKTOP-ELGAHLN;  initial catalog=AddressBookData;  Integrated Security=True;";

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
    }
}