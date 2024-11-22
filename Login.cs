using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace System
{
    public partial class Login : Form
    {

        fitDB conn = new fitDB();

        private int eID;
        private string pass, userID, level;

        public Login()
        {
            InitializeComponent();
            placeholder();
            txtBoxPass.PasswordChar = '\u25cf';
            showPass.Image = Properties.Resources.hidden;
        }

        private void rndPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void placeholder()
        {
            if (!(txtBoxPass.Text == "Password"))
            {
                if (string.IsNullOrWhiteSpace(txtBoxPass.Text))
                {
                    txtBoxPass.Text = "Password";
                    txtBoxPass.ForeColor = Color.Gray;
                }
                else
                {
                    txtBoxPass.ForeColor = Color.Black;
                }
            }
            else
            {
                txtBoxPass.Text = "Password";
            }

            if (!(txtBoxEID.Text == "Employee ID"))
            {
                if (string.IsNullOrWhiteSpace(txtBoxEID.Text))
                {
                    txtBoxEID.Text = "Employee ID";
                    txtBoxEID.ForeColor = Color.Gray;
                }

                else
                {
                    txtBoxEID.ForeColor = Color.Black;
                }
            }
            else
            {
                txtBoxEID.Text = "Employee ID";
            }
        }
        private void Login_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void txtBoxPass_Enter(object sender, EventArgs e)
        {
            if (txtBoxPass.Text == "Password")
            {
                txtBoxPass.Text = "";
                txtBoxPass.ForeColor = Color.Black;
            }
        }

        private void txtBoxPass_Leave(object sender, EventArgs e)
        {
            placeholder();
        }

        private void txtBoxEID_Enter(object sender, EventArgs e)
        {
            if (txtBoxEID.Text == "Employee ID")
            {
                txtBoxEID.Text = "";
                txtBoxEID.ForeColor = Color.Black;
            }
        }

        private void txtBoxEID_Leave(object sender, EventArgs e)
        {
            placeholder();
        }

        private void showPass_Click(object sender, EventArgs e)
        {
            if (txtBoxPass.PasswordChar == '\u25cf')
            {
                txtBoxPass.PasswordChar = '\0';
                showPass.Image = Properties.Resources.show;
            }
            else
            {
                txtBoxPass.PasswordChar = '\u25cf';
                showPass.Image = Properties.Resources.hidden;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                eID = int.Parse(txtBoxEID.Text);
                conn.Open();
                string query = $"SELECT * FROM accounts WHERE employeeID  ='{eID}' AND password ='{txtBoxPass.Text}'";
                MySqlDataReader row;
                row = conn.ExecuteReader(query);

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        userID = row["employeeID"].ToString();
                        pass = row["password"].ToString();
                        level = row["role"].ToString();
                    }

                    if (level.Equals("Admin"))
                    {
                        popMsg pop = new popMsg($"Logging in with an admin account: {userID}", "Login Message");
                        pop.StartPosition = FormStartPosition.Manual;
                        pop.Location = new Point(
                            this.Location.X + (this.Width - pop.Width) / 2,
                            this.Location.Y + (this.Height - pop.Height) / 2
                        );
                        pop.ShowDialog();

                        DashBoard dash = new DashBoard();
                        dash.Show();
                        this.Hide();
                    }

                    else if (level.Equals("FrontDesk"))
                    {
                        popMsg pop = new popMsg($"Logging in with an employee account: {userID}", "Login Message");
                        pop.StartPosition = FormStartPosition.Manual;
                        pop.Location = new Point(
                            this.Location.X + (this.Width - pop.Width) / 2,
                            this.Location.Y + (this.Height - pop.Height) / 2
                        );
                        pop.Show();

                        FrontDesk.POS.DashboardFD fd = new FrontDesk.POS.DashboardFD();
                        fd.Show();
                        this.Hide();
                    }
                }
                else
                {

                    logFail.Text = "Login Failed: Invalid employee id or password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
