﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
     
    string cs = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
      
        using (SqlConnection sq = new SqlConnection(cs))
        {

            string s = (Session["user"].ToString()).Substring(0, 2);

            SqlCommand cmd = new SqlCommand("select * from notice where  (target like '%all' or target like'" + (Session["user"].ToString()).Substring(0,2)+"%') and expdate>=convert(varchar(11),getdate() )", sq);
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

            SqlCommand c = new SqlCommand("select * from issues where  (userid like'"+s+ "%' or target like'" + s + "%' or target like'All%')", sq);
            SqlDataReader r = c.ExecuteReader();
            if (!r.HasRows)
            {
            }
            else
            {
                while (r.Read())
                {
                    Dashboard.Controls.Add(new LiteralControl("<p style=\"color:maroon;font-size:medium\" >"+r["msg"].ToString() + " posted by -" + r["name"].ToString() + " (" + r["userid"].ToString() + ") on " + (r["date"].ToString()).Substring(0,10)+"</p>"));
                   
                }

            }
            rd.Close();
        }
    }

    
}