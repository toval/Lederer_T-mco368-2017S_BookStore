namespace GUIStore
{
    partial class DateRangePurchases
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateranges = new System.Windows.Forms.DataGridView();
            this.min = new System.Windows.Forms.DateTimePicker();
            this.max = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dateranges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateranges
            // 
            this.dateranges.AllowUserToAddRows = false;
            this.dateranges.AllowUserToDeleteRows = false;
            this.dateranges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateranges.Location = new System.Drawing.Point(2, 98);
            this.dateranges.Name = "dateranges";
            this.dateranges.ReadOnly = true;
            this.dateranges.Size = new System.Drawing.Size(533, 187);
            this.dateranges.TabIndex = 3;
            this.dateranges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dateranges_CellContentClick);
            // 
            // min
            // 
            this.min.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.min.Location = new System.Drawing.Point(16, 49);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(108, 20);
            this.min.TabIndex = 4;
            // 
            // max
            // 
            this.max.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.max.Location = new System.Drawing.Point(154, 49);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(108, 20);
            this.max.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUIStore.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(268, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "to";
            // 
            // DateRangePurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.dateranges);
            this.Controls.Add(this.button1);
            this.Name = "DateRangePurchases";
            this.Text = "DataRangePurchases";
            ((System.ComponentModel.ISupportInitialize)(this.dateranges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dateranges;
        private System.Windows.Forms.DateTimePicker min;
        private System.Windows.Forms.DateTimePicker max;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}