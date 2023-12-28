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
    public partial class ViewSalesDetails : Form
    {
        public ViewSalesDetails()
        {
            InitializeComponent();
        }

        private void ViewSalesDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesdetailsDataSet.salesdetails' table. You can move, or remove it, as needed.
            this.salesdetailsTableAdapter.Fill(this.salesdetailsDataSet.salesdetails);
            OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\PostOfficeManagementSystem2\PostOfficeManagementSystem2\salesdetails.accdb");
            {
                string str2 = "SELECT*FROM salesdetails";
                OleDbCommand cmd2 = new OleDbCommand(str2, con1);
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
    }
}
