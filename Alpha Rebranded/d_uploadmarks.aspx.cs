using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void FileUpload1_DataBinding(object sender, EventArgs e)
    {
        

    }

    protected void fileuploadbtn_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string a = System.IO.Path.GetExtension(FileUpload1.FileName);
            if (a == ".xls" || a == ".xlsx")
            {

                string filename = Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/" + Session["user"].ToString() + "/Result/"+Session["user"].ToString().Substring(0,2)+"Result"+Year.SelectedValue+".xls"));
                 ScriptManager.RegisterStartupScript(Page, this.GetType(), "Key", string.Format("alert('{0}'); ", "File Uploaded Successfully."), true);
            }
            else
            {


                ScriptManager.RegisterStartupScript(Page, this.GetType(), "Key", string.Format("alert('{0}'); ", "Upload Failed. Expecting file format as .xls/.xlsx"), true);
            }
        }
    }

    protected void Label1_Click(object sender, EventArgs e)
    {
        Response.Redirect("vendor/Result_Struct.xls");
    }

    protected void downloadsh_Click(object sender, EventArgs e)
    {
       Response.Redirect(Server.MapPath("~/" + Session["user"].ToString() + "/Result/" + Session["user"].ToString().Substring(0, 2) + "Result" + Year.SelectedValue + ".xls"));

    }
}