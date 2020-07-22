using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class main : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;
    // create trigger for every day morning that will delete existing records like existing class ,engagged faculty temp tables etc.
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        try
        {
            string pass = null, utype = null, dept = null;
            using (SqlConnection sq = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select password,utype,dept,status from auth where username ='" + username.Text + "' or mail='" + username.Text + "'", sq);
                sq.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (!rd.HasRows)
                {
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "Key", string.Format("alert('{0}'); ", "Invalid username / password or user not verified"), true);

                }
                string st = rd["status"].ToString();
                if (st == "Verified")
                {
                    pass = rd["password"].ToString();
                    utype = rd["utype"].ToString();
                    dept = rd["dept"].ToString();

                    if (password.Text == pass)
                    {

                        Session["user"] = username.Text;
                        if (utype == "Faculty")
                        {
                            Response.Redirect("faculty.aspx");
                        }
                        else if (utype == "depthead")
                        {
                            Server.Transfer("depthead.aspx");
                        }
                        else if (utype == "Student")
                        {

                            Server.Transfer("student.aspx");
                        }
                        else if (utype == "Library")
                        {
                            Server.Transfer("Library.aspx");
                        }
                        else if (utype == "Admin")
                        {
                            Server.Transfer("Admin.aspx");
                        }

                    }
                }


                sq.Close();
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(Page, this.GetType(), "Key", string.Format("alert('{0}'); ", ex), true);
        }
    }


}