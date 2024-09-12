using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.EncryptDecryptDemo
{
    public partial class EncryptDecryptDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        protected void btnencrypt_Click(object sender, EventArgs e)
        {
            lblencrypt.Text = Base64Encode(txtencrypt.Text.ToString().Trim());
        }

        protected void btndcrypt_Click(object sender, EventArgs e)
        {
            //lbldecrypt.Text = Base64Decode(lblencrypt.Text.Trim());
            string input = txtdecrypt.Text.Trim();
            lbldecrypt.Text = Base64Decode(input);
        }
    }
}
