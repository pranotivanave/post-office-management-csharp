using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PostOfficeManagementSystem2
{
    public partial class RegisteredPost : Form
    {
        public RegisteredPost()
        {
            InitializeComponent();
        }

        private void RegisteredPostcs_Load(object sender, EventArgs e)
        {
           OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\PostOfficeManagementSystem2\PostOfficeManagementSystem2\registeredpost.accdb");
            con.Open();
            string str1 = "select max(id) from registeredpost;";

              OleDbCommand cmd1 = new OleDbCommand(str1, con);
               OleDbDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox1.Text = a.ToString();
                }
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\PostOfficeManagementSystem2\PostOfficeManagementSystem2\registeredpost.accdb");

            con.Open();
            string gen = string.Empty;

            try
            {
                string str = "INSERT INTO registeredpost(s_name,s_address,s_mobile,state,amount,r_name,r_address,r_mobile) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "'); ";

                OleDbCommand cmd = new OleDbCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from registeredpost;";

                OleDbCommand cmd1 = new OleDbCommand(str1, con);
                 OleDbDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Registered Post Details Information Successfully..");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";

                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


