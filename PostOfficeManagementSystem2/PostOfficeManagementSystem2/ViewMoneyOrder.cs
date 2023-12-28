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
using CrystalDecisions.CrystalReports.Engine;


namespace PostOfficeManagementSystem2
{
    public partial class ViewMoneyOrder : Form
    {
        
        public ViewMoneyOrder()
        {
            InitializeComponent();
        }

        private void ViewMoneyOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moneyorderDataSet1.moneyorder' table. You can move, or remove it, as needed.
            this.moneyorderTableAdapter.Fill(this.moneyorderDataSet1.moneyorder);
            OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\PostOfficeManagementSystem2\PostOfficeManagementSystem2\moneyorder.accdb") ;

            {

                string str2 = "SELECT * FROM moneyorder";
                OleDbCommand cmd2 = new OleDbCommand(str2,con1);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\PostOfficeManagementSystem2\PostOfficeManagementSystem2\moneyorder.accdb");
            {
                viewReport f2 = new viewReport();
                f2.Show();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                OleDbCommand cmd = new OleDbCommand("select * from moneyorder", con);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "moneyorder");
                CrystalReport1 cr1 = new CrystalReport1();
                cr1.SetDataSource(ds);
               
                cr1.Load("C: \\Users\\User\\source\repos\\PostOfficeManagementSystem2\\PostOfficeManagementSystem2\\CrystalReport1.rpt");
                f2.crystalReportViewer1.ReportSource = cr1;
                f2.crystalReportViewer1.Refresh();
                con.Close();
            }

        }
    }
}

