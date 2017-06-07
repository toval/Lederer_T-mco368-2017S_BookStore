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
    public partial class PriceRangePurchases : Form
    {
        DataClasses1DataContext context;

        public PriceRangePurchases()
        {
            InitializeComponent();
            context = new DataClasses1DataContext();    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int minAmnt = 0;
            int maxAmnt = 0;
            minAmnt= int.Parse(min.Text);
            maxAmnt = int.Parse(max.Text);
           
    var priceRanges = context.INVOICEs.Where(c => c.Cust_ID == CustLogin.Id 
                 && c.Inv_Total >= minAmnt && c.Inv_Total <= maxAmnt)
                .Select(c => new
                {
                    Date = c.Inv_Date,
                    Title = c.BOOK.Book_Name,
                    Author = c.BOOK.Book_AuthorName,
                    Total = c.Inv_Total,
                    Qty = c.Inv_Qty
                }).ToList();
            pricerange.DataSource = priceRanges;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllProducts prod = new AllProducts();
            prod.Show();
        }

        private void pricerange_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
