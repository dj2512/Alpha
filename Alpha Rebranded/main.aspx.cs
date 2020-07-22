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
                if(rd.HasRows==false)
                {
                    Response.Write("<script>alert('User Not Found')</script>");

                }
                string st = rd["status"].ToString();
                if (st == "Verified")
                {
                    pass = rd["password"].ToString();
                    utype = rd["utype"].ToString();
                    dept = rd["dept"].ToString();
                }
                if (password.Text == pass)
                {
                    
                    Session["user"] = username.Text;
                    if (utype == "Faculty")
                    {
                        Response.Redirect("faculty.aspx");
                    }
                    if (utype == "depthead")
                    {
                        Server.Transfer("depthead.aspx");
                    }
                    if (utype == "Student")
                    {

                        Server.Transfer("student.aspx");
                    }
                    if (utype == "Library")
                    {
                        Server.Transfer("Library.aspx");
                    }
                    if (utype == "Admin")
                    {
                        Server.Transfer("Admin.aspx");
                    }

                }

                else
                {
                    Response.Write("<script>alert('Invalid username / password or user not verified')</script>");
                }
                sq.Close();
            }
        }
        catch(Exception ex)
        {
            Response.Write(""); 
        }
    }

   
}