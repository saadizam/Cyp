using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB
{
    public partial class ViewDetail : System.Web.UI.Page
    {
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["code"];
            SqlConnection con1 = new SqlConnection("Data Source=DSVR019716\\SHAHZEB;Initial Catalog=BuzyBeezCYP;Integrated Security=True");
            string query1 = "select custname,account,creditcard,date,time,Passengers,[from],[to],fare,flightno,jobref,Via1address,commentt,telephone from BookingPortalCYP where id=" + id + "";
            SqlDataAdapter da = new SqlDataAdapter(query1, con1);
            DataSet ds1 = new DataSet();
            da.Fill(ds1);
            GridView1.DataSource = ds1;
            GridView1.DataBind();
        }
     
        

        protected void Button3_Click(object sender, EventArgs e)
        {
            id = Request.QueryString["code"];
            SqlConnection con1 = new SqlConnection("Data Source=DSVR019716\\SHAHZEB;Initial Catalog=BuzyBeezCYP;Integrated Security=True");
            string query = "UPDATE BookingPortalCYP SET STATUS ='CONFIRM' WHERE ID=" + id + " ";
            SqlCommand cmd = new SqlCommand(query, con1);
            con1.Open();
            cmd.ExecuteNonQuery();
            con1.Close();
            Response.Redirect("~/ViewBooking.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            
            id = Request.QueryString["code"];
            SqlConnection con1 = new SqlConnection("Data Source=DSVR019716\\SHAHZEB;Initial Catalog=BuzyBeezCYP;Integrated Security=True");
            string query = "UPDATE BookingPortalCYP SET STATUS ='Declined' WHERE ID=" + id + " ";
            SqlCommand cmd = new SqlCommand(query, con1);
            con1.Open();
            cmd.ExecuteNonQuery();
            con1.Close();
            Response.Redirect("~/ViewBooking.aspx");
        }
    }
}