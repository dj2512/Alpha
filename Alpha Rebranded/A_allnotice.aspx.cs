using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            using (SqlConnection sq = new SqlConnection(ConfigurationManager.ConnectionStrings["DBC"].ConnectionString))
            {

              
                SqlCommand cmd = new SqlCommand("select * from notice ", sq);
                sq.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (!rd.HasRows)
                {
                }
                else
                {
                    while (rd.Read())
                    {
                        Dashboard.Controls.Add(new LiteralControl(rd["msg"].ToString() + " posted by -" + rd["sender"].ToString() + " (" + rd["userid"].ToString() + ") on " + rd["date"].ToString()));
                        Dashboard.Controls.Add(new LiteralControl("</br></br>"));


                    }

                }
                rd.Close();
            }
        }
        catch (Exception ex)
        {

        }
    }
}