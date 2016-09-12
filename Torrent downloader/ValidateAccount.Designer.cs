namespace Torrent_downloader
{
    partial class ValidateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidateAccount));
            this.labelValidateAccount = new System.Windows.Forms.Label();
            this.labelFillOutFields = new System.Windows.Forms.Label();
            this.labelNotBeCharged = new System.Windows.Forms.Label();
            this.labelExpiryDate = new System.Windows.Forms.Label();
            this.labelCVV2 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.mtbCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.mtbCCV2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelValidateAccount
            // 
            this.labelValidateAccount.AutoSize = true;
            this.labelValidateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValidateAccount.Location = new System.Drawing.Point(11, 19);
            this.labelValidateAccount.Name = "labelValidateAccount";
            this.labelValidateAccount.Size = new System.Drawing.Size(146, 20);
            this.labelValidateAccount.TabIndex = 0;
            this.labelValidateAccount.Text = "Validate Account";
            // 
            // labelFillOutFields
            // 
            this.labelFillOutFields.AutoSize = true;
            this.labelFillOutFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFillOutFields.Location = new System.Drawing.Point(12, 50);
            this.labelFillOutFields.Name = "labelFillOutFields";
            this.labelFillOutFields.Size = new System.Drawing.Size(398, 16);
            this.labelFillOutFields.TabIndex = 14;
            this.labelFillOutFields.Text = "Your credit card will                                       for validating your a" +
    "ccount.";
            // 
            // labelNotBeCharged
            // 
            this.labelNotBeCharged.AutoSize = true;
            this.labelNotBeCharged.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotBeCharged.Location = new System.Drawing.Point(130, 52);
            this.labelNotBeCharged.Name = "labelNotBeCharged";
            this.labelNotBeCharged.Size = new System.Drawing.Size(117, 13);
            this.labelNotBeCharged.TabIndex = 15;
            this.labelNotBeCharged.Text = "NOT BE CHARGED";
            // 
            // labelExpiryDate
            // 
            this.labelExpiryDate.AutoSize = true;
            this.labelExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExpiryDate.Location = new System.Drawing.Point(12, 127);
            this.labelExpiryDate.Name = "labelExpiryDate";
            this.labelExpiryDate.Size = new System.Drawing.Size(77, 16);
            this.labelExpiryDate.TabIndex = 16;
            this.labelExpiryDate.Text = "Expiry Date";
            // 
            // labelCVV2
            // 
            this.labelCVV2.AutoSize = true;
            this.labelCVV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCVV2.Location = new System.Drawing.Point(118, 214);
            this.labelCVV2.Name = "labelCVV2";
            this.labelCVV2.Size = new System.Drawing.Size(255, 13);
            this.labelCVV2.TabIndex = 18;
            this.labelCVV2.Text = "The CVV2 is a 3 digit code on the back of your card.";
            // 
            // btnContinue
            // 
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Image = ((System.Drawing.Image)(resources.GetObject("btnContinue.Image")));
            this.btnContinue.Location = new System.Drawing.Point(15, 259);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(170, 45);
            this.btnContinue.TabIndex = 19;
            this.btnContinue.TabStop = false;
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(15, 161);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(207, 27);
            this.cbMonth.TabIndex = 21;
            this.cbMonth.TabStop = false;
            this.cbMonth.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbMonth_DrawItem);
            this.cbMonth.DropDown += new System.EventHandler(this.cbMonth_DropDown);
            // 
            // cbYear
            // 
            this.cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.cbYear.Location = new System.Drawing.Point(222, 161);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(207, 27);
            this.cbYear.TabIndex = 22;
            this.cbYear.TabStop = false;
            this.cbYear.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbYear_DrawItem);
            this.cbYear.DropDown += new System.EventHandler(this.cbYear_DropDown);
            // 
            // mtbCardNumber
            // 
            this.mtbCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbCardNumber.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mtbCardNumber.Location = new System.Drawing.Point(15, 85);
            this.mtbCardNumber.Name = "mtbCardNumber";
            this.mtbCardNumber.Size = new System.Drawing.Size(414, 26);
            this.mtbCardNumber.TabIndex = 23;
            this.mtbCardNumber.TabStop = false;
            this.mtbCardNumber.Enter += new System.EventHandler(this.mtbCardNumber_Enter);
            // 
            // mtbCCV2
            // 
            this.mtbCCV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbCCV2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mtbCCV2.Location = new System.Drawing.Point(15, 206);
            this.mtbCCV2.Name = "mtbCCV2";
            this.mtbCCV2.Size = new System.Drawing.Size(58, 26);
            this.mtbCCV2.TabIndex = 24;
            this.mtbCCV2.TabStop = false;
            this.mtbCCV2.Enter += new System.EventHandler(this.mtbCCV2_Enter);
            // 
            // ValidateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(444, 329);
            this.Controls.Add(this.mtbCCV2);
            this.Controls.Add(this.mtbCardNumber);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.labelCVV2);
            this.Controls.Add(this.labelExpiryDate);
            this.Controls.Add(this.labelNotBeCharged);
            this.Controls.Add(this.labelFillOutFields);
            this.Controls.Add(this.labelValidateAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ValidateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validate Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValidateAccount;
        private System.Windows.Forms.Label labelFillOutFields;
        private System.Windows.Forms.Label labelNotBeCharged;
        private System.Windows.Forms.Label labelExpiryDate;
        private System.Windows.Forms.Label labelCVV2;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.MaskedTextBox mtbCardNumber;
        private System.Windows.Forms.MaskedTextBox mtbCCV2;
    }
}