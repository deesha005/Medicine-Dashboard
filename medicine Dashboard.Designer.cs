namespace medicine.dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.addm_lb = new System.Windows.Forms.Label();
            this.searchm_lb = new System.Windows.Forms.Label();
            this.medicinecart_lb = new System.Windows.Forms.Label();
            this.billing_lb = new System.Windows.Forms.Label();
            this.searchp_lb = new System.Windows.Forms.Label();
            this.addm_btn = new System.Windows.Forms.Button();
            this.showm_btn = new System.Windows.Forms.Button();
            this.medicinehistory_btn = new System.Windows.Forms.Button();
            this.addtocart_btn = new System.Windows.Forms.Button();
            this.showcart_btn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.showbill_btn = new System.Windows.Forms.Button();
            this.client_hist_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Dashboard";
            // 
            // addm_lb
            // 
            this.addm_lb.AutoSize = true;
            this.addm_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addm_lb.Location = new System.Drawing.Point(70, 120);
            this.addm_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addm_lb.Name = "addm_lb";
            this.addm_lb.Size = new System.Drawing.Size(117, 20);
            this.addm_lb.TabIndex = 1;
            this.addm_lb.Text = "Add Medicine\r\n";
            // 
            // searchm_lb
            // 
            this.searchm_lb.AutoSize = true;
            this.searchm_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchm_lb.Location = new System.Drawing.Point(280, 120);
            this.searchm_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchm_lb.Name = "searchm_lb";
            this.searchm_lb.Size = new System.Drawing.Size(142, 20);
            this.searchm_lb.TabIndex = 2;
            this.searchm_lb.Text = "Search Medicine";
            // 
            // medicinecart_lb
            // 
            this.medicinecart_lb.AutoSize = true;
            this.medicinecart_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicinecart_lb.Location = new System.Drawing.Point(62, 323);
            this.medicinecart_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.medicinecart_lb.Name = "medicinecart_lb";
            this.medicinecart_lb.Size = new System.Drawing.Size(119, 20);
            this.medicinecart_lb.TabIndex = 3;
            this.medicinecart_lb.Text = "Medicine Cart";
            // 
            // billing_lb
            // 
            this.billing_lb.AutoSize = true;
            this.billing_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billing_lb.Location = new System.Drawing.Point(310, 332);
            this.billing_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.billing_lb.Name = "billing_lb";
            this.billing_lb.Size = new System.Drawing.Size(57, 20);
            this.billing_lb.TabIndex = 4;
            this.billing_lb.Text = "Billing";
            // 
            // searchp_lb
            // 
            this.searchp_lb.AutoSize = true;
            this.searchp_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchp_lb.Location = new System.Drawing.Point(301, 146);
            this.searchp_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchp_lb.Name = "searchp_lb";
            this.searchp_lb.Size = new System.Drawing.Size(95, 13);
            this.searchp_lb.TabIndex = 5;
            this.searchp_lb.Text = "Search Product";
            // 
            // addm_btn
            // 
            this.addm_btn.Location = new System.Drawing.Point(82, 172);
            this.addm_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addm_btn.Name = "addm_btn";
            this.addm_btn.Size = new System.Drawing.Size(87, 19);
            this.addm_btn.TabIndex = 6;
            this.addm_btn.Text = "Add Medicine";
            this.addm_btn.UseVisualStyleBackColor = true;
            this.addm_btn.Click += new System.EventHandler(this.addm_btn_Click);
            // 
            // showm_btn
            // 
            this.showm_btn.Location = new System.Drawing.Point(82, 206);
            this.showm_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showm_btn.Name = "showm_btn";
            this.showm_btn.Size = new System.Drawing.Size(87, 19);
            this.showm_btn.TabIndex = 7;
            this.showm_btn.Text = "Show Medicine";
            this.showm_btn.UseVisualStyleBackColor = true;
            this.showm_btn.Click += new System.EventHandler(this.showm_btn_Click);
            // 
            // medicinehistory_btn
            // 
            this.medicinehistory_btn.Location = new System.Drawing.Point(82, 238);
            this.medicinehistory_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.medicinehistory_btn.Name = "medicinehistory_btn";
            this.medicinehistory_btn.Size = new System.Drawing.Size(87, 19);
            this.medicinehistory_btn.TabIndex = 8;
            this.medicinehistory_btn.Text = "Medicine History";
            this.medicinehistory_btn.UseVisualStyleBackColor = true;
            this.medicinehistory_btn.Click += new System.EventHandler(this.medicinehistory_btn_Click);
            // 
            // addtocart_btn
            // 
            this.addtocart_btn.Location = new System.Drawing.Point(74, 370);
            this.addtocart_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addtocart_btn.Name = "addtocart_btn";
            this.addtocart_btn.Size = new System.Drawing.Size(87, 19);
            this.addtocart_btn.TabIndex = 9;
            this.addtocart_btn.Text = "Add to Cart";
            this.addtocart_btn.UseVisualStyleBackColor = true;
            this.addtocart_btn.Click += new System.EventHandler(this.addtocart_btn_Click);
            // 
            // showcart_btn
            // 
            this.showcart_btn.Location = new System.Drawing.Point(74, 412);
            this.showcart_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showcart_btn.Name = "showcart_btn";
            this.showcart_btn.Size = new System.Drawing.Size(87, 19);
            this.showcart_btn.TabIndex = 10;
            this.showcart_btn.Text = " Show Cart";
            this.showcart_btn.UseVisualStyleBackColor = true;
            this.showcart_btn.Click += new System.EventHandler(this.showcart_btn_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(250, 172);
            this.textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(204, 29);
            this.textBox.TabIndex = 11;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(303, 212);
            this.search_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(87, 19);
            this.search_btn.TabIndex = 12;
            this.search_btn.Text = " Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // showbill_btn
            // 
            this.showbill_btn.Location = new System.Drawing.Point(298, 371);
            this.showbill_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showbill_btn.Name = "showbill_btn";
            this.showbill_btn.Size = new System.Drawing.Size(87, 19);
            this.showbill_btn.TabIndex = 14;
            this.showbill_btn.Text = " Add bill";
            this.showbill_btn.UseVisualStyleBackColor = true;
            this.showbill_btn.Click += new System.EventHandler(this.showbill_btn_Click);
            // 
            // client_hist_btn
            // 
            this.client_hist_btn.Location = new System.Drawing.Point(298, 405);
            this.client_hist_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.client_hist_btn.Name = "client_hist_btn";
            this.client_hist_btn.Size = new System.Drawing.Size(87, 19);
            this.client_hist_btn.TabIndex = 15;
            this.client_hist_btn.Text = "Client History";
            this.client_hist_btn.UseVisualStyleBackColor = true;
            this.client_hist_btn.Click += new System.EventHandler(this.client_hist_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 506);
            this.Controls.Add(this.client_hist_btn);
            this.Controls.Add(this.showbill_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.showcart_btn);
            this.Controls.Add(this.addtocart_btn);
            this.Controls.Add(this.medicinehistory_btn);
            this.Controls.Add(this.showm_btn);
            this.Controls.Add(this.addm_btn);
            this.Controls.Add(this.searchp_lb);
            this.Controls.Add(this.billing_lb);
            this.Controls.Add(this.medicinecart_lb);
            this.Controls.Add(this.searchm_lb);
            this.Controls.Add(this.addm_lb);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addm_lb;
        private System.Windows.Forms.Label searchm_lb;
        private System.Windows.Forms.Label medicinecart_lb;
        private System.Windows.Forms.Label billing_lb;
        private System.Windows.Forms.Label searchp_lb;
        private System.Windows.Forms.Button addm_btn;
        private System.Windows.Forms.Button showm_btn;
        private System.Windows.Forms.Button medicinehistory_btn;
        private System.Windows.Forms.Button addtocart_btn;
        private System.Windows.Forms.Button showcart_btn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button showbill_btn;
        private System.Windows.Forms.Button client_hist_btn;
    }
}

