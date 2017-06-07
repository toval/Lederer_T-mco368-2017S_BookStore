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
    public partial class CustLogin : Form
    {
        public static int Id { get; private set; }
        public CustLogin()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            if (context.CUSTOMERs.Any(c => c.Cust_User == userName.Text && c.Cust_Password == password.Text))
            {
                Id = context.CUSTOMERs.Where(c => c.Cust_User == userName.Text && c.Cust_Password == password.Text)
                    .Select(c=>c.Cust_ID).First();
                //bring user to next page
                AllProducts prod = new AllProducts();
                prod.Show();
            }
            
            else
            {
                MessageBox.Show("you are not a user...");
                CreateAccnt accnt = new CreateAccnt();
                accnt.Show();
            }           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateAccnt accnt = new CreateAccnt();
            accnt.Show();
        }

        private void CustLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
