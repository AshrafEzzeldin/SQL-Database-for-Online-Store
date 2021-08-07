using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;



namespace ahmedabdou
{


    public partial class Ordering : System.Web.UI.Page
    {


        protected void make_order(object sender, EventArgs e)
        {
            String connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                SqlCommand comm = new SqlCommand("makeOrder", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                //use session ya ashraf and delete the text box
                comm.Parameters.AddWithValue("@customername", (string)Session["field1"]);


                try
                {
                    comm.ExecuteNonQuery();
                    Response.Write("view the total amount and order id to be to proceed with the order please ");


                }
                catch
                {
                    Response.Write("There are no Items Inside The cart ");

                }



                conn.Close();


            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}