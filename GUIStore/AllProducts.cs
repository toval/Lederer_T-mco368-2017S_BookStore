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

    public partial class AllProducts : Form
    {
        public String BookId { get; private set; }

        DataClasses1DataContext context;
        public AllProducts()
        {
            InitializeComponent();
            context = new DataClasses1DataContext();

        }

        private void AllProducts_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'sTOREDataSet2.BOOK' table. 
            this.bOOKTableAdapter2.Fill(this.sTOREDataSet2.BOOK);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            BookId = context.BOOKs.Where(c => c.Book_Name
                .Equals(allBooks.Rows[e.RowIndex].Cells["bookNameDataGridViewTextBoxColumn"].Value))
                .Select(c=>c.Book_ID)
                .First();

            displayBook.Text = allBooks.Rows[e.RowIndex].Cells["bookNameDataGridViewTextBoxColumn"].Value.ToString();
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            DateTimePicker date = new DateTimePicker();
           // DateTime date = new DateTime();
            int qty;

            //making sure the user enters an integer
            if (int.TryParse(textBox.Text, out qty))
            {
                if (qty > 0)
                {
                    if (qty <= context.BOOKs.Select(b => b.Book_Qty).First())
                    {
                        //check balance-if able to buy it, then change balance amount
                        if (context.CUSTOMERs.Where(c => c.Cust_ID == CustLogin.Id)
                            .Select(c => c.Cust_Balance).First() +
                          (context.BOOKs.Where(b => b.Book_ID.Equals(BookId))
                          .Select(b => b.Book_Price).First() * qty) <= MyAccount.Credit)
                        {

                            //now need to subtract qty
                            BOOK book = context.BOOKs.Single(b => b.Book_ID == BookId);
                            book.Book_Qty -= qty;


                            //increase the balance
                            CUSTOMER cust = context.CUSTOMERs.Single(c => c.Cust_ID == CustLogin.Id);
                            cust.Cust_Balance += context.BOOKs.Where(b => b.Book_ID == BookId)
                                .Select(b => b.Book_Price).First() * qty;
                          
                            //insert into the invoice table    
                            INVOICE invoice = new INVOICE
                            {
                                Book_ID = BookId,
                                Cust_ID = CustLogin.Id,
                                Inv_Total = context.BOOKs.Where(b => b.Book_ID == BookId)
                                                          .Select(b => b.Book_Price).First() * qty,
                                Inv_Date = date.Value,
                                Inv_Qty = qty
                                
                            };
                            context.INVOICEs.InsertOnSubmit(invoice);
                            //submit ALL the changes...
                            context.SubmitChanges();
                            MessageBox.Show("Item is being shipped!");
                        }//end if
                        else
                        {
                            MessageBox.Show("You have gone over your Balance");
                        }
                    }//end if
                    else
                    {
                        if (context.BOOKs.Select(b => b.Book_Qty).First() == 0) MessageBox.Show("Out of stock\nPick another book");
                        else MessageBox.Show("Not enough in stock, reenter quantity");
                    }
                }//end if
                else
                {
                    MessageBox.Show("Enter quantity amount");
                }
            }//end if
            
        }

        private void allBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyAccount accnt = new MyAccount();
            accnt.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting Store, have a nice day!");
            Application.Exit();
        }

        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAllPurchasesWithinCertainDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DateRangePurchases date = new DateRangePurchases();
            date.Show();   
        }

        private void viewAllPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllPurchases purchase = new AllPurchases();
            purchase.Show();
        }

        private void viewAllPurchasesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PriceRangePurchases priceRange = new PriceRangePurchases();
            priceRange.Show();
        }
    }
}
