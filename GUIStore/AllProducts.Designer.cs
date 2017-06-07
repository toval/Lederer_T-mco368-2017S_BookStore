namespace GUIStore
{
    partial class AllProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.allBooks = new System.Windows.Forms.DataGridView();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sTOREDataSet2 = new GUIStore.STOREDataSet2();
            this.purchase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.displayBook = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllPurchasesWithinCertainDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllPurchasesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKTableAdapter2 = new GUIStore.STOREDataSet2TableAdapters.BOOKTableAdapter();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.allBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // allBooks
            // 
            this.allBooks.AllowUserToAddRows = false;
            this.allBooks.AllowUserToDeleteRows = false;
            this.allBooks.AutoGenerateColumns = false;
            this.allBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookNameDataGridViewTextBoxColumn,
            this.bookAuthorNameDataGridViewTextBoxColumn,
            this.bookPriceDataGridViewTextBoxColumn});
            this.allBooks.DataSource = this.bOOKBindingSource2;
            this.allBooks.Location = new System.Drawing.Point(0, -1);
            this.allBooks.Name = "allBooks";
            this.allBooks.ReadOnly = true;
            this.allBooks.Size = new System.Drawing.Size(344, 278);
            this.allBooks.TabIndex = 0;
            this.allBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.allBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allBooks_CellContentClick);
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Title";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookAuthorNameDataGridViewTextBoxColumn
            // 
            this.bookAuthorNameDataGridViewTextBoxColumn.DataPropertyName = "Book_AuthorName";
            this.bookAuthorNameDataGridViewTextBoxColumn.HeaderText = "Author";
            this.bookAuthorNameDataGridViewTextBoxColumn.Name = "bookAuthorNameDataGridViewTextBoxColumn";
            this.bookAuthorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookPriceDataGridViewTextBoxColumn
            // 
            this.bookPriceDataGridViewTextBoxColumn.DataPropertyName = "Book_Price";
            this.bookPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.bookPriceDataGridViewTextBoxColumn.Name = "bookPriceDataGridViewTextBoxColumn";
            this.bookPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOOKBindingSource2
            // 
            this.bOOKBindingSource2.DataMember = "BOOK";
            this.bOOKBindingSource2.DataSource = this.sTOREDataSet2;
            // 
            // sTOREDataSet2
            // 
            this.sTOREDataSet2.DataSetName = "STOREDataSet2";
            this.sTOREDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchase
            // 
            this.purchase.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase.Location = new System.Drawing.Point(480, 209);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(74, 30);
            this.purchase.TabIndex = 1;
            this.purchase.Text = "Purchase";
            this.purchase.UseVisualStyleBackColor = true;
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qty";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(521, 166);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(33, 20);
            this.textBox.TabIndex = 4;
            this.textBox.Text = "1";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // displayBook
            // 
            this.displayBook.AutoSize = true;
            this.displayBook.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBook.Location = new System.Drawing.Point(476, 133);
            this.displayBook.Name = "displayBook";
            this.displayBook.Size = new System.Drawing.Size(0, 19);
            this.displayBook.TabIndex = 6;
            this.displayBook.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.purchasesToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(455, -1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(275, 29);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.logoutToolStripMenuItem.Text = "My Account";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // purchasesToolStripMenuItem
            // 
            this.purchasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllPurchasesToolStripMenuItem,
            this.viewAllPurchasesWithinCertainDateRangeToolStripMenuItem,
            this.viewAllPurchasesToolStripMenuItem1});
            this.purchasesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.purchasesToolStripMenuItem.Name = "purchasesToolStripMenuItem";
            this.purchasesToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.purchasesToolStripMenuItem.Text = "Purchases";
            this.purchasesToolStripMenuItem.Click += new System.EventHandler(this.purchasesToolStripMenuItem_Click);
            // 
            // viewAllPurchasesToolStripMenuItem
            // 
            this.viewAllPurchasesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.viewAllPurchasesToolStripMenuItem.Name = "viewAllPurchasesToolStripMenuItem";
            this.viewAllPurchasesToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.viewAllPurchasesToolStripMenuItem.Text = "View all purchases";
            this.viewAllPurchasesToolStripMenuItem.Click += new System.EventHandler(this.viewAllPurchasesToolStripMenuItem_Click);
            // 
            // viewAllPurchasesWithinCertainDateRangeToolStripMenuItem
            // 
            this.viewAllPurchasesWithinCertainDateRangeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.viewAllPurchasesWithinCertainDateRangeToolStripMenuItem.Name = "viewAllPurchasesWithinCertainDateRangeToolStripMenuItem";
            this.viewAllPurchasesWithinCertainDateRangeToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.viewAllPurchasesWithinCertainDateRangeToolStripMenuItem.Text = "Date range purchases";
            this.viewAllPurchasesWithinCertainDateRangeToolStripMenuItem.Click += new System.EventHandler(this.viewAllPurchasesWithinCertainDateRangeToolStripMenuItem_Click);
            // 
            // viewAllPurchasesToolStripMenuItem1
            // 
            this.viewAllPurchasesToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.viewAllPurchasesToolStripMenuItem1.Name = "viewAllPurchasesToolStripMenuItem1";
            this.viewAllPurchasesToolStripMenuItem1.Size = new System.Drawing.Size(216, 24);
            this.viewAllPurchasesToolStripMenuItem1.Text = "Price range purchases ";
            this.viewAllPurchasesToolStripMenuItem1.Click += new System.EventHandler(this.viewAllPurchasesToolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(71, 25);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // bOOKTableAdapter2
            // 
            this.bOOKTableAdapter2.ClearBeforeFill = true;
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            // 
            // bOOKBindingSource1
            // 
            this.bOOKBindingSource1.DataMember = "BOOK";
            // 
            // AllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 277);
            this.Controls.Add(this.displayBook);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.allBooks);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AllProducts";
            this.Text = ".";
            this.Load += new System.EventHandler(this.AllProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allBooks;
   //     private STOREDataSet sTOREDataSet;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
     //   private STOREDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.Button purchase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label displayBook;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem purchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllPurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllPurchasesWithinCertainDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllPurchasesToolStripMenuItem1;
       // private STOREDataSet1 sTOREDataSet1;
        private System.Windows.Forms.BindingSource bOOKBindingSource1;
        //private STOREDataSet1TableAdapters.BOOKTableAdapter bOOKTableAdapter1;
        private STOREDataSet2 sTOREDataSet2;
        private System.Windows.Forms.BindingSource bOOKBindingSource2;
        private STOREDataSet2TableAdapters.BOOKTableAdapter bOOKTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceDataGridViewTextBoxColumn;
    }
}