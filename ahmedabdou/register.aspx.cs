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
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void registerto(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            
            // To read the input from the user 
            string fn = fname.Text;
            string ln = lname.Text;
            string user = username.Text;
            string pass = password.Text;
            string em = email.Text;
            
            if(fn.Equals("") || ln.Equals("") || user.Equals("") || pass.Equals("") || em.Equals("") )
            {
                Response.Write("Required data is missed");
            }
            
            else 
            {
                SqlCommand cmd = new SqlCommand("customerRegister", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@username", user));
                cmd.Parameters.Add(new SqlParameter("@first_name", fn));
                cmd.Parameters.Add(new SqlParameter("@last_name", ln));
                cmd.Parameters.Add(new SqlParameter("@password", pass));
                cmd.Parameters.Add(new SqlParameter("@email", em));

                SqlCommand cmd1 = new SqlCommand("contain", conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add(new SqlParameter("@username", user));
                SqlParameter type = cmd1.Parameters.Add("@success", SqlDbType.Int);
                type.Direction = ParameterDirection.Output;

                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();

                if (type.Value.ToString().Equals("0"))
                {
                    //To send response data to the client side (HTML)
                    Response.Write("this username is exist choose another one");
                }
                else {
                    Response.Write("Regestered successfully");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

            }

            // pass parameters to the stored procedure



            //Executing the SQLCommand



        }

        protected void login(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx", true);
        }
    }
   
}