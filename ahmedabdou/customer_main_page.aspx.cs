using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace project
{
    public partial class customer_main_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }
        protected void button_Add_wishlist(object sender, EventArgs e)
        {
            //delete this -----------
            //------------------------
            string name = wishlist_name.Text;

            string CS = ConfigurationManager.ConnectionStrings["Projectfinal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("createWishlist", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customername", (string)Session["field1"]);
                cmd.Parameters.AddWithValue("@name", name);
                try
                {

                    con.Open();
                    //مكان الusername حط بتاع ال session
                    //--------------------متنساش تحزف ال html بتاع الجزء ده -------
                    cmd.ExecuteNonQuery();
                    con.Close();
                    error.Text = "wishlist :" + name + " added";
                }
                catch
                {
                    error.Text = "this wishlist has been added before";

                }
            }
        }


        protected void button_Add_productToWatchlist(object sender, EventArgs e)
        {

            try
            {

                string CS = ConfigurationManager.ConnectionStrings["Projectfinal"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("AddtoWishlist", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();


                    //----delete customername_addproducttowatchlist.Text. but the session username ---- delete the textbox
                    cmd.Parameters.AddWithValue("@customername", (string)Session["field1"]);
                    //----------------------------------------------------------------------------------------------------
                    cmd.Parameters.AddWithValue("@wishlistname", wishlistname_add.Text);
                    cmd.Parameters.AddWithValue("@serial", serial_add.Text);




                    cmd.ExecuteNonQuery();

                    con.Close();
                    error.Text = "product added to watchlist ";
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                error.Text = "there is an error check that" +
                    "<br/>1- the wishlist name is correct (you created a wish list with thit name)" +
                    "<br/>2- the serial num is corret (there is a product with this serial num chek view products )";

            }

        }


        protected void button_remove_productToWatchlist(object sender, EventArgs e)
        {
            try
            {

                string CS = ConfigurationManager.ConnectionStrings["Projectfinal"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("removefromWishlist", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();


                    //----delete customername_addproducttowatchlist.Text. but the session username ---- delete the textbox
                    cmd.Parameters.AddWithValue("@customername", (string)Session["field1"]);

                    //----------------------------------------------------------------------------------------------------
                    cmd.Parameters.AddWithValue("@wishlistname", wishlistname_remove.Text);
                    cmd.Parameters.AddWithValue("@serial", serial_remove.Text);




                    cmd.ExecuteNonQuery();

                    con.Close();
                    error.Text = "product removed from watchlist ";
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                error.Text = "there is an error check that" +
                    "<br/>1- the wishlist name is correct (you created a wish list with thit name)" +
                    "<br/>2- the serial num is corret (there is a product with this serial num in your wish list  )";

            }


        }



        protected void button_Add_productToCart(object sender, EventArgs e)
        {
            try
            {

                string CS = ConfigurationManager.ConnectionStrings["Projectfinal"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("AddToCart", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();


                    //----delete customername_addproducttowatchlist.Text. but the session username ---- delete the textbox
                    cmd.Parameters.AddWithValue("@customername", (string)Session["field1"]);
                    //----------------------------------------------------------------------------------------------------

                    cmd.Parameters.AddWithValue("@serial", serial_add_cart.Text);




                    cmd.ExecuteNonQuery();

                    con.Close();
                    error.Text = "product added to Cart ";
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                error.Text = "there is an error check that" +

                    "<br/>1- the serial num is corret (there is a product with this serial num chek view products )";

            }
        }


        protected void button_remove_productfromCart(object sender, EventArgs e)
        {
            try
            {

                string CS = ConfigurationManager.ConnectionStrings["Projectfinal"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("removefromCart", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();


                    //----delete customername_addproducttowatchlist.Text. but the session username ---- delete the textbox
                    cmd.Parameters.AddWithValue("@customername", (string)Session["field1"]);
                    //----------------------------------------------------------------------------------------------------

                    cmd.Parameters.AddWithValue("@serial", serial_remove_cart.Text);




                    cmd.ExecuteNonQuery();

                    con.Close();
                    error.Text = "product removed from Cart ";
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                error.Text = "there is an error check that" +

                    "<br/>1- the serial num is corret (there is a product with this serial num in your cart )";

            }
        }



        protected void button_Add_creditcard(object sender, EventArgs e)
        {
            try
            {

                string CS = ConfigurationManager.ConnectionStrings["Projectfinal"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("AddCreditCard", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();



                    cmd.Parameters.AddWithValue("@creditcardnumber", creditcardnumber.Text);
                    cmd.Parameters.AddWithValue("@expirydate", expirydate.Text);
                    cmd.Parameters.AddWithValue("@cvv", cvv.Text);
                    //----delete customername.Text but the session username ---- delete the textbox  
                    cmd.Parameters.AddWithValue("@customername", (string)Session["field1"]);
                    //-------------------------------------

                    cmd.ExecuteNonQuery();

                    con.Close();
                    error.Text = "credit card added ";
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                error.Text = "there is an error check that" +
                    "<br/>1- the expirydate is a valid date of the form mm/dd/yyyy" +
                    "<br/>2-cvv is a maximum 4 characters" +
                    "<br/>3-if there is still an error chesk that credit card number is uniqe (change it )";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx", true);
        }

        protected void make_order_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ordering.aspx", true);
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CancelOrder.aspx", true);
        }
    }
}