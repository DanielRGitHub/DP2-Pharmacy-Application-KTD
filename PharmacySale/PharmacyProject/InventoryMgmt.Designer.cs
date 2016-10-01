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
            this.txtEnterInput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search by:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // enterLabel
            // 
            this.enterLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.enterLabel.Location = new System.Drawing.Point(329, 46);
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
            this.searchByCbx.Location = new System.Drawing.Point(411, 17);
            this.searchByCbx.Name = "searchByCbx";
            this.searchByCbx.Size = new System.Drawing.Size(106, 21);
            this.searchByCbx.TabIndex = 6;
            this.searchByCbx.SelectedIndexChanged += new System.EventHandler(this.searchByCbx_SelectedIndexChanged);
            // 
            // txtEnterInput
            // 
            this.txtEnterInput.Location = new System.Drawing.Point(411, 46);
            this.txtEnterInput.Name = "txtEnterInput";
            this.txtEnterInput.Size = new System.Drawing.Size(106, 20);
            this.txtEnterInput.TabIndex = 7;
            this.txtEnterInput.TextChanged += new System.EventHandler(this.txtEnterInput_TextChanged);
            this.txtEnterInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterInput_KeyPress_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(502, 401);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // InventoryMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 512);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEnterInput);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.ComboBox searchByCbx;
        private System.Windows.Forms.TextBox txtEnterInput;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}