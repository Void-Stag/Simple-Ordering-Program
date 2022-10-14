
namespace Assignment_3
{
    partial class Form1
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
            this.cboCoffee = new System.Windows.Forms.ComboBox();
            this.cboTea = new System.Windows.Forms.ComboBox();
            this.cboCake = new System.Windows.Forms.ComboBox();
            this.lstOrderlist = new System.Windows.Forms.ListBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTea = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.lblCake = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCoffee
            // 
            this.cboCoffee.FormattingEnabled = true;
            this.cboCoffee.Items.AddRange(new object[] {
            "Filter £2.10",
            "Espresso £2.25",
            "Cappachino £2.70",
            "Americano £2.35",
            "Latte £2.80",
            "Mocha £2.95",
            "Hot Chocolate £2.95",
            "Iced Coffee £2.95",
            "Shot of Caramel £0.50",
            "Shot of Hazelnut Syrup £0.50",
            "Shot of Vanilla  £0.50"});
            this.cboCoffee.Location = new System.Drawing.Point(99, 251);
            this.cboCoffee.Name = "cboCoffee";
            this.cboCoffee.Size = new System.Drawing.Size(165, 21);
            this.cboCoffee.TabIndex = 0;
            this.cboCoffee.SelectedIndexChanged += new System.EventHandler(this.cboCoffee_SelectedIndexChanged);
            // 
            // cboTea
            // 
            this.cboTea.FormattingEnabled = true;
            this.cboTea.Items.AddRange(new object[] {
            "English Breakfast Regular £2.65",
            "English Breakfast Decaf £2.95",
            "Earl Grey £2.65",
            "Darjeeling £2.65",
            "Peppermint £2.65",
            "Chamomile £2.70",
            "Jasmine Dragon Peal £2.95",
            "Rooibos £2.95",
            "Chai Tea £2.70"});
            this.cboTea.Location = new System.Drawing.Point(99, 129);
            this.cboTea.Name = "cboTea";
            this.cboTea.Size = new System.Drawing.Size(180, 21);
            this.cboTea.TabIndex = 1;
            this.cboTea.SelectedIndexChanged += new System.EventHandler(this.cboTea_SelectedIndexChanged);
            // 
            // cboCake
            // 
            this.cboCake.FormattingEnabled = true;
            this.cboCake.Items.AddRange(new object[] {
            "Organic Carrot Cake £2.28",
            "Victoria Sponge £1.99",
            "Sticky Apple Caramel £2.28",
            "Dutch Chunky Apple Flan £2.18",
            "Chocolate Fudge Cake £1.96",
            "Chocolate & Coconut Sponge £0.82"});
            this.cboCake.Location = new System.Drawing.Point(344, 129);
            this.cboCake.Name = "cboCake";
            this.cboCake.Size = new System.Drawing.Size(200, 21);
            this.cboCake.TabIndex = 2;
            this.cboCake.SelectedIndexChanged += new System.EventHandler(this.cboCake_SelectedIndexChanged);
            // 
            // lstOrderlist
            // 
            this.lstOrderlist.FormattingEnabled = true;
            this.lstOrderlist.Location = new System.Drawing.Point(550, 31);
            this.lstOrderlist.Name = "lstOrderlist";
            this.lstOrderlist.Size = new System.Drawing.Size(238, 212);
            this.lstOrderlist.TabIndex = 3;
            // 
            // btnPay
            // 
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPay.Location = new System.Drawing.Point(566, 366);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(97, 23);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Confirm Payment";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTea
            // 
            this.lblTea.AutoSize = true;
            this.lblTea.Location = new System.Drawing.Point(96, 98);
            this.lblTea.Name = "lblTea";
            this.lblTea.Size = new System.Drawing.Size(26, 13);
            this.lblTea.TabIndex = 6;
            this.lblTea.Text = "Tea";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCoffee.Location = new System.Drawing.Point(102, 225);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(38, 13);
            this.lblCoffee.TabIndex = 7;
            this.lblCoffee.Text = "Coffee";
            // 
            // lblCake
            // 
            this.lblCake.AutoSize = true;
            this.lblCake.Location = new System.Drawing.Point(349, 98);
            this.lblCake.Name = "lblCake";
            this.lblCake.Size = new System.Drawing.Size(32, 13);
            this.lblCake.TabIndex = 8;
            this.lblCake.Text = "Cake";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(602, 303);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 12;
            this.lblCost.Text = "£0.0";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(604, 250);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblCake);
            this.Controls.Add(this.lblCoffee);
            this.Controls.Add(this.lblTea);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lstOrderlist);
            this.Controls.Add(this.cboCake);
            this.Controls.Add(this.cboTea);
            this.Controls.Add(this.cboCoffee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCoffee;
        private System.Windows.Forms.ComboBox cboTea;
        private System.Windows.Forms.ComboBox cboCake;
        private System.Windows.Forms.ListBox lstOrderlist;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTea;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label lblCake;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnRemove;
    }
}

