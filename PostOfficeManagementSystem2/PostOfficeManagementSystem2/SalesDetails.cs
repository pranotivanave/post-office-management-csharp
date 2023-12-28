using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PostOfficeManagementSystem2
{
    public partial class SalesDetails : Form
    {
        public SalesDetails()
        {
            InitializeComponent();
        }

        private void SalesDetails_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\PostOfficeManagementSystem2\PostOfficeManagementSystem2\salesdetails.accdb");
            con.Open();

            try
            {
                string str = "INSERT INTO salesdetails ([date], [stamps], [post_card], [rate], [amount], [count]) VALUES (?, ?, ?, ?, ?, ?)";

                OleDbCommand cmd = new OleDbCommand(str, con);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value); // Use the Value property of the DateTimePicker
                cmd.Parameters.AddWithValue("@stamps", textBox3.Text);
                cmd.Parameters.AddWithValue("@post_card", ""); // Assuming it's empty, you can adjust this value as needed
                cmd.Parameters.AddWithValue("@rate", textBox4.Text);
                cmd.Parameters.AddWithValue("@amount", textBox5.Text);
                cmd.Parameters.AddWithValue("@count", textBox6.Text);

                cmd.ExecuteNonQuery();

                string str1 = "SELECT max(id) FROM salesdetails;";

                OleDbCommand cmd1 = new OleDbCommand(str1, con);
                OleDbDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Sales Details Information Successfully.");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
            }
            catch (OleDbException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }
    }
}
    
           
        
    

