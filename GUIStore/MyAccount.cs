using Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIStore
{
    public partial class MyAccount : Form
    {
        DataClasses1DataContext context;
        public static decimal Credit = 150.00M;

        public MyAccount()
        {
            InitializeComponent();
            context = new DataClasses1DataContext();
            //balance is what they owe
            displayBal.Text = context.CUSTOMERs.Where(c => c.Cust_ID == CustLogin.Id)
                    .Select(c => c.Cust_Balance).First().ToString();
            //credit is how much could spend
        }

        private void Acccount_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllProducts prod = new AllProducts();
            prod.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            int amnt = 0;
            amnt = int.Parse(addMoney.Text);
            CUSTOMER cust = context.CUSTOMERs.Single(c => c.Cust_ID == CustLogin.Id);
            cust.Cust_Balance -= amnt;

            context.SubmitChanges();
            MessageBox.Show("Adding $" + amnt + " to your account balance");
            this.Refresh();
            this.Hide();
            MyAccount accnt = new MyAccount();
            accnt.Show();

        }
    }
}
