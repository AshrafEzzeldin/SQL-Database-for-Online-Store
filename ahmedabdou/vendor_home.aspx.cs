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
    public partial class vendor_home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("showProducts", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd2 = new SqlCommand("vendorviewProducts", conn);
            cmd2.CommandType = CommandType.StoredProcedure;

            String ses = Session["field1"].ToString();

            cmd2.Parameters.Add(new SqlParameter("@vendorname", ses));

            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                showproducts.DataSource = reader;
                showproducts.DataBind();
            }
            using (SqlDataReader reader2 = cmd2.ExecuteReader())
            {
                ven_products.DataSource = reader2;
                ven_products.DataBind();
            }
            
            conn.Close();

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
                    taddress.Text = "The address is already exist in your address";
                    conn.Close();
                }

                Response.Redirect("vendor_home.aspx", true);
            }
        }

        protected void delete_product(object sender, EventArgs e)
        {

            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/


            // To read the input from the user
            string address = delete.Text;
            SqlCommand cmd = new SqlCommand("deleteProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            String ses = Session["field1"].ToString();

            cmd.Parameters.Add(new SqlParameter("@vendorname", ses));
            cmd.Parameters.Add(new SqlParameter("@serialnumber", address));

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("The product was deleted successfully");
                conn.Close();

            }
            catch
            {
                tphone.Text = "Please write valid serial number ";
                conn.Close();
            }

        }

        protected void update_product(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/


            // To read the input from the user
            string address = delete.Text;
            SqlCommand cmd = new SqlCommand("EditProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            String ses = Session["field1"].ToString();
            String name1 = TextBox1.Text;
            String c = TextBox2.Text;
            String p_d = TextBox3.Text;
            String Price = TextBox4.Text;
            String color1 = TextBox5.Text;

            cmd.Parameters.Add(new SqlParameter("@vendorUsername", ses));
            cmd.Parameters.Add(new SqlParameter("@product_name", name1));
            cmd.Parameters.Add(new SqlParameter("@category", c));
            cmd.Parameters.Add(new SqlParameter("@product_description", p_d));
            cmd.Parameters.Add(new SqlParameter("@price", Price));
            cmd.Parameters.Add(new SqlParameter("@color", color1));

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("The product was updated successfully");
                conn.Close();

            }
            catch
            {
                Response.Write("Please enter valid information \n" +
                    "1.  the field price must be numbers only  \n " +
                    "2.  other fields must not exceed 20 letter \n ") ;
                conn.Close();
            }
        }

        protected void create_offer(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/


            // To read the input from the user
            string o = offer.Text;
            string d = ex_date.Text;
            SqlCommand cmd = new SqlCommand("addOffer", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add(new SqlParameter("@offeramount", o));
            cmd.Parameters.Add(new SqlParameter("@expiry_date", d));

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("The Offer was created successfully");
                conn.Close();

            }
            catch
            {
                Response.Write("fields must not exceed 20 letter");
                conn.Close();
            }
        }

        protected void Apply_offer(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/


            // To read the input from the user
            string o = id.Text;
            string d = num.Text;
            String ses = Session["field1"].ToString();

            SqlCommand cmd = new SqlCommand("applyOffer", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add(new SqlParameter("@vendorname", ses));
            cmd.Parameters.Add(new SqlParameter("@offerid", o));
            cmd.Parameters.Add(new SqlParameter("@serial", d));

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("The offer has been applayed successfully");
                conn.Close();

            }
            catch
            {
                Response.Write("please enter a valid Fields");
                conn.Close();
            }
        }

        protected void remove(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/


            // To read the input from the user
            string o = off.Text;

            SqlCommand cmd = new SqlCommand("checkandremoveExpiredoffer", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add(new SqlParameter("@offerid", o));

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("successful operation");
                conn.Close();

            }
            catch
            {
                Response.Write("please enter a valid Offer ID");
                conn.Close();
            }
        }

        protected void post(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/


           

            SqlCommand cmd = new SqlCommand("postProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            String ses = Session["field1"].ToString();
            String n = TextBox1.Text;
            String c = TextBox2.Text;
            String p_d = TextBox3.Text;
            String color1 = TextBox4.Text;
            decimal Price = Convert.ToDecimal(TextBox5.Text);
           

            cmd.Parameters.Add(new SqlParameter("@vendorUsername", ses));
            cmd.Parameters.Add(new SqlParameter("@product_name", n));
            cmd.Parameters.Add(new SqlParameter("@category", c));
            cmd.Parameters.Add(new SqlParameter("@product_description", p_d));
            cmd.Parameters.Add(new SqlParameter("@price", Price));
            cmd.Parameters.Add(new SqlParameter("@color", color1));

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("The offer has been applayed successfully");
                conn.Close();
            }
            catch
            {
                 Response.Write("please enter a valid Fields");
                 conn.Close();
            }

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx", true);
        }
    }
}