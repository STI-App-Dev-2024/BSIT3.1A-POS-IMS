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
    public partial class AddAccount : Form
    {
        public Point mouseLocation;
        fitDB db = new fitDB();
        public AddAccount()
        {
            InitializeComponent();
            String[] roles = { "FrontDesk", "Admin" };

            foreach (String role in roles)
            {
                cbAddRoles.Items.Add(role);
            }
        }

        private void btnCloseAddAcc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            try
            {
                string pattern = @"^[a-zA-Z0-9]{8,16}$";
                
                if (String.IsNullOrEmpty(txtBoxEIDAdd.Text) && String.IsNullOrEmpty(txtBoxAddPass.Text) && String.IsNullOrEmpty(cbAddRoles.Text))
                {
                    throw new FormatException("Password and Role Textbox cannot be empty.");
                }

                else if (String.IsNullOrEmpty(txtBoxEIDAdd.Text))
                {
                    throw new FormatException("Employee ID Textbox cannot be empty.");
                }

                else if (String.IsNullOrEmpty(txtBoxAddPass.Text))
                {
                    throw new FormatException("Password Textbox cannot be empty.");
                }

                else if (String.IsNullOrEmpty(cbAddRoles.Text))
                {
                    throw new FormatException("Role Textbox cannot be empty.");
                }

                else if (!(cbAddRoles.Text == "FrontDesk" || cbAddRoles.Text == "Admin"))
                {
                    throw new FormatException("Role can only be FrontDesk or Admin.");
                }

                else if(!Regex.IsMatch(txtBoxAddPass.Text, pattern))
                {
                    throw new FormatException($"Password can only contain 8-16 characters.");
                }

                else if (MessageBox.Show("Are you sure you want to add this account?", "Add Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int employeeID = Convert.ToInt32(txtBoxEIDAdd.Text);
                    string password = txtBoxAddPass.Text;
                    string role = cbAddRoles.Text;

                    db.setConn("datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb");

                    db.getConn().Open();

                    db.AddQuery($"INSERT INTO fitwhitedb.accounts(`employeeID`, `password`, `role`) VALUES('{employeeID}', '{password}', '{role}')");

                    db.getCMD().ExecuteNonQuery();

                    db.getConn().Close();

                    Clear();

                    MessageBox.Show("Account successfully added.", "Account Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    btnAddAcc.Enabled = true;

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
            txtBoxEIDAdd.Clear();
            txtBoxAddPass.Clear();
            cbAddRoles.Text = "";
            btnAddAcc.Enabled = false;
        }
    }
}
