using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.FIle_Upload
{
    public partial class File_UplodDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            // Check for selection file
            if(fuFile.HasFile)
            {
                //lblMsg.Text = "File Selected !" + fuFile.FileName.ToString().Trim();
                String FolderPath = "~/UserContent/";
                String AbsolutePath = Server.MapPath(FolderPath);

                if(!Directory.Exists(AbsolutePath))
                {
                    Directory.CreateDirectory(AbsolutePath);
                }

                lblMsg.Text = AbsolutePath.ToString();
                fuFile.SaveAs(AbsolutePath + fuFile.FileName.ToString().Trim());
            }
            else
            {
                lblMsg.Text = "File NOT Selected."; 
            }
        }

        protected void btnDeleteFile_Click(object sender, EventArgs e)
        {
            String FolderPath = "~/UserContent/chinese-house-night-moon-scenery-digital-art-4k-wallpaper-uhdpaper.com-837@1@m.jpg";
            FileInfo file = new FileInfo(FolderPath);

            if(file.Exists)
            {
                file.Delete();
            }
            else
            {
                lblMsg.Text = "File does not Exist.";
            }
        }
    }
}