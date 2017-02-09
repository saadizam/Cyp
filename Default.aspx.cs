using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
            }

            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            //this.Panel1.Style.Add("position", "absolute");
            //this.Panel1.Style.Add("top", "250px");
            //this.Panel1.Style.Add("left", "225px");
            PageBody.Attributes.Add("bgcolor", "black");
            TextBox1.Attributes.Add("autocomplete", "off");
            TextBox2.Attributes.Add("autocomplete", "off");

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            //if (AuthenticateUser(TextBox1.Text, TextBox2.Text))
            //{

            //    FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, CheckBox1.Checked);
            //    TextBox1.Text = "";
            //    TextBox2.Text = "";

            //    Response.Redirect("Login.aspx");

            //}

            //else
            //{
            //    Label1.Text = "Invalid user or passowrd";
            //    TextBox1.Text = "";
            //    TextBox2.Text = "";
            //}


            string Email = TextBox1.Text;
            string password = TextBox2.Text;


            SqlDataAdapter sqlAdapter;
            SqlCommand sqlCmd = new SqlCommand();
            SqlConnection objConn = new SqlConnection();

            objConn.ConnectionString = "Data Source=DSVR019716\\SHAHZEB;Initial Catalog=BuzyBeezCYP;Integrated Security=True";
            DataTable tbl = new DataTable();

            try
            {
                objConn.Open();
                sqlCmd.Connection = objConn;
                sqlCmd.CommandTimeout = 30;
                sqlCmd.CommandText =
                    string.Format("SELECT Email, Password  FROM tblaccount WHERE Email = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'");



                sqlAdapter = new SqlDataAdapter(sqlCmd);
                sqlAdapter.Fill(tbl);
                sqlCmd.Dispose();

                if (tbl != null && tbl.Rows.Count > 0)
                {
                    Session["Email"] = TextBox1.Text;
                    Response.Redirect("Login.aspx");
                }
                else
                    Label1.Text = "Invalid Credentials";
            }
            catch
            {
            }
        }

        //private bool AuthenticateUser(string Username, string Password)
        //{


        //    string CS = ConfigurationManager.ConnectionStrings["BuzybeezWebConnectionString"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(CS))
        //    {
        //        SqlCommand cmd = new SqlCommand("spConfirmationUser", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "SHA1");
        //        SqlParameter paramUsername = new SqlParameter("@Username", Username);
        //        SqlParameter paramPassword = new SqlParameter("@Password", EncryptedPassword);

        //        cmd.Parameters.Add(paramUsername);
        //        cmd.Parameters.Add(paramPassword);
        //        Session["Username"] = TextBox1.Text;

        //        con.Open();
        //        int RETURNCODE = (int)cmd.ExecuteScalar();
        //        return RETURNCODE == 1;
             

        //    }
        //}

        protected void OnlineBookingbtn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("main.html");
        }

        protected void AdminPanelBtn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }

        protected void OpenAccountbtn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }
    }
}