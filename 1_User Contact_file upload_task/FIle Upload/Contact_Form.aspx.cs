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

namespace WebApplication1.FIle_Upload
{
    public partial class Contact_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            String ContactPhotoPath = "";
            if (fuContactPhotoPath.HasFile)
            {

                ContactPhotoPath = "~/UserContent/" + fuContactPhotoPath.FileName.ToString().Trim();
                fuContactPhotoPath.SaveAs(Server.MapPath(ContactPhotoPath));
            }

            SqlConnection Objconn = new SqlConnection();
            Objconn.ConnectionString = "data source=DESKTOP-ELGAHLN;  initial catalog=MSTDATA;  Integrated Security=True;";
            try
            {
                Objconn.Open();

                SqlCommand cmdObj = Objconn.CreateCommand();

                cmdObj.CommandType = CommandType.StoredProcedure;

                cmdObj.CommandText = "Pr_Contact_Insert";
            

                cmdObj.Parameters.AddWithValue("@ContactName", txtContactName.Text.Trim());
                cmdObj.Parameters.AddWithValue("@ContactPhotoPath", ContactPhotoPath);

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
                lblMsg.Text = "Uploaded Successfully...";

                txtContactName.Text = "";

                txtContactName.Focus();
            }
        }
    }
}