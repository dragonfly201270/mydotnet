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
    public partial class Default2 : System.Web.UI.Page
    {
        MySqlConnection sc;
        MySqlCommand cmd;
        MySqlDataReader dr;
        String con;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = ConfigurationManager.ConnectionStrings["conn"].ToString();
            sc = new MySqlConnection(con);


        }
        private MySqlDataReader bind(string query)
        {
            sc.Open();
            cmd = new MySqlCommand(query, sc);
            dr = cmd.ExecuteReader();



            return dr;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox1.Text))
            {
                GridView1.Visible = false;
                Label2.Visible = true;
                Label2.Text = "The Employee ID" + TextBox1.Text + " is invalid";

            }
            else
            {
                string query = "SELECT * FROM Record where Emp_ID like '" + TextBox1.Text + "%'";
                MySqlDataReader dr = bind(query);

                if (dr.HasRows)
                {
                    dr.Read();


                    GridView1.Visible = true;
                    TextBox1.Text = "";
                    Label2.Text = "";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    GridView1.DataSource = ds;
                    GridView1.DataBind();


                }

                else
                {
                    GridView1.Visible = false;
                    Label2.Visible = true;
                    Label2.Text = "The Employee ID : " + TextBox1.Text + " is invalid";
                }
            }



            sc.Close();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}