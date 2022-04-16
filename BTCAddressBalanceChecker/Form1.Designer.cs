namespace BTCAddressBalanceChecker
{
    partial class BTCAddressBalanceCheckerForm
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
            this.HABTCAddressLB = new System.Windows.Forms.ListBox();
            this.HAAddBTCAddressBTN = new System.Windows.Forms.Button();
            this.HABTCAddressTB = new System.Windows.Forms.TextBox();
            this.HACloseBTN = new System.Windows.Forms.Button();
            this.HAMinimizeBTN = new System.Windows.Forms.Button();
            this.HARemoveBTCAddressBTN = new System.Windows.Forms.Button();
            this.HACheckAddressesBTN = new System.Windows.Forms.Button();
            this.HACheckAddressBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HABTCAddressLB
            // 
            this.HABTCAddressLB.BackColor = System.Drawing.Color.Black;
            this.HABTCAddressLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HABTCAddressLB.ForeColor = System.Drawing.Color.Lime;
            this.HABTCAddressLB.FormattingEnabled = true;
            this.HABTCAddressLB.Location = new System.Drawing.Point(104, 112);
            this.HABTCAddressLB.Name = "HABTCAddressLB";
            this.HABTCAddressLB.Size = new System.Drawing.Size(120, 93);
            this.HABTCAddressLB.TabIndex = 0;
            // 
            // HAAddBTCAddressBTN
            // 
            this.HAAddBTCAddressBTN.BackColor = System.Drawing.Color.Black;
            this.HAAddBTCAddressBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HAAddBTCAddressBTN.Location = new System.Drawing.Point(84, 83);
            this.HAAddBTCAddressBTN.Name = "HAAddBTCAddressBTN";
            this.HAAddBTCAddressBTN.Size = new System.Drawing.Size(74, 23);
            this.HAAddBTCAddressBTN.TabIndex = 1;
            this.HAAddBTCAddressBTN.Text = "Add";
            this.HAAddBTCAddressBTN.UseVisualStyleBackColor = false;
            this.HAAddBTCAddressBTN.Click += new System.EventHandler(this.HAAddBTCAddressBTN_Click);
            // 
            // HABTCAddressTB
            // 
            this.HABTCAddressTB.BackColor = System.Drawing.Color.Black;
            this.HABTCAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HABTCAddressTB.ForeColor = System.Drawing.Color.Lime;
            this.HABTCAddressTB.Location = new System.Drawing.Point(104, 57);
            this.HABTCAddressTB.Name = "HABTCAddressTB";
            this.HABTCAddressTB.Size = new System.Drawing.Size(120, 20);
            this.HABTCAddressTB.TabIndex = 2;
            this.HABTCAddressTB.Text = "BTC Address";
            this.HABTCAddressTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HACloseBTN
            // 
            this.HACloseBTN.BackColor = System.Drawing.Color.Black;
            this.HACloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HACloseBTN.Location = new System.Drawing.Point(289, 12);
            this.HACloseBTN.Name = "HACloseBTN";
            this.HACloseBTN.Size = new System.Drawing.Size(27, 27);
            this.HACloseBTN.TabIndex = 3;
            this.HACloseBTN.Text = "X";
            this.HACloseBTN.UseVisualStyleBackColor = false;
            this.HACloseBTN.Click += new System.EventHandler(this.HACloseBTN_Click);
            // 
            // HAMinimizeBTN
            // 
            this.HAMinimizeBTN.BackColor = System.Drawing.Color.Black;
            this.HAMinimizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HAMinimizeBTN.Location = new System.Drawing.Point(256, 12);
            this.HAMinimizeBTN.Name = "HAMinimizeBTN";
            this.HAMinimizeBTN.Size = new System.Drawing.Size(27, 27);
            this.HAMinimizeBTN.TabIndex = 4;
            this.HAMinimizeBTN.Text = "_";
            this.HAMinimizeBTN.UseVisualStyleBackColor = false;
            this.HAMinimizeBTN.Click += new System.EventHandler(this.HAMinimizeBTN_Click);
            // 
            // HARemoveBTCAddressBTN
            // 
            this.HARemoveBTCAddressBTN.BackColor = System.Drawing.Color.Black;
            this.HARemoveBTCAddressBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HARemoveBTCAddressBTN.Location = new System.Drawing.Point(164, 83);
            this.HARemoveBTCAddressBTN.Name = "HARemoveBTCAddressBTN";
            this.HARemoveBTCAddressBTN.Size = new System.Drawing.Size(74, 23);
            this.HARemoveBTCAddressBTN.TabIndex = 5;
            this.HARemoveBTCAddressBTN.Text = "Remove";
            this.HARemoveBTCAddressBTN.UseVisualStyleBackColor = false;
            this.HARemoveBTCAddressBTN.Click += new System.EventHandler(this.HARemoveBTCAddressBTN_Click);
            // 
            // HACheckAddressesBTN
            // 
            this.HACheckAddressesBTN.BackColor = System.Drawing.Color.Black;
            this.HACheckAddressesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HACheckAddressesBTN.Location = new System.Drawing.Point(84, 211);
            this.HACheckAddressesBTN.Name = "HACheckAddressesBTN";
            this.HACheckAddressesBTN.Size = new System.Drawing.Size(156, 23);
            this.HACheckAddressesBTN.TabIndex = 6;
            this.HACheckAddressesBTN.Text = "Check Addresses Balance";
            this.HACheckAddressesBTN.UseVisualStyleBackColor = false;
            this.HACheckAddressesBTN.Click += new System.EventHandler(this.HACheckAddressesBTN_Click);
            // 
            // HACheckAddressBTN
            // 
            this.HACheckAddressBTN.BackColor = System.Drawing.Color.Black;
            this.HACheckAddressBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HACheckAddressBTN.Location = new System.Drawing.Point(84, 240);
            this.HACheckAddressBTN.Name = "HACheckAddressBTN";
            this.HACheckAddressBTN.Size = new System.Drawing.Size(156, 23);
            this.HACheckAddressBTN.TabIndex = 7;
            this.HACheckAddressBTN.Text = "Check Address Balance";
            this.HACheckAddressBTN.UseVisualStyleBackColor = false;
            this.HACheckAddressBTN.Click += new System.EventHandler(this.HACheckAddressBTN_Click);
            // 
            // BTCAddressBalanceCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(328, 282);
            this.Controls.Add(this.HACheckAddressBTN);
            this.Controls.Add(this.HACheckAddressesBTN);
            this.Controls.Add(this.HARemoveBTCAddressBTN);
            this.Controls.Add(this.HAMinimizeBTN);
            this.Controls.Add(this.HACloseBTN);
            this.Controls.Add(this.HABTCAddressTB);
            this.Controls.Add(this.HAAddBTCAddressBTN);
            this.Controls.Add(this.HABTCAddressLB);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BTCAddressBalanceCheckerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTCAddressBalanceCheckerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HABTCAddressLB;
        private System.Windows.Forms.Button HAAddBTCAddressBTN;
        private System.Windows.Forms.TextBox HABTCAddressTB;
        private System.Windows.Forms.Button HACloseBTN;
        private System.Windows.Forms.Button HAMinimizeBTN;
        private System.Windows.Forms.Button HARemoveBTCAddressBTN;
        private System.Windows.Forms.Button HACheckAddressesBTN;
        private System.Windows.Forms.Button HACheckAddressBTN;
    }
}

