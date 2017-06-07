namespace GUIStore
{
    partial class PriceRangePurchases
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
            this.label1 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.TextBox();
            this.pricerange = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pricerange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(32, 51);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(39, 20);
            this.min.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "to  $";
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(111, 51);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(39, 20);
            this.max.TabIndex = 4;
            // 
            // pricerange
            // 
            this.pricerange.AllowUserToAddRows = false;
            this.pricerange.AllowUserToDeleteRows = false;
            this.pricerange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pricerange.Location = new System.Drawing.Point(16, 131);
            this.pricerange.Name = "pricerange";
            this.pricerange.ReadOnly = true;
            this.pricerange.Size = new System.Drawing.Size(485, 171);
            this.pricerange.TabIndex = 7;
            this.pricerange.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pricerange_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUIStore.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(168, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PriceRangePurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pricerange);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.max);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.min);
            this.Controls.Add(this.label1);
            this.Name = "PriceRangePurchases";
            this.Text = "PriceRangePurchases";
            ((System.ComponentModel.ISupportInitialize)(this.pricerange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView pricerange;
        private System.Windows.Forms.Button button1;
    }
}