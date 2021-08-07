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
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addphone(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            

            // To read the input from the user
            string p_num = tphone.Text;
            Int32 x = 0;
            for(int i = 0; i < p_num.Length; i++)
            {

            }
            if (p_num.Equals(""))
            {
                tphone.Text = "Please enter a phone here";
            }
            else if (!Int32.TryParse(p_num,out x))
            {
                tphone.Text = "you are only allowed to enter a number";
            }
            else
            {
                Int32.TryParse(p_num, out x);
                SqlCommand cmd = new SqlCommand("addMobile", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                String ses = Session["field1"].ToString() ;

                cmd.Parameters.Add(new SqlParameter("@username", ses));
                cmd.Parameters.Add(new SqlParameter("@mobile_number", p_num));

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    Response.Write("phone number is added successfully");
                    conn.Close();

                }
                catch
                {
                    tphone.Text = "The number is already exist in your phones";
                    conn.Close();
                }
                
            }

        }

        protected void add_address(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/


            // To read the input from the user
            string address = taddress.Text;

            if (address.Equals(""))
            {
                taddress.Text = "Please enter the address here";
            }
            else
            {
                SqlCommand cmd = new SqlCommand("addAddress", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                String ses = Session["field1"].ToString();

                cmd.Parameters.Add(new SqlParameter("@username", ses));
                cmd.Parameters.Add(new SqlParameter("@address", address));

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    Response.Write("the address is added successfully");
                    conn.Close();

                }
                catch
                {
                    tphone.Text = "The address is already exist in your address";
                    conn.Close();
                }
            }
        }
    }
}