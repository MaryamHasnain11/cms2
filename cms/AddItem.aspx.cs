using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cms
{
    public partial class AddItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
	+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\cms2\\cms\\App_Data\\Database2.accdb";
			con.Open();
            string selectString = "select COUNT(*) from Item Where ItemName" + " like'" + TextBox1.Text.ToString() + "%'";
            OleDbCommand cmd = new OleDbCommand(selectString, con);
            int a = (int)cmd.ExecuteScalar();
            System.Windows.Forms.MessageBox.Show(a.ToString());
            //OleDbDataReader dr = cmd.ExecuteReader();
            // while (dr.Read())
            // {
            //    System.Windows.Forms.MessageBox.Show(dr[0].ToString());
            //}
            //dr.Close();
            if (a == 0)
            {
                selectString = "insert into [Item](ItemName,Price,Quantity)values(@na,@pr,@quan)";

                cmd = new OleDbCommand(selectString, con);
                //MessageBox.Show(DropDownList1.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@na", TextBox1.Text);
                cmd.Parameters.AddWithValue("@pr", TextBox2.Text);
                cmd.Parameters.AddWithValue("@quan", TextBox3.Text);
                cmd.Connection = con;
                a = cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(a.ToString());


				Response.Redirect("Admin.aspx");

            }
        }
    }
}