using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Windows.Forms;

namespace cms
{
	public partial class Menu : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			OleDbConnection con = new OleDbConnection();
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\cms2\\cms\\App_Data\\Database2.accdb";
			con.Open();

			string selectString = "select ItemID, ItemName, Price from Item;";



			OleDbCommand cmd1 = new OleDbCommand(selectString, con);
			cmd1.Connection = con;
			cmd1.CommandType = CommandType.Text;
			OleDbDataAdapter da = new OleDbDataAdapter(cmd1);
			DataTable scores = new DataTable();
			da.Fill(scores);
			if (!IsPostBack)
			{
				grid1.DataSource = scores;
				grid1.DataBind();
				//MessageBox.Show("hi");
			}


			//	con.Close();
		}

		protected void grid1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		protected void cbSelect_CheckedChanged(object sender, EventArgs e)
		{
			OleDbConnection con = new OleDbConnection();
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\cms2\\cms\\App_Data\\Database2.accdb";
			con.Open();
			foreach (GridViewRow row in grid1.Rows)
			{


				string selectString = "select ItemID, ItemName, Price, Quantity from Item;";


				String ItemName = null;

				OleDbCommand cmd = new OleDbCommand(selectString, con);
				cmd.Connection = con;
				cmd.CommandType = CommandType.Text;
				OleDbDataReader reader = cmd.ExecuteReader();
				//reader = cmd.ExecuteReader();



				//ItemName = reader.GetInt32(reader.GetOrdinal("MemberID"));

				//surname = reader["Surname"].ToString();
				string iqty = null;
				int b = 0;
				int a = 0;
				if (((System.Web.UI.WebControls.CheckBox)row.FindControl("cbSelect")).Checked)
				{
					string n = grid1.Rows[row.RowIndex].Cells[1].Text;
					System.Web.UI.WebControls.TextBox my = (System.Web.UI.WebControls.TextBox)(grid1.Rows[row.RowIndex].Cells[3].FindControl("tb"));

					a = int.Parse(my.Text);
					//MessageBox.Show(a.ToString());
					if (a == 0)
					{
						MessageBox.Show("Enter quantity");
					}
					else if (a > 0)
					{
						while (reader.Read())
						{
							iqty = reader["Quantity"].ToString();
							b = int.Parse(iqty); //from database
							ItemName = reader["ItemName"].ToString();
							if (n == ItemName)
							{
								//a quantity user enters
								if (a < b)
								{
									//MessageBox.Show("ok");
									break;
								}
								else
								{

									MessageBox.Show("Sorry we are out of stock for: " + ItemName);

								}
							}

						}


					}
					a = 0;

					reader.Close();
				}
				else {
					System.Web.UI.WebControls.TextBox my = (System.Web.UI.WebControls.TextBox)(grid1.Rows[row.RowIndex].Cells[3].FindControl("tb"));
					my.Text = "0";
				}
			}

			

		}






		protected void Button1_Click(object sender, EventArgs e)
		{
			int pr = 0;
			int b = 0;
			int a = 0;
			int c = 0;
			int g = 0;
			foreach (GridViewRow row in grid1.Rows)
			{

				if (((System.Web.UI.WebControls.CheckBox)row.FindControl("cbSelect")).Checked)
				{

					string p = grid1.Rows[row.RowIndex].Cells[2].Text; //price
					string n = grid1.Rows[row.RowIndex].Cells[1].Text;
					System.Web.UI.WebControls.TextBox my = (System.Web.UI.WebControls.TextBox)(grid1.Rows[row.RowIndex].Cells[3].FindControl("tb"));
					a = int.Parse(my.Text);
					g = int.Parse(p);
					//MessageBox.Show(a.ToString());
					if (a == 0)
					{
						break;
					}
					else if (a > 0)
					{
						c = a * g;

						pr = pr + c;

					}



				}
				TextBox1.Text = pr.ToString() + "$";
			}
		}
		static int count = 0;
		protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
		{
			//Response.Redirect("StartPage.aspx");
			count++;
			
			string stat = "in progress";
			foreach (GridViewRow row in grid1.Rows)
			{


				


				String ItemID = null;


				

				int a = 0;
				if (((System.Web.UI.WebControls.CheckBox)row.FindControl("cbSelect")).Checked)
				{
					string n = grid1.Rows[row.RowIndex].Cells[1].Text; //name
					//quantity user enters
					System.Web.UI.WebControls.TextBox my = (System.Web.UI.WebControls.TextBox)(grid1.Rows[row.RowIndex].Cells[3].FindControl("tb"));
					//MessageBox.Show(n);
					a = int.Parse(my.Text);

					OleDbConnection con = new OleDbConnection();

					con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
	+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\cms2\\cms\\App_Data\\Database2.accdb";

					string query = "SELECT ItemID" + " FROM Item" +
		" WHERE ItemName =  '" + n + "'";
					OleDbCommand cmd = new OleDbCommand(query, con);
					
					con.Open();
					OleDbDataReader reader = cmd.ExecuteReader();
					reader.Read();
					ItemID = reader["ItemID"].ToString();
					//MessageBox.Show(a.ToString());
					if (a == 0)
					{
						MessageBox.Show("Please enter quantity.");

						break;
					}
					else if (a > 0 )
					{
						
						while (a != 0)
						{
						//	MessageBox.Show("hi");


							String q = @"INSERT INTO OrderedItems (ItemID,OrderNo,OrderStatus) VALUES(@ItemID,@count,@stat)";
							System.Data.OleDb.OleDbCommand cmd1 = new System.Data.OleDb.OleDbCommand(q, con);
							cmd1.Parameters.AddWithValue("@ItemID", ItemID);
							cmd1.Parameters.AddWithValue("@count", count);
							cmd1.Parameters.AddWithValue("@stat", stat);

							//con.Open();




							cmd1.ExecuteNonQuery();
							a--;
						}
						
						//con.Close();





					}
					

				//	reader.Close();
				}
				

				else
				{
					System.Web.UI.WebControls.TextBox my = (System.Web.UI.WebControls.TextBox)(grid1.Rows[row.RowIndex].Cells[3].FindControl("tb"));
					my.Text = "0";
				}
			}

			MessageBox.Show("Your order has been confirmed!");
		}
	}
}