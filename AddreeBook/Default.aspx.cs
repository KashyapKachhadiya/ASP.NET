using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.AddreeBook
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Validate uiser Ordered Parallel Query not Validate User
            //UserName, Password

            #region Local Variable
            SqlString strUserName = SqlString.Null;
            SqlString strPassword = SqlString.Null;
            #endregion Local Variable

            #region Server Side Validation
            String strErrorMessage = "";
            if (txtUserNameLogin.Text.Trim() == "")
            {
                strErrorMessage += "- Enter UserName <br />";
            }
            if (txtPasswordLogin.Text.Trim() == "")
            {
                strErrorMessage += ". Enter Password <br />";
            }
            if (strErrorMessage != "")
            {
                lblmsg.Text = "Kindly solve following Error(s) <br />" + strErrorMessage;
                return;
            }
            #endregion Server Side Validation

            #region Assign the Value
            if (txtUserNameLogin.Text.Trim() != "")
                strUserName = txtUserNameLogin.Text.Trim();
            if (txtPasswordLogin.Text.Trim() != "")
                strPassword = txtPasswordLogin.Text.Trim();
            #endregion Assign the Value

            SqlConnection objConn = new SqlConnection();
            objConn.ConnectionString = ConfigurationManager.ConnectionStrings["AddressbookConnectionString"].ConnectionString;

            try
            {
                if (objConn.State != ConnectionState.Open) objConn.Open();
                SqlCommand objCmd = objConn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "Pr_User_SelectByUserNameandPassword";
                
                objCmd.Parameters.AddWithValue("@UserName", strUserName.ToString().Trim()); 
                objCmd.Parameters.AddWithValue("@Password", strPassword.ToString().Trim());

                SqlDataReader objSDR = objCmd.ExecuteReader();
                if (objSDR.HasRows)
                {
                    //Valid User
                    lblmsg.Text = "Valid User";
                    while (objSDR.Read())
                    {
                        if (!objSDR["UserID"].Equals(DBNull.Value))
                        {
                            Session["UserID"] = objSDR["UserID"].ToString().Trim();
                        }
                        if (!objSDR["DisplayName"].Equals(DBNull.Value))
                        {
                            Session["DisplayName"] = objSDR["DisplayName"].ToString().Trim();
                        }
                        break;
                    }
                    Response.Redirect("~/AddreeBook/AdmilPanel/Home.aspx", true);
                }
                else
                {
                    lblmsg.Text = "Either Username or password is not valid. Try again !!";
                }

                if (objConn.State != ConnectionState.Closed)
                    objConn.Close();
            }
            catch (Exception ex)
            {
                lblmsg.Text = ex.Message;
            }
        }
    }
}