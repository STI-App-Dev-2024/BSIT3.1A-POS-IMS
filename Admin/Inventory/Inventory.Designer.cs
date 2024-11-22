namespace System
{
    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridProductList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnAddAcc = new System.Windows.Forms.PictureBox();
            this.btnRefreshAccount = new System.Windows.Forms.PictureBox();
            this.btnSearchAccount = new System.Windows.Forms.PictureBox();
            this.txtBoxSearchProduct = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::System.Properties.Resources.edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::System.Properties.Resources.edit;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inventory";
            // 
            // dataGridProductList
            // 
            this.dataGridProductList.AllowUserToAddRows = false;
            this.dataGridProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProductList.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProductList.ColumnHeadersHeight = 30;
            this.dataGridProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Edit,
            this.Delete});
            this.dataGridProductList.EnableHeadersVisualStyles = false;
            this.dataGridProductList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.dataGridProductList.Location = new System.Drawing.Point(13, 86);
            this.dataGridProductList.Name = "dataGridProductList";
            this.dataGridProductList.RowHeadersVisible = false;
            this.dataGridProductList.Size = new System.Drawing.Size(1042, 582);
            this.dataGridProductList.TabIndex = 11;
            this.dataGridProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "ProductID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 98;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 127;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.Width = 88;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::System.Properties.Resources.edit;
            this.Edit.Name = "Edit";
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 17;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::System.Properties.Resources._8723171_xcircle_close_icon;
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.btnAddAcc);
            this.panel9.Controls.Add(this.btnRefreshAccount);
            this.panel9.Controls.Add(this.btnSearchAccount);
            this.panel9.Controls.Add(this.txtBoxSearchProduct);
            this.panel9.Controls.Add(this.dataGridProductList);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1067, 680);
            this.panel9.TabIndex = 8;
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAcc.Image = global::System.Properties.Resources.icons8_plus_28__1_;
            this.btnAddAcc.ImageLocation = "";
            this.btnAddAcc.Location = new System.Drawing.Point(1027, 52);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(28, 28);
            this.btnAddAcc.TabIndex = 22;
            this.btnAddAcc.TabStop = false;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // btnRefreshAccount
            // 
            this.btnRefreshAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefreshAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshAccount.Image = global::System.Properties.Resources.icons8_reload_28;
            this.btnRefreshAccount.ImageLocation = "";
            this.btnRefreshAccount.Location = new System.Drawing.Point(993, 52);
            this.btnRefreshAccount.Name = "btnRefreshAccount";
            this.btnRefreshAccount.Size = new System.Drawing.Size(28, 28);
            this.btnRefreshAccount.TabIndex = 21;
            this.btnRefreshAccount.TabStop = false;
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchAccount.Image = global::System.Properties.Resources.icons8_search_28__2_;
            this.btnSearchAccount.ImageLocation = "";
            this.btnSearchAccount.Location = new System.Drawing.Point(959, 52);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(28, 28);
            this.btnSearchAccount.TabIndex = 20;
            this.btnSearchAccount.TabStop = false;
            // 
            // txtBoxSearchProduct
            // 
            this.txtBoxSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBoxSearchProduct.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchProduct.Location = new System.Drawing.Point(733, 52);
            this.txtBoxSearchProduct.Name = "txtBoxSearchProduct";
            this.txtBoxSearchProduct.Size = new System.Drawing.Size(220, 28);
            this.txtBoxSearchProduct.TabIndex = 19;
            this.txtBoxSearchProduct.TextChanged += new System.EventHandler(this.txtBoxSearchProduct_TextChanged);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 680);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Windows.Forms.Label label3;
        private Windows.Forms.Label label2;
        private Windows.Forms.DataGridView dataGridProductList;
        private Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Windows.Forms.DataGridViewImageColumn Edit;
        private Windows.Forms.DataGridViewImageColumn Delete;
        private Windows.Forms.Panel panel9;
        private Windows.Forms.PictureBox btnAddAcc;
        private Windows.Forms.PictureBox btnRefreshAccount;
        private Windows.Forms.PictureBox btnSearchAccount;
        private Windows.Forms.TextBox txtBoxSearchProduct;
    }
}