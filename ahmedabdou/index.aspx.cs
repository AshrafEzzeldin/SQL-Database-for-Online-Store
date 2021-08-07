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
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            //create a new connection 
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/

        }


        protected void login(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand cmd = new SqlCommand("userlogin", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // To read the input from the user
            string username = txt_username.Text ;
            string password = txt_password.Text ;

            if(username.Equals("") || password.Equals(""))
            {
                if (username.Equals("") )
                {
                    Label1.Text = "username shouldn't be empty";
                }

                if (password.Equals(""))
                {
                    Label2.Text = "password shouldn't be empty";
                }
            }
            else
            {

            
            // pass parameters to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@password", password));

            //Save the output from the procedure
            SqlParameter succ = cmd.Parameters.Add("@success", SqlDbType.Int);
            succ.Direction = ParameterDirection.Output;

            SqlParameter type = cmd.Parameters.Add("@type", SqlDbType.Int);
            type.Direction = ParameterDirection.Output;

            //Executing the SQLCommand

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


            if (succ.Value.ToString().Equals("1"))
            {
                //To send response data to the client side (HTML)
                Response.Write("Passed");

                /*ASP.NET session state enables you to store and retrieve values for a user
                as the user navigates ASP.NET pages in a Web application.
                This is how we store a value in the session*/
                Session["field1"] = username;

                //To navigate to another webpage
                if (type.Value.ToString().Equals("0"))
                    Response.Redirect("customer_main_page.aspx", true);
                if (type.Value.ToString().Equals("1"))
                    Response.Redirect("vendor_home.aspx", true);
                if (type.Value.ToString().Equals("2"))
                    Response.Redirect("admin.aspx", true);
            
            }
            else
            {
                Response.Write("The username or the password are wrong ");
            }
            }

        }
    }
}