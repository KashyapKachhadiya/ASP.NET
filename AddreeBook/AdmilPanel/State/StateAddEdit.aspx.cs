using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.AddreeBook.AdmilPanel.State
{
    public partial class StateAddEdit : System.Web.UI.Page
    {
        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillDropDownList();
                if (Request.QueryString["StateID"] != null)
                {
                    FillControls(Request.QueryString["StateID"].ToString().Trim());
                }
            }
        }
        #endregion Page Load

        #region FillDropDownList
        private void FillDropDownList()
        {
            #region DataBaseConnection
            SqlConnection connObj = new SqlConnection();
            connObj.ConnectionString = ConfigurationManager.ConnectionStrings["AddressbookConnectionString"].ConnectionString;
            #endregion DataBaseConnection

            try
            {
                #region Connection And Command
                connObj.Open();

                SqlCommand cmdObj = connObj.CreateCommand();

                cmdObj.CommandType = CommandType.StoredProcedure;

                cmdObj.CommandText = "Pr_Country_SelectForDDL";

                #endregion Connection And Command

                #region Store Procedure, Execute, Data Read and Bind
                SqlDataReader sdrObj = cmdObj.ExecuteReader();

                if (sdrObj.HasRows)
                {
                    ddlCountryID.DataSource = sdrObj;
                    ddlCountryID.DataValueField = "CountryID";
                    ddlCountryID.DataTextField = "CountryName";
                    ddlCountryID.DataBind();
                }

                ddlCountryID.Items.Insert(0, new ListItem("Select Country", "-1"));
                #endregion Store Procedure, Execute, Data Read and Bind

                
            }
            #region Exception Handling
            catch (SqlException sqlEx)
            {
                Response.Write("Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            #endregion Exception Handling

            #region Close Connection
            finally
            {
                connObj.Close();
            }
            #endregion Close Connection

        }
        #endregion FillDropDownList

        #region FillControls
        private void FillControls(String StateID)
        {
            #region Establish Connection
            SqlConnection connObj = new SqlConnection(ConfigurationManager.ConnectionStrings["AddressbookConnectionString"].ConnectionString);
            #endregion Establish Connection

            try
            {
                #region Connection and Command Object

                if (connObj.State != ConnectionState.Open)
                {
                    connObj.Open();
                }

                SqlCommand cmdObj = connObj.CreateCommand();

                cmdObj.CommandType = CommandType.StoredProcedure;

                #endregion Connection and Command Object

                #region Store Procedure, Parameter and Execute 
                cmdObj.CommandText = "Pr_State_SelectByPK";

                cmdObj.Parameters.AddWithValue("@StateID", StateID);

                SqlDataReader sdrObj = cmdObj.ExecuteReader();
                #endregion Store Procedure, Parameter and Execute 

                #region Assign Value to Controls
                if (sdrObj.HasRows)
                {
                    while (sdrObj.Read())
                    {
                        if (!sdrObj["CountryID"].Equals(DBNull.Value))
                        {
                            ddlCountryID.SelectedValue = sdrObj["CountryID"].ToString();
                            ddlCountryID.Enabled = false;
                        }

                        if (!sdrObj["StateName"].Equals(DBNull.Value))
                        {
                            txtStateName.Text = sdrObj["StateName"].ToString();
                        }

                        
                        if (!sdrObj["StateCode"].Equals(DBNull.Value))
                        {
                            txtStateCode.Text = sdrObj["StateCode"].ToString();
                            
                        }

                        if (!sdrObj["StateCapital"].Equals(DBNull.Value))
                        {
                            txtStateCapital.Text = sdrObj["StateCapital"].ToString();
                        }



                        break;
                    }
                }
                #endregion Assign Value to Controls


            }
            #region Exception Handling
            catch (SqlException sqlEx)
            {
                Response.Write("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            #endregion Exception Handling

            #region Close Connection
            finally
            {
                if (connObj.State == ConnectionState.Open)
                {
                    connObj.Close();
                }
            }
            #endregion Close Connection
        }
        #endregion FillControls

        #region Button : Save
        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Declare Local Variables
            //Declare Local Varialble to Insert Data

            SqlString strStateID = SqlString.Null;
            SqlString strStateName = SqlString.Null;
            SqlString strStateCode = SqlString.Null;
            SqlInt32 strCountryID = SqlInt32.Null;
            SqlString strStateCapital = SqlString.Null;
            #endregion Declare Local Variables

            #region ServerSide Validation
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
            #endregion ServerSide Validation

            #region Establish Connection
            SqlConnection connObj = new SqlConnection();
            connObj.ConnectionString = ConfigurationManager.ConnectionStrings["AddressbookConnectionString"].ConnectionString;
            #endregion Establish Connection

            try
            {
                #region Connection and Command Objects
                connObj.Open();

                //SqlCommand cmdObj = new SqlCommand();
                //cmdObj.Connection = connObj;

                //---------OR-----------------

                SqlCommand cmdObj = connObj.CreateCommand();


                cmdObj.CommandType = CommandType.StoredProcedure;
                #endregion Connection and Command Objects


                strStateName = txtStateName.Text.Trim();
                strStateCode = txtStateCode.Text.Trim();
                strCountryID = Convert.ToInt32(ddlCountryID.SelectedValue.Trim());
                strStateCapital = txtStateCapital.Text.Trim();
                strStateID = Request.QueryString["StateID"].ToString().Trim();




                #region Add-Mode / Edit-Mode
                if (Request.QueryString["StateID"] != null)
                {
                    #region Edit Mode
                    #region Parameters
                    cmdObj.CommandText = "Pr_State_UpdateByPK";

                    cmdObj.Parameters.AddWithValue("@StateID", strStateID);
                    cmdObj.Parameters.AddWithValue("@StateName", strStateName);
                    cmdObj.Parameters.AddWithValue("@StateCode", strStateCode);
                    cmdObj.Parameters.AddWithValue("@CountryID", strCountryID);
                    cmdObj.Parameters.AddWithValue("@StateCapital", strStateCapital);
                    #endregion Parameters

                    cmdObj.ExecuteNonQuery();

                    Response.Redirect("~/AddreeBook/AdmilPanel/State/StateList.aspx");

                    #endregion Edit Mode
                }
                else
                {
                    #region Add Mode
                    cmdObj.CommandText = "Pr_State_Insert";

                    cmdObj.Parameters.AddWithValue("@StateName", strStateName);
                    cmdObj.Parameters.AddWithValue("@StateCode", strStateCode);
                    cmdObj.Parameters.AddWithValue("@CountryID", strCountryID);
                    cmdObj.Parameters.AddWithValue("@StateCapital", strStateCapital);

                    cmdObj.ExecuteNonQuery();

                    lblMsg.Text = "Data Inserted Successfully...";

                    txtStateCode.Text = "";
                    txtStateName.Text = "";
                    txtStateCapital.Text = "";

                    txtStateCode.Focus();
                    #endregion Add Mode
                }
                
                #endregion Add-Mode / Edit-Mode


            }
            #region Exception Handling
            catch (SqlException sqlEx)
            {
                Response.Write("Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            #endregion Exception Handling

            #region Close Connection
            finally
            {
                connObj.Close();
            }
            #endregion Close Connection
        }

        #endregion Button : Save

        #region Button : Cancle
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddreeBook/AdmilPanel/State/StateList.aspx");
        }
        #endregion Button : Cancle
    }
}