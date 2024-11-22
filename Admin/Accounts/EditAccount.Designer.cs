namespace System
{
    partial class EditAccount
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
            this.btnEditAcc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEditRoles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxEditPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxEIDEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseEditAcc = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseEditAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditAcc
            // 
            this.btnEditAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.btnEditAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAcc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAcc.ForeColor = System.Drawing.Color.White;
            this.btnEditAcc.Location = new System.Drawing.Point(479, 210);
            this.btnEditAcc.Name = "btnEditAcc";
            this.btnEditAcc.Size = new System.Drawing.Size(109, 31);
            this.btnEditAcc.TabIndex = 31;
            this.btnEditAcc.Text = "Save";
            this.btnEditAcc.UseVisualStyleBackColor = false;
            this.btnEditAcc.Click += new System.EventHandler(this.btnEditAcc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.label4.Location = new System.Drawing.Point(28, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Roles";
            // 
            // cbEditRoles
            // 
            this.cbEditRoles.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.cbEditRoles.FormattingEnabled = true;
            this.cbEditRoles.Location = new System.Drawing.Point(21, 175);
            this.cbEditRoles.Name = "cbEditRoles";
            this.cbEditRoles.Size = new System.Drawing.Size(235, 29);
            this.cbEditRoles.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password";
            // 
            // txtBoxEditPass
            // 
            this.txtBoxEditPass.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEditPass.Location = new System.Drawing.Point(19, 121);
            this.txtBoxEditPass.Name = "txtBoxEditPass";
            this.txtBoxEditPass.Size = new System.Drawing.Size(355, 28);
            this.txtBoxEditPass.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Employee ID";
            // 
            // txtBoxEIDEdit
            // 
            this.txtBoxEIDEdit.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEIDEdit.Location = new System.Drawing.Point(19, 72);
            this.txtBoxEIDEdit.Name = "txtBoxEIDEdit";
            this.txtBoxEIDEdit.Size = new System.Drawing.Size(285, 28);
            this.txtBoxEIDEdit.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "Edit account";
            // 
            // btnCloseEditAcc
            // 
            this.btnCloseEditAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseEditAcc.Image = global::System.Properties.Resources.icons8_close_window_32;
            this.btnCloseEditAcc.ImageLocation = "";
            this.btnCloseEditAcc.Location = new System.Drawing.Point(554, 12);
            this.btnCloseEditAcc.Name = "btnCloseEditAcc";
            this.btnCloseEditAcc.Size = new System.Drawing.Size(32, 32);
            this.btnCloseEditAcc.TabIndex = 32;
            this.btnCloseEditAcc.TabStop = false;
            this.btnCloseEditAcc.Click += new System.EventHandler(this.btnCloseEditAcc_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 46);
            this.panel1.TabIndex = 33;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.btnCloseEditAcc);
            this.Controls.Add(this.btnEditAcc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEditRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxEditPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxEIDEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditAccount";
            this.Text = "EditAccount";
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseEditAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Button btnEditAcc;
        private Windows.Forms.Label label4;
        private Windows.Forms.Label label2;
        private Windows.Forms.Label label1;
        private Windows.Forms.Label label3;
        private Windows.Forms.PictureBox btnCloseEditAcc;
        private Windows.Forms.Panel panel1;
        public Windows.Forms.ComboBox cbEditRoles;
        public Windows.Forms.TextBox txtBoxEditPass;
        public Windows.Forms.TextBox txtBoxEIDEdit;
    }
}