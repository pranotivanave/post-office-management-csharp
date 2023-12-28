using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostOfficeManagementSystem2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void moneyOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoneyOrder obj = new MoneyOrder();
            obj.ShowDialog();
        }

        private void moneyOrderToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewMoneyOrder obj7 = new ViewMoneyOrder();
            obj7.ShowDialog();
        }

        private void parcelServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParcelService obj = new ParcelService();
            obj.ShowDialog();
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductDetails obj1 = new ProductDetails();
            obj1.ShowDialog();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewProductDetails obj9 = new ViewProductDetails();
            obj9.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void registeredPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisteredPost obj2 = new RegisteredPost();
            obj2.ShowDialog();
        }

        private void rDIMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RDIMoney obj3 = new RDIMoney();
            obj3.ShowDialog();
        }

        private void speedPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeedPost obj4 = new SpeedPost();
            obj4.ShowDialog();
        }

        private void salesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesDetails obj5 = new SalesDetails();
            obj5.ShowDialog();
        }

        private void moneySavingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MoneySavings obj6 = new MoneySavings();
            obj6.ShowDialog();
        }

        private void parcelServiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewParcelService obj8 = new ViewParcelService();
            obj8.ShowDialog();
        }

        private void registeredPostToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewRegisteredPost obj10 = new ViewRegisteredPost();
            obj10.ShowDialog();
        }

        private void rDIMoneyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowRDIMoney obj11 = new ShowRDIMoney();
            obj11.ShowDialog();
        }

        private void speedPostToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewSpeedPost obj12 = new ViewSpeedPost();
            obj12.ShowDialog();

        }

        private void salesDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewSalesDetails obj13 = new ViewSalesDetails();
            obj13.ShowDialog();
        }

        private void moneyOrderToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ViewMoneySavings obj14 = new ViewMoneySavings();
            obj14.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
