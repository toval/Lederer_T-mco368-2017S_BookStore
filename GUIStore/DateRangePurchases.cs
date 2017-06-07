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
    public partial class DateRangePurchases : Form
    {
        DataClasses1DataContext context;
        
        public DateRangePurchases()
        {
            InitializeComponent();
            context = new DataClasses1DataContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllProducts prod = new AllProducts();
            prod.Show();
        }

        private void dateranges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateTimePicker date = new DateTimePicker();
            
            DateTime minAmnt = date.Value;
            DateTime maxAmnt = date.Value;
            minAmnt = DateTime.Parse(min.Text);
            maxAmnt = DateTime.Parse(max.Text);
      
            var dateRanges = context.INVOICEs.Where(c => c.Cust_ID == CustLogin.Id 
                        && c.Inv_Date >= minAmnt && c.Inv_Date <= maxAmnt)
                    .Select(c => new
                    {
                        Date = c.Inv_Date,
                        Title = c.BOOK.Book_Name,
                        Author = c.BOOK.Book_AuthorName,
                        Total = c.Inv_Total,
                        Qty = c.Inv_Qty
                    }).ToList();
            dateranges.DataSource = dateRanges;

        }
    }
}
