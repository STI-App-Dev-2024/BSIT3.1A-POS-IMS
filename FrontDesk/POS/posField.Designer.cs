namespace System.FrontDesk.POS
{
    partial class posField
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
            this.searchBox = new POS__ims.RndPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productPnl = new POS__ims.RndPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.prodSearchMsg = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.productListPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.payGcash = new System.Windows.Forms.RadioButton();
            this.payCash = new System.Windows.Forms.RadioButton();
            this.payBank = new System.Windows.Forms.RadioButton();
            this.paycredit = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.productPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.productListPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderRadius = 10;
            this.searchBox.Controls.Add(this.btnRefresh);
            this.searchBox.Controls.Add(this.prodSearchMsg);
            this.searchBox.Controls.Add(this.productPnl);
            this.searchBox.Controls.Add(this.panel2);
            this.searchBox.ForeColor = System.Drawing.Color.Black;
            this.searchBox.GradientAngle = 90F;
            this.searchBox.GradientBottomColor = System.Drawing.Color.White;
            this.searchBox.GradientTopColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(9, 13);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(750, 656);
            this.searchBox.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.rjTextBox1);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 51);
            this.panel2.TabIndex = 18;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 15;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.Black;
            this.rjTextBox1.Location = new System.Drawing.Point(4, 8);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.PlaceholderText = "Search Products";
            this.rjTextBox1.Size = new System.Drawing.Size(428, 36);
            this.rjTextBox1.TabIndex = 4;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            this.rjTextBox1._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.pictureBox1.Image = global::System.Properties.Resources.icons8_search_28__1_;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(389, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // productPnl
            // 
            this.productPnl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productPnl.BorderRadius = 10;
            this.productPnl.Controls.Add(this.label7);
            this.productPnl.ForeColor = System.Drawing.Color.Black;
            this.productPnl.GradientAngle = 90F;
            this.productPnl.GradientBottomColor = System.Drawing.Color.White;
            this.productPnl.GradientTopColor = System.Drawing.Color.White;
            this.productPnl.Location = new System.Drawing.Point(0, 55);
            this.productPnl.Name = "productPnl";
            this.productPnl.Size = new System.Drawing.Size(750, 601);
            this.productPnl.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(747, 587);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 0;
            // 
            // prodSearchMsg
            // 
            this.prodSearchMsg.AutoSize = true;
            this.prodSearchMsg.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodSearchMsg.ForeColor = System.Drawing.Color.Red;
            this.prodSearchMsg.Location = new System.Drawing.Point(460, 28);
            this.prodSearchMsg.Name = "prodSearchMsg";
            this.prodSearchMsg.Size = new System.Drawing.Size(0, 16);
            this.prodSearchMsg.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = global::System.Properties.Resources.icons8_reload_28;
            this.btnRefresh.ImageLocation = "";
            this.btnRefresh.Location = new System.Drawing.Point(708, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(28, 28);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.TabStop = false;
            // 
            // productListPanel
            // 
            this.productListPanel.BackColor = System.Drawing.Color.White;
            this.productListPanel.Controls.Add(this.label6);
            this.productListPanel.Controls.Add(this.button1);
            this.productListPanel.Controls.Add(this.paycredit);
            this.productListPanel.Controls.Add(this.payBank);
            this.productListPanel.Controls.Add(this.payCash);
            this.productListPanel.Controls.Add(this.payGcash);
            this.productListPanel.Controls.Add(this.label5);
            this.productListPanel.Controls.Add(this.label4);
            this.productListPanel.Controls.Add(this.label3);
            this.productListPanel.Controls.Add(this.label2);
            this.productListPanel.Controls.Add(this.productList);
            this.productListPanel.Controls.Add(this.lblPrice);
            this.productListPanel.Controls.Add(this.label1);
            this.productListPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.productListPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.productListPanel.Location = new System.Drawing.Point(765, 0);
            this.productListPanel.Name = "productListPanel";
            this.productListPanel.Size = new System.Drawing.Size(302, 680);
            this.productListPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrice.Location = new System.Drawing.Point(178, 491);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "00.00";
            // 
            // productList
            // 
            this.productList.Location = new System.Drawing.Point(15, 68);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(275, 407);
            this.productList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(226, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(137, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Qty";
            // 
            // payGcash
            // 
            this.payGcash.AutoSize = true;
            this.payGcash.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payGcash.ForeColor = System.Drawing.Color.Black;
            this.payGcash.Location = new System.Drawing.Point(15, 556);
            this.payGcash.Name = "payGcash";
            this.payGcash.Size = new System.Drawing.Size(62, 21);
            this.payGcash.TabIndex = 1;
            this.payGcash.TabStop = true;
            this.payGcash.Text = "Gcash";
            this.payGcash.UseVisualStyleBackColor = true;
            // 
            // payCash
            // 
            this.payCash.AutoSize = true;
            this.payCash.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payCash.ForeColor = System.Drawing.Color.Black;
            this.payCash.Location = new System.Drawing.Point(15, 588);
            this.payCash.Name = "payCash";
            this.payCash.Size = new System.Drawing.Size(55, 21);
            this.payCash.TabIndex = 8;
            this.payCash.TabStop = true;
            this.payCash.Text = "Cash";
            this.payCash.UseVisualStyleBackColor = true;
            // 
            // payBank
            // 
            this.payBank.AutoSize = true;
            this.payBank.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBank.ForeColor = System.Drawing.Color.Black;
            this.payBank.Location = new System.Drawing.Point(182, 556);
            this.payBank.Name = "payBank";
            this.payBank.Size = new System.Drawing.Size(108, 21);
            this.payBank.TabIndex = 9;
            this.payBank.TabStop = true;
            this.payBank.Text = "Bank Transfer";
            this.payBank.UseVisualStyleBackColor = true;
            // 
            // paycredit
            // 
            this.paycredit.AutoSize = true;
            this.paycredit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paycredit.ForeColor = System.Drawing.Color.Black;
            this.paycredit.Location = new System.Drawing.Point(182, 588);
            this.paycredit.Name = "paycredit";
            this.paycredit.Size = new System.Drawing.Size(94, 21);
            this.paycredit.TabIndex = 10;
            this.paycredit.TabStop = true;
            this.paycredit.Text = "Credit Card";
            this.paycredit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirm Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.label6.Location = new System.Drawing.Point(11, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Payment Method";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productListPanel);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 680);
            this.panel1.TabIndex = 0;
            // 
            // posField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(233)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1067, 680);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "posField";
            this.Text = "posField";
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.productPnl.ResumeLayout(false);
            this.productPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.productListPanel.ResumeLayout(false);
            this.productListPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private POS__ims.RndPanel searchBox;
        private Windows.Forms.PictureBox btnRefresh;
        private Windows.Forms.Label prodSearchMsg;
        private POS__ims.RndPanel productPnl;
        private Windows.Forms.Label label7;
        private Windows.Forms.Panel panel2;
        private Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Windows.Forms.Panel productListPanel;
        private Windows.Forms.Label label6;
        private Windows.Forms.Button button1;
        private Windows.Forms.RadioButton paycredit;
        private Windows.Forms.RadioButton payBank;
        private Windows.Forms.RadioButton payCash;
        private Windows.Forms.RadioButton payGcash;
        private Windows.Forms.Label label5;
        private Windows.Forms.Label label4;
        private Windows.Forms.Label label3;
        private Windows.Forms.Label label2;
        private Windows.Forms.Panel productList;
        private Windows.Forms.Label lblPrice;
        private Windows.Forms.Label label1;
        private Windows.Forms.Panel panel1;
    }
}