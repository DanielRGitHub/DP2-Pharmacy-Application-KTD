namespace PharmacyProject
{
    partial class InventoryMgmt
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enterLabel = new System.Windows.Forms.Label();
            this.searchByCbx = new System.Windows.Forms.ComboBox();
            this.enterInput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateToLabel = new System.Windows.Forms.Label();
            this.dateFilterToDP = new System.Windows.Forms.DateTimePicker();
            this.dateFromLabel = new System.Windows.Forms.Label();
            this.dateFilterFromDP = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Displaying All Products";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search by:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // enterLabel
            // 
            this.enterLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.enterLabel.Location = new System.Drawing.Point(48, 123);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(76, 20);
            this.enterLabel.TabIndex = 5;
            this.enterLabel.Text = "Enter ID:";
            this.enterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enterLabel.Click += new System.EventHandler(this.enterLabel_Click);
            // 
            // searchByCbx
            // 
            this.searchByCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByCbx.FormattingEnabled = true;
            this.searchByCbx.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.searchByCbx.Location = new System.Drawing.Point(130, 94);
            this.searchByCbx.Name = "searchByCbx";
            this.searchByCbx.Size = new System.Drawing.Size(106, 21);
            this.searchByCbx.TabIndex = 6;
            this.searchByCbx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // enterInput
            // 
            this.enterInput.Location = new System.Drawing.Point(130, 123);
            this.enterInput.Name = "enterInput";
            this.enterInput.Size = new System.Drawing.Size(106, 20);
            this.enterInput.TabIndex = 7;
            this.enterInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.enterInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterInput_KeyPress_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 255);
            this.dataGridView1.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Quantity",
            "Threshold (Number)",
            "Threshold (%)"});
            this.comboBox1.Location = new System.Drawing.Point(130, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sort by:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.dateToLabel);
            this.groupBox1.Controls.Add(this.dateFilterToDP);
            this.groupBox1.Controls.Add(this.dateFromLabel);
            this.groupBox1.Controls.Add(this.dateFilterFromDP);
            this.groupBox1.Location = new System.Drawing.Point(271, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 141);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Filter";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // dateToLabel
            // 
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.Enabled = false;
            this.dateToLabel.Location = new System.Drawing.Point(15, 87);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(23, 13);
            this.dateToLabel.TabIndex = 17;
            this.dateToLabel.Text = "To:";
            // 
            // dateFilterToDP
            // 
            this.dateFilterToDP.Enabled = false;
            this.dateFilterToDP.Location = new System.Drawing.Point(18, 103);
            this.dateFilterToDP.Name = "dateFilterToDP";
            this.dateFilterToDP.Size = new System.Drawing.Size(193, 20);
            this.dateFilterToDP.TabIndex = 16;
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.AutoSize = true;
            this.dateFromLabel.Enabled = false;
            this.dateFromLabel.Location = new System.Drawing.Point(15, 43);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Size = new System.Drawing.Size(33, 13);
            this.dateFromLabel.TabIndex = 15;
            this.dateFromLabel.Text = "From:";
            // 
            // dateFilterFromDP
            // 
            this.dateFilterFromDP.Enabled = false;
            this.dateFilterFromDP.Location = new System.Drawing.Point(18, 59);
            this.dateFilterFromDP.Name = "dateFilterFromDP";
            this.dateFilterFromDP.Size = new System.Drawing.Size(193, 20);
            this.dateFilterFromDP.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InventoryMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 512);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.enterInput);
            this.Controls.Add(this.searchByCbx);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(192, 131);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InventoryMgmt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InventoryMgmt";
            this.Load += new System.EventHandler(this.InventoryMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.ComboBox searchByCbx;
        private System.Windows.Forms.TextBox enterInput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label dateToLabel;
        private System.Windows.Forms.DateTimePicker dateFilterToDP;
        private System.Windows.Forms.Label dateFromLabel;
        private System.Windows.Forms.DateTimePicker dateFilterFromDP;
        private System.Windows.Forms.Button button1;
    }
}