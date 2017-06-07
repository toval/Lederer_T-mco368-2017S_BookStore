
using Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIStore
{
    public partial class CreateAccnt : Form
    {

public CreateAccnt()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            //make sure this customer doesnt already have an account...
            if (!context.CUSTOMERs.Where(c => c.Cust_Fname == FName.Text && c.Cust_Lname == LName.Text).Any())
            {
                CUSTOMER cust = new CUSTOMER
                {
                    Cust_Fname = FName.Text,
                    Cust_Lname = LName.Text,
                    Cust_User = userName.Text,
                    Cust_Password = password.Text
                };
                context.CUSTOMERs.InsertOnSubmit(cust);
                context.SubmitChanges();
                //bring user to next part
                this.Hide();
                CustLogin login = new CustLogin();
                login.Show();    
            }
            else
            {
                MessageBox.Show("You are already a customer");
                //show user to login page
                CustLogin login = new CustLogin();
                login.Show();
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
