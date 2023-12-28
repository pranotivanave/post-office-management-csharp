using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostOfficeManagementSystem2
{
    public partial class MoneyOrder : Form
    {
        public MoneyOrder()
        {
            InitializeComponent();
        }

        private void MoneyOrder_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'moneyorderDataSet.moneyorder' table. You can move, or remove it, as needed.
            this.moneyorderTableAdapter.Fill(this.moneyorderDataSet.moneyorder);

            OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\PostOfficeManagementSystem2\PostOfficeManagementSystem2\moneyorder.accdb");
            {

                string str2 = "SELECT * FROM moneyorder";
                OleDbCommand cmd2 = new OleDbCommand(str2, con1);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\PostOfficeManagementSystem2\PostOfficeManagementSystem2\moneyorder.accdb");
            con.Open();
            string str1 = "select max(id) from moneyorder;";

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
        
            

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\PostOfficeManagementSystem2\PostOfficeManagementSystem2\moneyorder.accdb");
            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select s_name,s_address,s_mobile,amount,r_name,r_address,r_mobile from moneyorder where id=" + Convert.ToInt32(textBox1.Text) + " ;";

                    OleDbCommand cmd = new OleDbCommand(getCust, con);
                    OleDbDataReader dr = cmd.ExecuteReader();
                   
                    if (dr.Read())
                    {

                        textBox2.Text = dr.GetValue(0).ToString();
                        textBox3.Text = dr.GetValue(1).ToString();
                        textBox4.Text = dr.GetValue(2).ToString();
                        textBox5.Text = dr.GetValue(3).ToString();
                        textBox6.Text = dr.GetValue(4).ToString();
                        textBox7.Text = dr.GetValue(5).ToString();
                        textBox8.Text = dr.GetValue(6).ToString();
                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This id, " + textBox1.Text + " money Order Details Record is not Available.   ");
                        textBox1.Text = "";
                    }
                }
                catch (OleDbException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\PostOfficeManagementSystem2\PostOfficeManagementSystem2\moneyorder.accdb");
            con.Open();
            string gen = string.Empty;

            try
            {
                string str = "INSERT INTO moneyorder(s_name,s_address,s_mobile,amount,r_name,r_address,r_mobile) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "'); ";

                OleDbCommand cmd = new OleDbCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from moneyorder;";
                OleDbCommand cmd1 = new OleDbCommand(str1, con);
                OleDbDataReader dr = cmd1.ExecuteReader();


                if (dr.Read())
                {
                    MessageBox.Show("Inserted Money Order Details Information Successfully..");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";

                    using (OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\PostOfficeManagementSystem2\PostOfficeManagementSystem2\moneyorder.accdb"))
                    {
                        string str2 = "SELECT * FROM moneyorder";
                        OleDbCommand cmd2 = new OleDbCommand(str2, con1);
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                }
            }
            catch (OleDbException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            
                
        }
    }
    }

