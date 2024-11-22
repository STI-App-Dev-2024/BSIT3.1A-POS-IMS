namespace System
{
    partial class AddAccount
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxEIDAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAddPass = new System.Windows.Forms.TextBox();
            this.cbAddRoles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.btnCloseAddAcc = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAddAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Add account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Employee ID";
            // 
            // txtBoxEIDAdd
            // 
            this.txtBoxEIDAdd.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEIDAdd.Location = new System.Drawing.Point(19, 72);
            this.txtBoxEIDAdd.Name = "txtBoxEIDAdd";
            this.txtBoxEIDAdd.Size = new System.Drawing.Size(285, 28);
            this.txtBoxEIDAdd.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password";
            // 
            // txtBoxAddPass
            // 
            this.txtBoxAddPass.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddPass.Location = new System.Drawing.Point(19, 121);
            this.txtBoxAddPass.Name = "txtBoxAddPass";
            this.txtBoxAddPass.Size = new System.Drawing.Size(355, 28);
            this.txtBoxAddPass.TabIndex = 19;
            // 
            // cbAddRoles
            // 
            this.cbAddRoles.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.cbAddRoles.FormattingEnabled = true;
            this.cbAddRoles.Location = new System.Drawing.Point(21, 175);
            this.cbAddRoles.Name = "cbAddRoles";
            this.cbAddRoles.Size = new System.Drawing.Size(235, 29);
            this.cbAddRoles.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.label4.Location = new System.Drawing.Point(28, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Roles";
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.btnAddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcc.ForeColor = System.Drawing.Color.White;
            this.btnAddAcc.Location = new System.Drawing.Point(479, 210);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(109, 31);
            this.btnAddAcc.TabIndex = 23;
            this.btnAddAcc.Text = "Add";
            this.btnAddAcc.UseVisualStyleBackColor = false;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // btnCloseAddAcc
            // 
            this.btnCloseAddAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseAddAcc.Image = global::System.Properties.Resources.icons8_close_window_32;
            this.btnCloseAddAcc.ImageLocation = "";
            this.btnCloseAddAcc.Location = new System.Drawing.Point(554, 9);
            this.btnCloseAddAcc.Name = "btnCloseAddAcc";
            this.btnCloseAddAcc.Size = new System.Drawing.Size(32, 32);
            this.btnCloseAddAcc.TabIndex = 24;
            this.btnCloseAddAcc.TabStop = false;
            this.btnCloseAddAcc.Click += new System.EventHandler(this.btnCloseAddAcc_Click);
            // 
            // panelTop
            // 
            this.panelTop.Location = new System.Drawing.Point(-1, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(601, 60);
            this.panelTop.TabIndex = 25;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.btnCloseAddAcc);
            this.Controls.Add(this.btnAddAcc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAddRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxAddPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxEIDAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAccount";
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAddAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Label label3;
        private Windows.Forms.Label label1;
        private Windows.Forms.TextBox txtBoxEIDAdd;
        private Windows.Forms.Label label2;
        private Windows.Forms.TextBox txtBoxAddPass;
        private Windows.Forms.ComboBox cbAddRoles;
        private Windows.Forms.Label label4;
        private Windows.Forms.Button btnAddAcc;
        private Windows.Forms.PictureBox btnCloseAddAcc;
        private Windows.Forms.Panel panelTop;
    }
}