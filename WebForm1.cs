using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace SP1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string constr = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_insertintoregister";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = TextBox1.Text.Trim();
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = TextBox2.Text.Trim();
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = TextBox3.Text.Trim();
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = TextBox4.Text.Trim();
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = TextBox5.Text.Trim();
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = TextBox6.Text.Trim();
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            Label1.Text = "Data inserted Successfully";

        }

    }
}
