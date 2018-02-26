﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace cms
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			

		}

		protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
		{
			String userName = TextBox1.Text.ToString();

			String pasword = TextBox2.Text.ToString();
			OleDbConnection con = new OleDbConnection();
			//Use a string variable to hold the ConnectionString.
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\cms2\\cms\\App_Data\\Database2.accdb";
			string query = @"select count(*) from Users where Username=@userName and Pasword = @pasword;";
			OleDbCommand cmd = new OleDbCommand(query, con);

			con.Open();
			cmd.Parameters.AddWithValue("@userName", TextBox1.Text);
			cmd.Parameters.AddWithValue("@pasword", TextBox2.Text);
			int result = (int)cmd.ExecuteScalar();
			if (result > 0)
			{
				if (userName=="Maryam") {
					Response.Redirect("Admin.aspx");
					Response.Write("<script>alert('Login successful.');</script>");

				}
				if (userName == "Maryam11") {
				//	Response.Redirect("Staff.aspx");
				}
				Response.Write("<script>alert('Login successful.');</script>");
				Response.Redirect("Menu.aspx");
			}

			else
			{
				Response.Write("<script>alert('login not successful.  Please enter your details again.');</script>");
			}


			con.Close();

		}

		
	}
}