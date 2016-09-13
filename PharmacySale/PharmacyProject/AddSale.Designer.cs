namespace PharmacyProject
{
    partial class AddSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.PID_txt = new System.Windows.Forms.TextBox();
            this.Calc_btn = new System.Windows.Forms.Button();
            this.year_txt = new System.Windows.Forms.TextBox();
            this.month_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.View_txt = new System.Windows.Forms.Button();
            this.Product_combo = new System.Windows.Forms.ComboBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Total_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.Quantity_num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Product ID";
            // 
            // PID_txt
            // 
            this.PID_txt.Location = new System.Drawing.Point(336, 123);
            this.PID_txt.Name = "PID_txt";
            this.PID_txt.Size = new System.Drawing.Size(69, 20);
            this.PID_txt.TabIndex = 43;
            // 
            // Calc_btn
            // 
            this.Calc_btn.Location = new System.Drawing.Point(83, 214);
            this.Calc_btn.Name = "Calc_btn";
            this.Calc_btn.Size = new System.Drawing.Size(182, 23);
            this.Calc_btn.TabIndex = 42;
            this.Calc_btn.Text = "Calculate Total";
            this.Calc_btn.UseVisualStyleBackColor = true;
            this.Calc_btn.Click += new System.EventHandler(this.Calc_btn_Click);
            // 
            // year_txt
            // 
            this.year_txt.Location = new System.Drawing.Point(335, 267);
            this.year_txt.Name = "year_txt";
            this.year_txt.Size = new System.Drawing.Size(100, 20);
            this.year_txt.TabIndex = 41;
            // 
            // month_txt
            // 
            this.month_txt.Location = new System.Drawing.Point(336, 217);
            this.month_txt.Name = "month_txt";
            this.month_txt.Size = new System.Drawing.Size(100, 20);
            this.month_txt.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Month";
            // 
            // View_txt
            // 
            this.View_txt.Location = new System.Drawing.Point(257, 319);
            this.View_txt.Name = "View_txt";
            this.View_txt.Size = new System.Drawing.Size(91, 23);
            this.View_txt.TabIndex = 37;
            this.View_txt.Text = "View Entries";
            this.View_txt.UseVisualStyleBackColor = true;
            this.View_txt.Click += new System.EventHandler(this.View_txt_Click);
            // 
            // Product_combo
            // 
            this.Product_combo.FormattingEnabled = true;
            this.Product_combo.Location = new System.Drawing.Point(83, 122);
            this.Product_combo.Name = "Product_combo";
            this.Product_combo.Size = new System.Drawing.Size(237, 21);
            this.Product_combo.TabIndex = 36;
            this.Product_combo.SelectedIndexChanged += new System.EventHandler(this.Product_combo_SelectedIndexChanged);
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(146, 319);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(89, 23);
            this.Submit_btn.TabIndex = 35;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Gross Total ($)";
            // 
            // Total_txt
            // 
            this.Total_txt.Location = new System.Drawing.Point(83, 267);
            this.Total_txt.Name = "Total_txt";
            this.Total_txt.Size = new System.Drawing.Size(124, 20);
            this.Total_txt.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Unit Price ($)";
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(83, 176);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(124, 20);
            this.Price_txt.TabIndex = 31;
            // 
            // Quantity_num
            // 
            this.Quantity_num.Location = new System.Drawing.Point(220, 176);
            this.Quantity_num.Name = "Quantity_num";
            this.Quantity_num.Size = new System.Drawing.Size(41, 20);
            this.Quantity_num.TabIndex = 30;
            this.Quantity_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(64, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Add Sales";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(35, 370);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.Size = new System.Drawing.Size(457, 130);
            this.dataGridView1.TabIndex = 45;
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PID_txt);
            this.Controls.Add(this.Calc_btn);
            this.Controls.Add(this.year_txt);
            this.Controls.Add(this.month_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.View_txt);
            this.Controls.Add(this.Product_combo);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Total_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.Quantity_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(192, 131);
            this.Name = "AddSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddSale";
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PID_txt;
        private System.Windows.Forms.Button Calc_btn;
        private System.Windows.Forms.TextBox year_txt;
        private System.Windows.Forms.TextBox month_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button View_txt;
        private System.Windows.Forms.ComboBox Product_combo;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Total_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.NumericUpDown Quantity_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}