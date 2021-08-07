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
    public partial class ChooseCreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void select_Click(object sender, EventArgs e)
        {
            String connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                SqlCommand comm = new SqlCommand("ChooseCreditCard", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                comm.Parameters.AddWithValue("@creditcard", CCN.Text);
                comm.Parameters.AddWithValue("@orderid", OID.Text);
                try
                {
                    comm.ExecuteNonQuery();
                    Response.Write("please proceed to check out ");

                }
                catch
                {
                    Response.Write("Enter a valid Credit Card");
                }
            }

        }
    }
}