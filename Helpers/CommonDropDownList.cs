using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication1.Helpers
{
    public static class CommonDropDownList
    {
        #region FillDropDownList | Country
        public static void FillCountryDropDownList(DropDownList ddl)
        {
            SqlConnection connObj = new SqlConnection();
            connObj.ConnectionString = ConfigurationManager.ConnectionStrings["AddressbookConnectionString"].ConnectionString; try
            {
                connObj.Open();

                SqlCommand cmdObj = connObj.CreateCommand();
                cmdObj.CommandType = CommandType.StoredProcedure;
                cmdObj.CommandText = "Pr_Country_SelectForDDL";
                SqlDataReader sdrObj = cmdObj.ExecuteReader();

                if (sdrObj.HasRows)
                {
                    ddl.DataSource = sdrObj;
                    ddl.DataValueField = "CountryID";
                    ddl.DataTextField = "CountryName";
                    ddl.DataBind();
                }
                ddl.Items.Insert(0, new ListItem("Select Country", "-1"));

            }
            catch (Exception ex)
            {
                throw new Exception("Error while loading countries: " + ex.Message);
                //Response.Write("Error: " + ex.Message);
            }
            finally
            {
                connObj.Close();
            }
        }
        #endregion FillDropDownList | Country

        #region FillDropDownList | State
        public static void FillStateDropDownList(DropDownList ddl)
        {
            SqlConnection connObj = new SqlConnection();
            connObj.ConnectionString = ConfigurationManager.ConnectionStrings["AddressbookConnectionString"].ConnectionString; try
            {
                connObj.Open();

                SqlCommand cmdObj = connObj.CreateCommand();
                cmdObj.CommandType = CommandType.StoredProcedure;
                cmdObj.CommandText = "Pr_State_SelectForDDL";
                // cmdObj.Parameters.AddWithValue("@CountryCode", str.ToString());
                SqlDataReader sdrObj = cmdObj.ExecuteReader();

                if (sdrObj.HasRows)
                {
                    ddl.DataSource = sdrObj;
                    ddl.DataValueField = "StateID";
                    ddl.DataTextField = "StateName";
                    ddl.DataBind();
                }
                ddl.Items.Insert(0, new ListItem("Select State", "-1"));

            }
            catch (Exception ex)
            {
                throw new Exception("Error while loading countries: " + ex.Message);
                //Response.Write("Error: " + ex.Message);
            }
            finally
            {
                connObj.Close();
            }
        }
        #endregion FillDropDownList | State

    }
}