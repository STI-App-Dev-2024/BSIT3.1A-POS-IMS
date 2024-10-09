namespace System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.rndPanel1 = new POS__ims.RndPanel();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxEID = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showPass = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rndPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rndPanel1
            // 
            this.rndPanel1.BackColor = System.Drawing.Color.White;
            this.rndPanel1.BorderRadius = 20;
            this.rndPanel1.Controls.Add(this.showPass);
            this.rndPanel1.Controls.Add(this.txtBoxPass);
            this.rndPanel1.Controls.Add(this.txtBoxEID);
            this.rndPanel1.Controls.Add(this.pictureBox1);
            this.rndPanel1.Controls.Add(this.btnLogin);
            this.rndPanel1.ForeColor = System.Drawing.Color.Black;
            this.rndPanel1.GradientAngle = 90F;
            this.rndPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.rndPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.rndPanel1.Location = new System.Drawing.Point(396, 112);
            this.rndPanel1.Name = "rndPanel1";
            this.rndPanel1.Size = new System.Drawing.Size(450, 500);
            this.rndPanel1.TabIndex = 0;
            this.rndPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.rndPanel1_Paint);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.txtBoxPass.Location = new System.Drawing.Point(85, 298);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(288, 30);
            this.txtBoxPass.TabIndex = 5;
            this.txtBoxPass.Enter += new System.EventHandler(this.txtBoxPass_Enter_1);
            this.txtBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPass_KeyPress);
            this.txtBoxPass.Leave += new System.EventHandler(this.txtBoxPass_Leave_1);
            // 
            // txtBoxEID
            // 
            this.txtBoxEID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.txtBoxEID.Location = new System.Drawing.Point(85, 247);
            this.txtBoxEID.Name = "txtBoxEID";
            this.txtBoxEID.Size = new System.Drawing.Size(288, 30);
            this.txtBoxEID.TabIndex = 4;
            this.txtBoxEID.Enter += new System.EventHandler(this.txtBoxEID_Enter_1);
            this.txtBoxEID.Leave += new System.EventHandler(this.txtBoxEID_Leave_1);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.btnLogin.Location = new System.Drawing.Point(160, 366);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 683);
            this.panel1.TabIndex = 1;
            // 
            // showPass
            // 
            this.showPass.BackColor = System.Drawing.Color.Transparent;
            this.showPass.Image = global::System.Properties.Resources.hidden;
            this.showPass.Location = new System.Drawing.Point(379, 298);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(30, 30);
            this.showPass.TabIndex = 6;
            this.showPass.TabStop = false;
            this.showPass.Click += new System.EventHandler(this.showPass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.rndPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Login_MouseClick);
            this.rndPanel1.ResumeLayout(false);
            this.rndPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private POS__ims.RndPanel rndPanel1;
        private Windows.Forms.Button btnLogin;
        private Windows.Forms.PictureBox pictureBox1;
        private Windows.Forms.TextBox txtBoxPass;
        private Windows.Forms.TextBox txtBoxEID;
        private Windows.Forms.PictureBox showPass;
        private Windows.Forms.Panel panel1;
    }
}

