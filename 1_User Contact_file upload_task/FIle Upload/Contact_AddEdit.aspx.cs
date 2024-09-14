using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlTypes;

namespace WebApplication1.FIle_Upload
{
    public partial class Contact_AddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                FillCheckBoxList();
            }
        }

        private void FillCheckBoxList ()
        {
            SqlConnection objConn = new SqlConnection();
            objConn.ConnectionString = "data source=DESKTOP-ELGAHLN;  initial catalog=MSTDATA;  Integrated Security=True;";

            try
            {
                objConn.Open ();
                //Read the Connection String from web.config file objConn.Open();
                SqlCommand objCmd = objConn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "Pr_ContactCategory_SelectForDropDownList";
                SqlDataReader objSDR = objCmd.ExecuteReader();
                if (objSDR.HasRows)
                {
                    cblContactCategory.DataTextField = "ContactCategoryName";
                    cblContactCategory. DataValueField = "ContactCategoryID";
                    cblContactCategory.DataSource = objSDR;
                    cblContactCategory.DataBind();
                }
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
                objConn.Close();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            String ContactPhotoPath = "";
            if (fuContactPhoto.HasFile)
            {

                ContactPhotoPath = "~/UserContent/" + fuContactPhoto.FileName.ToString().Trim();
                fuContactPhoto.SaveAs(Server.MapPath(ContactPhotoPath));
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

                //Out Parameter
                cmdObj.Parameters.Add("@ContactID", SqlDbType.Int, 4). Direction = ParameterDirection.Output; 
                //objCmd.Parameters["@ContactID"].Direction ParameterDirection.Output;

                cmdObj.ExecuteNonQuery();

                SqlInt32 ContactID = 0;
                ContactID = Convert.ToInt32(cmdObj.Parameters["@ContactID"].Value);

                //We need ContactID (PK) after insertion of the record
                foreach (ListItem liContactCategoryID in cblContactCategory.Items)
                {
                    if (liContactCategoryID.Selected)
                    {
                        SqlCommand objCmdContactCategory = Objconn.CreateCommand();
                        //objCmdContactCategory.CommandType = CommandType.StoredProcedure;
                        //objCmdContactCategory.CommandText = "Pr_ContactWiseCategory_Insert";
                        //objCmdContactCategory.Parameters.AddWithValue("ContactID", ContactID.ToString());
                        ////objCmdContactCategory.Parameters.AddWithValue("@ContactCategoryID", liContactCategoryID.Value.ToString());
                        ////objCmdContactCategory.ExecuteNonQuery();
                        ///SqlCommand objCmdContactCategory = Objconn.CreateCommand();
                        objCmdContactCategory.CommandType = CommandType.StoredProcedure;
                        objCmdContactCategory.CommandText = "Pr_ContactWiseCategory_Insert";

                        // Pass the correct ContactID (PK) from previous insert
                        objCmdContactCategory.Parameters.AddWithValue("@ContactID", ContactID);

                        // Pass the selected ContactCategoryID
                        objCmdContactCategory.Parameters.AddWithValue("@ContactCategoryID", liContactCategoryID.Value);

                        // Execute the insert command for each selected category
                        objCmdContactCategory.ExecuteNonQuery();
                    }
                }

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