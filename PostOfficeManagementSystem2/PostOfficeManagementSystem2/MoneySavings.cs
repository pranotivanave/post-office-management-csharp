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
    public partial class MoneySavings : Form
    {
        public MoneySavings()
        {
            InitializeComponent();
        }

        private void MoneySavings_Load(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\PostOfficeManagementSystem2\PostOfficeManagementSystem2\moneysavings.accdb");
            con.Open();

            try
            {
                string str = "INSERT INTO moneysavings ([name],[door_no],[street],[country],[state],[city],[account_no],[years],[interest_rate],[start_date],[amount],[monthly_amt],[total_interest],[last_date],[total_amt]) VALUES (?, ?, ?, ?, ?, ?,?,?,?,?,?,?,?,?,?)";

                OleDbCommand cmd = new OleDbCommand(str, con);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@door_no", textBox3.Text);
                cmd.Parameters.AddWithValue("@street", textBox4.Text);
                cmd.Parameters.AddWithValue("@Country", comboBox1.SelectedItem.ToString()); // Assuming you have a ComboBox named comboBoxCountry
                cmd.Parameters.AddWithValue("@State", comboBox2.SelectedItem.ToString()); // Assuming you have a ComboBox named comboBoxState
                cmd.Parameters.AddWithValue("@City", comboBox3.SelectedItem.ToString()); // Assuming you have a ComboBox named comboBoxCity
                cmd.Parameters.AddWithValue("@account_no", textBox5.Text);
                cmd.Parameters.AddWithValue("@years", textBox6.Text);
                cmd.Parameters.AddWithValue("@interest_rate", textBox7.Text);
                cmd.Parameters.AddWithValue("@start_date", dateTimePicker1.Value); // Use the Value property of the DateTimePicker
                cmd.Parameters.AddWithValue("@amount", textBox8.Text);
                cmd.Parameters.AddWithValue("@monthly_amt", textBox9.Text);
                cmd.Parameters.AddWithValue("@total_interest", textBox10.Text);
                cmd.Parameters.AddWithValue("@last_date", dateTimePicker2.Value); // Use the Value property of the DateTimePicker
                cmd.Parameters.AddWithValue("@total_amt", textBox11.Text);
               

                cmd.ExecuteNonQuery();

                string str1 = "SELECT max(id) FROM moneysavings;";

                OleDbCommand cmd1 = new OleDbCommand(str1, con);
                OleDbDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Money Savings Details Information Successfully.");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    comboBox1.SelectedIndex = -1; // Reset the selected country to no selection
                    comboBox2.SelectedIndex = -1; // Reset the selected state to no selection
                    comboBox3.SelectedIndex = -1;
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    dateTimePicker1.Value = DateTime.Now; // Reset the date to the current date
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    dateTimePicker2.Value = DateTime.Now; // Reset the date to the current date
                    textBox11.Text = "";

                   
                }
            }
            catch (OleDbException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "India")
            {
                comboBox2.Items.Add("Maharashtra");
                comboBox2.Items.Add("Goa");
                comboBox2.Items.Add("Kerala");
                comboBox2.Items.Add("Punjab");
                comboBox2.Items.Add("Tamil Nadu");

            }

            if (comboBox1.Text == "America")
            {
                comboBox2.Items.Add("New York");
                comboBox2.Items.Add("California");

            }
            if (comboBox1.Text == "Australia")
            {
                comboBox2.Items.Add("Victoria");
                comboBox2.Items.Add("Western Australia");
                comboBox2.Items.Add("South Australia");

            }
            if (comboBox1.Text == "Nepal")
            {
                comboBox2.Items.Add("Karnali");
                comboBox2.Items.Add("Gandaki");
                comboBox2.Items.Add("Lumbini");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            if (comboBox2.Text == "Maharashtra")
            {

                comboBox3.Items.Add("Pune");
                comboBox3.Items.Add("Mumbai");
                comboBox3.Items.Add("Nashik");
                comboBox3.Items.Add("Thane");
                comboBox3.Items.Add("Sangali");
                comboBox3.Items.Add("Nanded");
                comboBox3.Items.Add("Amravati");
                comboBox3.Items.Add("Nagpur");
            }
            if (comboBox2.Text == "Goa")
            {

                comboBox3.Items.Add("Panaji");
                comboBox3.Items.Add("Mapusa");

            }
            if (comboBox2.Text == "Kerala")
            {

                comboBox3.Items.Add("Kochi");
                comboBox3.Items.Add("Kannur");

            }
            if (comboBox2.Text == "Punjab")
            {

                comboBox3.Items.Add("Amritsar");
                comboBox3.Items.Add("Moga");
                comboBox3.Items.Add("Firozpur");

            }
            if (comboBox2.Text == "Tamil Nadu")
            {

                comboBox3.Items.Add("Chennai");
                comboBox3.Items.Add("Theni");
                comboBox3.Items.Add("Ambur");

            }
            if (comboBox2.Text == "New York")
            {

                comboBox3.Items.Add("Brooklyn");
                comboBox3.Items.Add("Bronx");

            }
            if (comboBox2.Text == "California")
            {

                comboBox3.Items.Add("Los Angeles");
                comboBox3.Items.Add("San Francisco");

            }
            if (comboBox2.Text == "Victoria")
            {

                comboBox3.Items.Add("Malbourn");
                comboBox3.Items.Add("Geelong");

            }
            if (comboBox2.Text == "Western Australia")
            {

                comboBox3.Items.Add("Perth");
                comboBox3.Items.Add("Albany");

            }
            if (comboBox2.Text == "Karnali")
            {

                comboBox3.Items.Add("Dullu");
                comboBox3.Items.Add("Bheriganga");

            }
            if (comboBox2.Text == "Gandaki")
            {

                comboBox3.Items.Add("Syangja");
                comboBox3.Items.Add("Pokhara");

            }
            if (comboBox2.Text == "Lumbini")
            {

                comboBox3.Items.Add("Gulmi");
                comboBox3.Items.Add("Palpa");

            }

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
            textBox10.Text = "";
            textBox11.Text = "";
        }
    }

       

       

        
    }


