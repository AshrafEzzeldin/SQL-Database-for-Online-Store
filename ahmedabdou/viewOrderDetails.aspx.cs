using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ahmedabdou
{
    public partial class viewOrderDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            String connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand comm = new SqlCommand("displayTotlaAmmount1", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                //use session ya ashraf and delete the text box
                comm.Parameters.AddWithValue("@customername", (string)Session["field1"]);
                SqlDataReader rdr = comm.ExecuteReader();



                GridView1.DataSource = rdr;
                GridView1.DataBind();
                rdr.Close();

                comm.ExecuteNonQuery();
                conn.Close();

            }

        }
    }
}