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
    public partial class admin : System.Web.UI.Page
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
            for (int i = 0; i < p_num.Length; i++)
            {

            }
            if (p_num.Equals(""))
            {
                tphone.Text = "Please enter a phone here";
            }
            else if (!Int32.TryParse(p_num, out x))
            {
                tphone.Text = "you are only allowed to enter a number";
            }
            else
            {
                Int32.TryParse(p_num, out x);
                SqlCommand cmd = new SqlCommand("addMobile", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                String ses = Session["field1"].ToString();

                cmd.Parameters.Add(new SqlParameter("@username", ses));
                cmd.Parameters.Add(new SqlParameter("@mobile_number", p_num));

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    Label1.Text="phone number is added successfully";
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
                    Label1.Text = "the address is added successfully";
                    conn.Close();

                }
                catch
                {
                    taddress.Text = "The address is already exist in your address";
                    conn.Close();
                }
            }
        }

        protected void active(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString() + "MultipleActiveResultSets=True";

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            //SqlConnection conn1 = new SqlConnection(connStr);

            SqlCommand cmd2 = new SqlCommand("activateVendors", conn);
            cmd2.CommandType = CommandType.StoredProcedure;
            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/

            // To read the input from the user
            string user = (string)Session["field1"];

            SqlCommand cmd1 = new SqlCommand("unactivated", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            //conn1.Open();


            conn.Open();
            //IF the output is a table, then we can read the records one at a time
            SqlDataReader rdr = cmd1.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {
                //Get the value of the attribute field in the Company table
                string venuser = rdr.GetString(rdr.GetOrdinal("username"));

                // pass parameters to the stored procedure
                cmd2.Parameters.Add(new SqlParameter("@admin_username", user));
                cmd2.Parameters.Add(new SqlParameter("@vendor_username", venuser));

                cmd2.ExecuteNonQuery();

            }
            Label1.Text = "successful process";
            conn.Close();

        }

        protected void orders(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            //create a new connection

            using (SqlConnection conn = new SqlConnection(connStr))

            {
                SqlCommand cmd = new SqlCommand("reviewOrders", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    grid.DataSource = reader;
                    grid.DataBind();
                }
                //SqlConnection conn1 = new SqlConnection(connStr);
                conn.Close();

            }
        }

        protected void delete(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            //SqlConnection conn1 = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("removeExpiredDeal", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            string id = txt_deal.Text;

            // pass parameters to the stored procedure
            if (id.Equals(""))
            {
                Label1.Text = "please add a deal";
            }
            else
            {

                try
                {
                    cmd.Parameters.Add(new SqlParameter("@deal_iD", id));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Label1.Text = "process done successfully";
                }
                catch
                {
                    Label1.Text = "Error the deal id must be integer or there is not exist this id";
                }
            }


        }

        protected void addDeal(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            //SqlConnection conn1 = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("addTodaysDealOnProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd1 = new SqlCommand("checkTodaysDealOnProduct", conn);
            cmd1.CommandType = CommandType.StoredProcedure;

            string deal_id = txt_dealid.Text;
            string prod = txt_serial.Text;

            if (deal_id.Equals(""))
            {
                Label1.Text = "please add a deal";
            }
            else
            if (prod.Equals(""))
            {
                Label1.Text = "please add a product";
            }
            else
            {
                try
                {
                    cmd1.Parameters.Add(new SqlParameter("@serial_no", prod));
                    SqlParameter activede = cmd1.Parameters.Add("@activeDeal", SqlDbType.Int);
                    activede.Direction = ParameterDirection.Output;

                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    if (activede.Value.ToString().Equals("0"))
                    {
                        cmd.Parameters.Add(new SqlParameter("@serial_no", prod));
                        cmd.Parameters.Add(new SqlParameter("@deal_id", deal_id));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        Label1.Text = "the deal has been added successfully";
                    }
                    else
                    {
                        Label1.Text = "there is already a deal on this product";
                    }
                }
                catch
                {
                    Label1.Text = "Error the deal id and the serial number must be integer or there is not exist this id or this serial number";
                }
            }

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx", true);
        }
    }

}