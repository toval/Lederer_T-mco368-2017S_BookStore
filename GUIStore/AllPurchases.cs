using Db;
using System;
using System.Collections;
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
    public partial class AllPurchases : Form
    {
        DataClasses1DataContext context;

        public AllPurchases()
        {
            InitializeComponent();
            context = new DataClasses1DataContext();
    
            var allPurchases = context.INVOICEs.Where(c=>c.Cust_ID == CustLogin.Id)
                .Select(c=> new
                {
                    Date = c.Inv_Date,
                    Title = c.BOOK.Book_Name,
                    Author = c.BOOK.Book_AuthorName,
                    Total = c.Inv_Total,
                    Qty = c.Inv_Qty
                }).ToList();
        
            purchases.DataSource = allPurchases;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllProducts prod = new AllProducts();
            prod.Show();
        }

        private void viewallpurchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllPurchases_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
