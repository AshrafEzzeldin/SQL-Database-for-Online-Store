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
    public partial class Companies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Projectfinal"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("showProducts", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();

            //IF the output is a table, then we can read the records one at a time
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                //Get the value of the attribute name in the Company table
                Int32 companyName = rdr.GetInt32(rdr.GetOrdinal("serial_no"));
                //Get the value of the attribute field in the Company table
                string venuser = rdr.GetString(rdr.GetOrdinal("username"));

                //Create a new label and add it to the HTML form
                Label lbl_CompanyName = new Label();
                lbl_CompanyName.Text = companyName + "  speciliazes in ";
                form1.Controls.Add(lbl_CompanyName);


                Label lbl_CompanyField = new Label();
            //    lbl_CompanyField.Text = companyField + "  <br /> <br />";
                form1.Controls.Add(lbl_CompanyField);
            }
            //this is how you retrive data from session variable.
            string field1 = (string)(Session["field1"]);
            Response.Write(field1);
        }
    }
}