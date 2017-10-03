using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataTesting
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-893TL49\OAKENS;Initial Catalog=ThoraDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.MedarbejderDim('"+TextBox1+"', '"+TextBox2+"')";
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}