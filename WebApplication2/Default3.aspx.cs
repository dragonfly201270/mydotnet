using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!this.IsPostBack)
            //{
            //    string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            //    using (MySqlConnection con = new MySqlConnection(conn))
            //    {
            //        using (MySqlCommand cmd = new MySqlCommand("select * FROM record"))
            //        {
            //            using (MySqlDataAdapter sda = new MySqlDataAdapter())
            //            {
            //                cmd.Connection = con;
            //                sda.SelectCommand = cmd;
            //                using (DataTable dt = new DataTable())
            //                {
            //                    sda.Fill(dt);
            //                    GridView1.DataSource = dt;
            //                    GridView1.DataBind();
            //                }
            //            }
            //        }
            //    }
            //}

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        

    }

}