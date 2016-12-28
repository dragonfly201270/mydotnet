using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox2.Text) || String.IsNullOrEmpty(TextBox3.Text) || String.IsNullOrEmpty(TextBox4.Text) || String.IsNullOrEmpty(TextBox5.Text))
            {

                Label5.Text = "Data not filled";
            }
            else
            {
                string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                using(MySqlConnection connection = new MySqlConnection(conn))
                {
                using (MySqlCommand command = connection.CreateCommand())
                {
                command.CommandText = "Insert into Record(first_name,last_name,address,city) Values('" + TextBox2.Text + "','" + TextBox5.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
                connection.Open();
                command.ExecuteNonQuery();
                }
                }
               
            }
                  
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("default2.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("default3.aspx");
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {

        }
    }
}