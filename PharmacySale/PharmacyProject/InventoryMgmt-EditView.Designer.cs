namespace PharmacyProject
{
    partial class InventoryMgmt_EditView
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxQuick = new System.Windows.Forms.GroupBox();
            this.btnSubNum = new System.Windows.Forms.Button();
            this.btnAddNum = new System.Windows.Forms.Button();
            this.btnDisableThreshold = new System.Windows.Forms.Button();
            this.btnEnableThreshold = new System.Windows.Forms.Button();
            this.btnSub5 = new System.Windows.Forms.Button();
            this.btnAdd5 = new System.Windows.Forms.Button();
            this.btnSub1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnClrStock = new System.Windows.Forms.Button();
            this.gbxManual = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.btnStockManual = new System.Windows.Forms.Button();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManualQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loadingInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxQuick.SuspendLayout();
            this.gbxManual.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID: ";
            // 
            // lblProductID
            // 
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProductID.Location = new System.Drawing.Point(145, 22);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(351, 29);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "0";
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProductName.Location = new System.Drawing.Point(145, 52);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(351, 26);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "I am the product name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name: ";
            // 
            // gbxQuick
            // 
            this.gbxQuick.Controls.Add(this.btnSubNum);
            this.gbxQuick.Controls.Add(this.btnAddNum);
            this.gbxQuick.Controls.Add(this.btnDisableThreshold);
            this.gbxQuick.Controls.Add(this.btnEnableThreshold);
            this.gbxQuick.Controls.Add(this.btnSub5);
            this.gbxQuick.Controls.Add(this.btnAdd5);
            this.gbxQuick.Controls.Add(this.btnSub1);
            this.gbxQuick.Controls.Add(this.btnAdd1);
            this.gbxQuick.Enabled = false;
            this.gbxQuick.Location = new System.Drawing.Point(12, 81);
            this.gbxQuick.Name = "gbxQuick";
            this.gbxQuick.Size = new System.Drawing.Size(242, 196);
            this.gbxQuick.TabIndex = 4;
            this.gbxQuick.TabStop = false;
            this.gbxQuick.Text = "Quick Stock Actions";
            this.gbxQuick.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSubNum
            // 
            this.btnSubNum.Location = new System.Drawing.Point(124, 97);
            this.btnSubNum.Name = "btnSubNum";
            this.btnSubNum.Size = new System.Drawing.Size(93, 23);
            this.btnSubNum.TabIndex = 8;
            this.btnSubNum.Text = "Subtract #";
            this.btnSubNum.UseVisualStyleBackColor = true;
            this.btnSubNum.Click += new System.EventHandler(this.btnSubNum_Click);
            // 
            // btnAddNum
            // 
            this.btnAddNum.Location = new System.Drawing.Point(24, 97);
            this.btnAddNum.Name = "btnAddNum";
            this.btnAddNum.Size = new System.Drawing.Size(93, 23);
            this.btnAddNum.TabIndex = 7;
            this.btnAddNum.Text = "Add #";
            this.btnAddNum.UseVisualStyleBackColor = true;
            this.btnAddNum.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnDisableThreshold
            // 
            this.btnDisableThreshold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDisableThreshold.Location = new System.Drawing.Point(124, 142);
            this.btnDisableThreshold.Name = "btnDisableThreshold";
            this.btnDisableThreshold.Size = new System.Drawing.Size(94, 41);
            this.btnDisableThreshold.TabIndex = 6;
            this.btnDisableThreshold.Text = "Disable Threshold";
            this.btnDisableThreshold.UseVisualStyleBackColor = true;
            this.btnDisableThreshold.Click += new System.EventHandler(this.btnDisableThreshold_Click);
            // 
            // btnEnableThreshold
            // 
            this.btnEnableThreshold.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEnableThreshold.Location = new System.Drawing.Point(24, 142);
            this.btnEnableThreshold.Name = "btnEnableThreshold";
            this.btnEnableThreshold.Size = new System.Drawing.Size(94, 41);
            this.btnEnableThreshold.TabIndex = 5;
            this.btnEnableThreshold.Text = "Enable Threshold";
            this.btnEnableThreshold.UseVisualStyleBackColor = true;
            this.btnEnableThreshold.Click += new System.EventHandler(this.btnEnableThreshold_Click);
            // 
            // btnSub5
            // 
            this.btnSub5.Location = new System.Drawing.Point(123, 48);
            this.btnSub5.Name = "btnSub5";
            this.btnSub5.Size = new System.Drawing.Size(94, 23);
            this.btnSub5.TabIndex = 3;
            this.btnSub5.Text = "Subtract 5";
            this.btnSub5.UseVisualStyleBackColor = true;
            this.btnSub5.Click += new System.EventHandler(this.btnSub5_Click);
            // 
            // btnAdd5
            // 
            this.btnAdd5.Location = new System.Drawing.Point(23, 48);
            this.btnAdd5.Name = "btnAdd5";
            this.btnAdd5.Size = new System.Drawing.Size(94, 23);
            this.btnAdd5.TabIndex = 2;
            this.btnAdd5.Text = "Add 5";
            this.btnAdd5.UseVisualStyleBackColor = true;
            this.btnAdd5.Click += new System.EventHandler(this.btnAdd5_Click);
            // 
            // btnSub1
            // 
            this.btnSub1.Location = new System.Drawing.Point(123, 19);
            this.btnSub1.Name = "btnSub1";
            this.btnSub1.Size = new System.Drawing.Size(94, 23);
            this.btnSub1.TabIndex = 1;
            this.btnSub1.Text = "Subtract 1";
            this.btnSub1.UseVisualStyleBackColor = true;
            this.btnSub1.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(23, 19);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(94, 23);
            this.btnAdd1.TabIndex = 0;
            this.btnAdd1.Text = "Add 1";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnClrStock
            // 
            this.btnClrStock.ForeColor = System.Drawing.Color.Red;
            this.btnClrStock.Location = new System.Drawing.Point(13, 160);
            this.btnClrStock.Name = "btnClrStock";
            this.btnClrStock.Size = new System.Drawing.Size(216, 23);
            this.btnClrStock.TabIndex = 4;
            this.btnClrStock.Text = "Clear Stock to 0";
            this.btnClrStock.UseVisualStyleBackColor = true;
            this.btnClrStock.Click += new System.EventHandler(this.btnClrStock_Click);
            // 
            // gbxManual
            // 
            this.gbxManual.Controls.Add(this.button9);
            this.gbxManual.Controls.Add(this.btnStockManual);
            this.gbxManual.Controls.Add(this.txtThreshold);
            this.gbxManual.Controls.Add(this.label4);
            this.gbxManual.Controls.Add(this.btnClrStock);
            this.gbxManual.Controls.Add(this.txtManualQty);
            this.gbxManual.Controls.Add(this.label2);
            this.gbxManual.Enabled = false;
            this.gbxManual.Location = new System.Drawing.Point(260, 81);
            this.gbxManual.Name = "gbxManual";
            this.gbxManual.Size = new System.Drawing.Size(242, 196);
            this.gbxManual.TabIndex = 5;
            this.gbxManual.TabStop = false;
            this.gbxManual.Text = "Manual Stock Actions";
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button9.Location = new System.Drawing.Point(13, 120);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(216, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "Set Threshold Manually";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btnStockManual
            // 
            this.btnStockManual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStockManual.Location = new System.Drawing.Point(13, 52);
            this.btnStockManual.Name = "btnStockManual";
            this.btnStockManual.Size = new System.Drawing.Size(216, 23);
            this.btnStockManual.TabIndex = 4;
            this.btnStockManual.Text = "Set Stock Manually";
            this.btnStockManual.UseVisualStyleBackColor = true;
            this.btnStockManual.Click += new System.EventHandler(this.btnStockManual_Click);
            // 
            // txtThreshold
            // 
            this.txtThreshold.Location = new System.Drawing.Point(115, 94);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(121, 20);
            this.txtThreshold.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity Threshold:";
            // 
            // txtManualQty
            // 
            this.txtManualQty.Location = new System.Drawing.Point(115, 26);
            this.txtManualQty.Name = "txtManualQty";
            this.txtManualQty.Size = new System.Drawing.Size(121, 20);
            this.txtManualQty.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity of Stock:";
            // 
            // loadingInfo
            // 
            this.loadingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingInfo.Location = new System.Drawing.Point(12, 280);
            this.loadingInfo.Name = "loadingInfo";
            this.loadingInfo.Size = new System.Drawing.Size(357, 34);
            this.loadingInfo.TabIndex = 6;
            this.loadingInfo.Text = "Loading Product Data....";
            this.loadingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(429, 288);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // InventoryMgmt_EditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 323);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.loadingInfo);
            this.Controls.Add(this.gbxManual);
            this.Controls.Add(this.gbxQuick);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "InventoryMgmt_EditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Product Inventory Data";
            this.Load += new System.EventHandler(this.InventoryMgmt_EditView_Load);
            this.gbxQuick.ResumeLayout(false);
            this.gbxManual.ResumeLayout(false);
            this.gbxManual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxQuick;
        private System.Windows.Forms.Button btnSub1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnDisableThreshold;
        private System.Windows.Forms.Button btnEnableThreshold;
        private System.Windows.Forms.Button btnClrStock;
        private System.Windows.Forms.Button btnSub5;
        private System.Windows.Forms.Button btnAdd5;
        private System.Windows.Forms.Button btnSubNum;
        private System.Windows.Forms.Button btnAddNum;
        private System.Windows.Forms.GroupBox gbxManual;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnStockManual;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManualQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loadingInfo;
        private System.Windows.Forms.Button btnClose;
    }
}