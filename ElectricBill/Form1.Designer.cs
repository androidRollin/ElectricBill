
namespace ElectricBill
{
    partial class fElectribBill
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCustomerArea = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPreviousReading = new System.Windows.Forms.Label();
            this.lblCurrentReading = new System.Windows.Forms.Label();
            this.lblKwHUsed = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblElectricBill = new System.Windows.Forms.Label();
            this.lblSystemCharges = new System.Windows.Forms.Label();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbPreviousReading = new System.Windows.Forms.TextBox();
            this.tbCurrentReading = new System.Windows.Forms.TextBox();
            this.tbKwHUsed = new System.Windows.Forms.TextBox();
            this.tbElectricBill = new System.Windows.Forms.TextBox();
            this.tbSystemCharges = new System.Windows.Forms.TextBox();
            this.tbTotalBill = new System.Windows.Forms.TextBox();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.cbCustomerArea = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCustomerArea
            // 
            this.lblCustomerArea.AutoSize = true;
            this.lblCustomerArea.Location = new System.Drawing.Point(12, 30);
            this.lblCustomerArea.Name = "lblCustomerArea";
            this.lblCustomerArea.Size = new System.Drawing.Size(89, 15);
            this.lblCustomerArea.TabIndex = 0;
            this.lblCustomerArea.Text = "Customer Area:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(12, 65);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(102, 15);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(11, 97);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(97, 15);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblPreviousReading
            // 
            this.lblPreviousReading.AutoSize = true;
            this.lblPreviousReading.Location = new System.Drawing.Point(13, 131);
            this.lblPreviousReading.Name = "lblPreviousReading";
            this.lblPreviousReading.Size = new System.Drawing.Size(101, 15);
            this.lblPreviousReading.TabIndex = 3;
            this.lblPreviousReading.Text = "Previous Reading:";
            this.lblPreviousReading.Click += new System.EventHandler(this.lblPreviousReading_Click);
            // 
            // lblCurrentReading
            // 
            this.lblCurrentReading.AutoSize = true;
            this.lblCurrentReading.Location = new System.Drawing.Point(13, 165);
            this.lblCurrentReading.Name = "lblCurrentReading";
            this.lblCurrentReading.Size = new System.Drawing.Size(96, 15);
            this.lblCurrentReading.TabIndex = 4;
            this.lblCurrentReading.Text = "Current Reading:";
            // 
            // lblKwHUsed
            // 
            this.lblKwHUsed.AutoSize = true;
            this.lblKwHUsed.Location = new System.Drawing.Point(13, 198);
            this.lblKwHUsed.Name = "lblKwHUsed";
            this.lblKwHUsed.Size = new System.Drawing.Size(64, 15);
            this.lblKwHUsed.TabIndex = 5;
            this.lblKwHUsed.Text = "KwH Used:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(13, 229);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(82, 15);
            this.lblAccountType.TabIndex = 6;
            this.lblAccountType.Text = "Account Type:";
            // 
            // lblElectricBill
            // 
            this.lblElectricBill.AutoSize = true;
            this.lblElectricBill.Location = new System.Drawing.Point(13, 264);
            this.lblElectricBill.Name = "lblElectricBill";
            this.lblElectricBill.Size = new System.Drawing.Size(67, 15);
            this.lblElectricBill.TabIndex = 7;
            this.lblElectricBill.Text = "Electric Bill:";
            this.lblElectricBill.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSystemCharges
            // 
            this.lblSystemCharges.AutoSize = true;
            this.lblSystemCharges.Location = new System.Drawing.Point(15, 299);
            this.lblSystemCharges.Name = "lblSystemCharges";
            this.lblSystemCharges.Size = new System.Drawing.Size(94, 15);
            this.lblSystemCharges.TabIndex = 8;
            this.lblSystemCharges.Text = "System Charges:";
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Location = new System.Drawing.Point(15, 332);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(54, 15);
            this.lblTotalBill.TabIndex = 9;
            this.lblTotalBill.Text = "Total Bill:";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(79, 377);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(93, 30);
            this.btnCompute.TabIndex = 10;
            this.btnCompute.Text = "btn-&COMPUTE";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(178, 377);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "btn-CLEA&R";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(277, 377);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "btn-CL&OSE";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Location = new System.Drawing.Point(126, 62);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(211, 23);
            this.tbAccountNumber.TabIndex = 14;
            this.tbAccountNumber.Text = "013606967-9";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(126, 94);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(211, 23);
            this.tbCustomerName.TabIndex = 15;
            this.tbCustomerName.Text = "Juan Dela Cruz";
            this.tbCustomerName.TextChanged += new System.EventHandler(this.tbCustomerName_TextChanged);
            // 
            // tbPreviousReading
            // 
            this.tbPreviousReading.Location = new System.Drawing.Point(126, 128);
            this.tbPreviousReading.Name = "tbPreviousReading";
            this.tbPreviousReading.Size = new System.Drawing.Size(211, 23);
            this.tbPreviousReading.TabIndex = 16;
            this.tbPreviousReading.TextChanged += new System.EventHandler(this.tbPreviousReading_TextChanged);
            // 
            // tbCurrentReading
            // 
            this.tbCurrentReading.Location = new System.Drawing.Point(126, 162);
            this.tbCurrentReading.Name = "tbCurrentReading";
            this.tbCurrentReading.Size = new System.Drawing.Size(211, 23);
            this.tbCurrentReading.TabIndex = 17;
            this.tbCurrentReading.TextChanged += new System.EventHandler(this.tbCurrentReading_TextChanged);
            // 
            // tbKwHUsed
            // 
            this.tbKwHUsed.Enabled = false;
            this.tbKwHUsed.Location = new System.Drawing.Point(126, 195);
            this.tbKwHUsed.Name = "tbKwHUsed";
            this.tbKwHUsed.Size = new System.Drawing.Size(211, 23);
            this.tbKwHUsed.TabIndex = 18;
            // 
            // tbElectricBill
            // 
            this.tbElectricBill.Enabled = false;
            this.tbElectricBill.Location = new System.Drawing.Point(126, 261);
            this.tbElectricBill.Name = "tbElectricBill";
            this.tbElectricBill.Size = new System.Drawing.Size(211, 23);
            this.tbElectricBill.TabIndex = 20;
            // 
            // tbSystemCharges
            // 
            this.tbSystemCharges.Enabled = false;
            this.tbSystemCharges.Location = new System.Drawing.Point(126, 296);
            this.tbSystemCharges.Name = "tbSystemCharges";
            this.tbSystemCharges.Size = new System.Drawing.Size(211, 23);
            this.tbSystemCharges.TabIndex = 21;
            // 
            // tbTotalBill
            // 
            this.tbTotalBill.Enabled = false;
            this.tbTotalBill.Location = new System.Drawing.Point(126, 329);
            this.tbTotalBill.Name = "tbTotalBill";
            this.tbTotalBill.Size = new System.Drawing.Size(211, 23);
            this.tbTotalBill.TabIndex = 22;
            // 
            // cbAccountType
            // 
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Items.AddRange(new object[] {
            "Residential",
            "Commercial ",
            "Industrial"});
            this.cbAccountType.Location = new System.Drawing.Point(126, 226);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(211, 23);
            this.cbAccountType.TabIndex = 23;
            // 
            // cbCustomerArea
            // 
            this.cbCustomerArea.FormattingEnabled = true;
            this.cbCustomerArea.Items.AddRange(new object[] {
            "National Capital Region",
            "Provincial Area"});
            this.cbCustomerArea.Location = new System.Drawing.Point(126, 27);
            this.cbCustomerArea.Name = "cbCustomerArea";
            this.cbCustomerArea.Size = new System.Drawing.Size(211, 23);
            this.cbCustomerArea.TabIndex = 24;
            // 
            // fElectribBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cbCustomerArea);
            this.Controls.Add(this.cbAccountType);
            this.Controls.Add(this.tbTotalBill);
            this.Controls.Add(this.tbSystemCharges);
            this.Controls.Add(this.tbElectricBill);
            this.Controls.Add(this.tbKwHUsed);
            this.Controls.Add(this.tbCurrentReading);
            this.Controls.Add(this.tbPreviousReading);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.tbAccountNumber);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblTotalBill);
            this.Controls.Add(this.lblSystemCharges);
            this.Controls.Add(this.lblElectricBill);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblKwHUsed);
            this.Controls.Add(this.lblCurrentReading);
            this.Controls.Add(this.lblPreviousReading);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblCustomerArea);
            this.Name = "fElectribBill";
            this.Text = "MJRC Electric Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerArea;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPreviousReading;
        private System.Windows.Forms.Label lblCurrentReading;
        private System.Windows.Forms.Label lblKwHUsed;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblElectricBill;
        private System.Windows.Forms.Label lblSystemCharges;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbPreviousReading;
        private System.Windows.Forms.TextBox tbCurrentReading;
        private System.Windows.Forms.TextBox tbKwHUsed;
        private System.Windows.Forms.TextBox tbElectricBill;
        private System.Windows.Forms.TextBox tbSystemCharges;
        private System.Windows.Forms.TextBox tbTotalBill;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.ComboBox cbCustomerArea;
    }
}

