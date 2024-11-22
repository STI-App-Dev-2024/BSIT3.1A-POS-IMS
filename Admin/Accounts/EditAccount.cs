using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class EditAccount : Form
    {
        fitDB db = new fitDB();
        public Point mouseLocation;
        public EditAccount()
        {
            InitializeComponent();
            String[] roles = { "FrontDesk", "Admin" };

            foreach (String role in roles)
            {
                cbEditRoles.Items.Add(role);
            }
        }

        private void btnCloseA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseEditAcc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btnEditAcc_Click(object sender, EventArgs e)
        {
            try {
                if (String.IsNullOrEmpty(txtBoxEditPass.Text) && String.IsNullOrEmpty(cbEditRoles.Text))
                {
                    throw new FormatException("Password and Role Textbox cannot be empty.");
                }

                else if (String.IsNullOrEmpty(txtBoxEditPass.Text))
                {
                    throw new FormatException("Password Textbox cannot be empty.");
                }

                else if (String.IsNullOrEmpty(cbEditRoles.Text))
                {
                    throw new FormatException("Role Textbox cannot be empty.");
                }

                else if (!(cbEditRoles.Text == "FrontDesk" || cbEditRoles.Text == "Admin"))
                {
                    throw new FormatException("Role can only be FrontDesk or Admin.");
                }

                else if (MessageBox.Show("Are you sure you want to update this account?", "Account Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int employeeID = Convert.ToInt32(txtBoxEIDEdit.Text);
                    string password = txtBoxEditPass.Text;
                    string role = cbEditRoles.Text;

                    db.setConn("datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb");

                    db.getConn().Open();

                    db.AddQuery($"UPDATE fitwhitedb.accounts SET `role` = '{role}', `password` = '{password}' WHERE `employeeID` LIKE '{employeeID}'");

                    db.getCMD().ExecuteNonQuery();

                    db.getConn().Close();

                    Clear();

                    MessageBox.Show("Account successfully updated.", "Account Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }

                else
                {

                }

            }  
            catch(FormatException FE)
            {
                popMsg psg = new popMsg(FE.Message, "Error");
                psg.ShowDialog();
            }
        }

        public void Clear()
        {
            txtBoxEditPass.Clear();
            cbEditRoles.Text = "";
            btnEditAcc.Enabled = false;
        }
    }
}
