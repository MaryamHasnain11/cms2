using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Windows.Forms;

namespace cms
{
    public partial class Admin : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
	+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\cms2\\cms\\App_Data\\Database2.accdb";
				con.Open();
                string selectString = "select ItemName from Item";
                OleDbCommand cmd = new OleDbCommand(selectString, con);
                
                cmd.Parameters.AddWithValue("@TextS", "");
                cmd.Parameters.AddWithValue("@Text", "");
                cmd.Connection = con;


                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Close();
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {

                    CheckBoxList1.Items.Add(dr[0].ToString());
                }

                string date=DateTime.Today.ToString("yyyy");
                int dat = Int32.Parse(date);
                dat = dat - 1;
                date = dat.ToString();
                MessageBox.Show(date);
                int price= 0;
                //selectString = "select count(*) from Order where OrderStatus Like '%' + @dae + '%'";
                //selectString = "select COUNT(*) from Order Where OrderStatus like'" + date + "%'";
                selectString = " SELECT count(*) FROM [Order] where OrderDate like '%'+ @tags + '%'";
                cmd = new OleDbCommand(selectString, con);
                cmd.Parameters.AddWithValue("@tags", date);
                cmd.Parameters.AddWithValue("@Text", "");
                cmd.Connection = con;
                 int no=(int) cmd.ExecuteScalar();

                MessageBox.Show(no.ToString());
                Button3.Text = no.ToString();
                
                selectString = " SELECT Item.Price FROM [Order],[OrderedItems],[Item] where ([OrderDate] like '%'+ @tags + '%' "+"AND [Order.OrderNo]=[OrderedItems.OrderNo] AND [OrderedItems.ItemID]=[Item.ItemID])";

                cmd = new OleDbCommand(selectString, con);

                cmd.Parameters.AddWithValue("@tags", date);
                cmd.Parameters.AddWithValue("@Text", "s");

                OleDbDataReader de = cmd.ExecuteReader();
                int pr;
                while(de.Read())
                {
                    price += Int32.Parse(de[0].ToString());
                    
                }
                MessageBox.Show(price.ToString());
                Button4.Text = price.ToString()+"$";
                dr.Close();
                selectString = " SELECT OrderNo,OrderStatus,OrderDate,Order.UserID,Order.StaffID FROM [Order],[Users] where ([OrderDate] like '%'+ @tags + '%')";
                cmd = new OleDbCommand(selectString, con);

                cmd.Parameters.AddWithValue("@tags", DateTime.Today.ToString("yyyy"));
                cmd.Parameters.AddWithValue("@Text", "");
                cmd.Parameters.AddWithValue("@Text", "");
                selectString = "select ItemName from Item";
                cmd = new OleDbCommand(selectString, con);
                cmd.Connection = con;
                


                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MessageBox.Show(dr[0].ToString());

                }

                MessageBox.Show("some");



               // GridView2.DataSource = dr;
               // GridView2.DataBind();

            }


        }
        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<ListItem> toBeRemoved = new List<ListItem>();
            for (int ix = 0; ix < CheckBoxList1.Items.Count; ++ix)
            {
                if (CheckBoxList1.Items[ix].Selected == true)
                {
                    MessageBox.Show("Are you sure you want " + CheckBoxList1.Items[ix].ToString() + " to be deleted from the menu list");

                    toBeRemoved.Add(CheckBoxList1.Items[ix]);
                    // book = CheckBoxList1.Items[ix].ToString();

                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
	+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\cms2\\cms\\App_Data\\Database2.accdb";
					con.Open();
                    string selectString = "DELETE FROM Item WHERE ItemName='" + CheckBoxList1.Items[ix].ToString() + "'";
                    OleDbCommand cmd = new OleDbCommand(selectString, con);
                    //MessageBox.Show(DropDownList1.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@TextS", "");
                    cmd.Parameters.AddWithValue("@Text", "");
                    cmd.Connection = con;

                    OleDbDataReader dr = cmd.ExecuteReader();
                    for (int i = 0; i < toBeRemoved.Count; i++)
                    {
                        MessageBox.Show("bak");
                        CheckBoxList1.Items.Remove(toBeRemoved[i]);
                    }


                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddItem.aspx?bID");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
	+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\cms2\\cms\\App_Data\\Database2.accdb";
			con.Open();
            string selectString = " SELECT OrderNo,UserName,OrderStatus,OrderDate FROM [Order],[Users] where ([OrderDate] like '%'+ @tags + '%') AND Order.UserID=Users.UserID"; 
            OleDbCommand cmd = new OleDbCommand(selectString, con);
            MessageBox.Show(DateTime.Today.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@tags", DateTime.Today.ToString("M/dd/yyyy"));
            cmd.Parameters.AddWithValue("@Text", "");
            cmd.Parameters.AddWithValue("@Text", "");
       
            cmd.Connection = con;
            foreach (DataGridViewColumn column in GridView2.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GridView2.AutoGenerateColumns = true;
           
            DataTable results = new DataTable();
            GridView2.AutoGenerateColumns = true;

            
            results.Load(cmd.ExecuteReader());
            GridView2.DataSource = results;
            GridView2.DataBind();
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                MessageBox.Show(dr[0].ToString());

            }

            MessageBox.Show("some");
            
            
            
        }
    }
}