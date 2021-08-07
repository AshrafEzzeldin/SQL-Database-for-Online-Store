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
    public partial class ChoosePaymentMethod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CasheT_Click(object sender, EventArgs e)
        {
            String connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                SqlCommand comm = new SqlCommand("SpecifyAmount", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                // use session ya ASHRAF and delete the text box 
                comm.Parameters.AddWithValue("@customername", (string)Session["field1"]);
                comm.Parameters.AddWithValue("@orderID", TB2.Text);
                comm.Parameters.AddWithValue("@cash", CshP.Text);
                comm.Parameters.AddWithValue("@credit", Points.Text);

                try
                {
                    comm.ExecuteNonQuery();
                    Response.Write("Payment done  Please Proceed to check out");


                }
                catch
                {
                    Response.Write("choose cahs or credit only  ");

                }



                conn.Close();


            }
        }
    }
}