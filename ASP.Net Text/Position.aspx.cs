using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace ASP.Net_Text
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button2_Click(object sender, EventArgs e)
        {

            String mainconn = ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[Position] (cPositionCode,vDescription,iBudgetedStrength,siYear,iCurrentStrength) values (@PositionCode,@Description,@BudgetedStrength,@Year,@CurrentStrength)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Description", TextBox1.Text);
            sqlcomm.Parameters.AddWithValue("@BudgetedStrength", TextBox2.Text);
            sqlcomm.Parameters.AddWithValue("@Year", TextBox3.Text);
            sqlcomm.Parameters.AddWithValue("@CurrentStrength", TextBox4.Text);

            sqlconn.Open();
            sqlcomm.ExecuteNonQuery();

            sqlconn.Close();

        }
    }
}   
