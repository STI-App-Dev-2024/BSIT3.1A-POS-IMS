using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace System
{
    public partial class Login : Form
    {
        private string placeholderText = "EmployeeID";
        private string placeholderText2 = "Password";

        fitDB conn = new fitDB();

        private int eID;
        private string pass, userID, level;

        public Login()
        {
            InitializeComponent();
            txtBoxEID.Text = placeholderText;
            txtBoxEID.ForeColor = Color.Gray; 

            txtBoxEID.Enter += txtBoxEID_Enter;
            txtBoxEID.Leave += txtBoxEID_Leave;

            txtBoxPass.Text = placeholderText2;
            txtBoxPass.ForeColor = Color.Gray; 

            txtBoxPass.Enter += txtBoxPass_Enter;
            txtBoxPass.Leave += txtBoxPass_Leave;
        }

        private void rndPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            showPass.Tag = "hidden";
        }

        private void txtBoxEID_Enter(object sender, EventArgs e)
        {
            if (txtBoxEID.Text == placeholderText)
            {
                txtBoxEID.Text = "";
                txtBoxEID.ForeColor = Color.Black; 
            }
        }

        private void txtBoxEID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxEID.Text))
            {
                txtBoxEID.Text = placeholderText;
                txtBoxEID.ForeColor = Color.Gray; 
            }
        }

        private void txtBoxPass_Enter(object sender, EventArgs e)
        {
            if (txtBoxPass.Text == placeholderText2)
            {
                txtBoxPass.Text = "";
                txtBoxPass.ForeColor = Color.Black;
            }
        }

        private void txtBoxEID_Enter_1(object sender, EventArgs e)
        {
            if (txtBoxEID.Text == placeholderText)
            {
                txtBoxEID.Text = "";
                txtBoxEID.ForeColor = Color.Black;
            }

            if (showPass.Tag.Equals("hidden") && txtBoxPass.Text != placeholderText2)
            {
                txtBoxPass.PasswordChar = '\u25cf';
            }
            else if (showPass.Tag.Equals("Show") && txtBoxPass.Text != placeholderText2)
            {
                txtBoxPass.PasswordChar = '\0';
            }
        }

        private void txtBoxEID_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxEID.Text))
            {
                txtBoxEID.Text = placeholderText;
                txtBoxEID.ForeColor = Color.Gray;
            }
        }

        private void txtBoxPass_Enter_1(object sender, EventArgs e)
        {

            txtBoxPass.PasswordChar = '\u25cf';
            if (txtBoxPass.Text == placeholderText2)
            {

                txtBoxPass.Text = "";
                txtBoxPass.ForeColor = Color.Black;
            }
            if (showPass.Tag.Equals("hidden") && txtBoxPass.Text != placeholderText2)
            {
                txtBoxPass.PasswordChar = '\u25cf';
            }
            else if (showPass.Tag.Equals("Show") && txtBoxPass.Text != placeholderText2)
            {
                txtBoxPass.PasswordChar = '\0';
            }
        }

        private void txtBoxPass_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPass.Text))
            {
                txtBoxPass.PasswordChar = '\0';
                txtBoxPass.Text = placeholderText2;
                txtBoxPass.ForeColor = Color.Gray; 
            }
            else if(txtBoxPass.Text!= placeholderText2)
            {
                txtBoxPass.PasswordChar = '\u25cf';
                txtBoxPass.Text = txtBoxPass.Text;
            }
        }

        private void txtBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void Login_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void showPass_Click(object sender, EventArgs e)
        {
            if ((string)showPass.Tag == "hidden")
            {
                showPass.Tag = "Show";
                showPass.Image = Properties.Resources.show;
                if (txtBoxPass.Text != placeholderText2)
                {
                    txtBoxPass.PasswordChar = '\0';
                    
                }
                else if(txtBoxPass.Text == placeholderText2)
                {
                    txtBoxPass.PasswordChar = '\0';
                }
                else
                {
                    txtBoxPass.PasswordChar = '\u25cf';
                }
            }
            else
            {
                showPass.Tag = "hidden";
                showPass.Image = Properties.Resources.hidden;
                if (txtBoxPass.Text != placeholderText2)
                {
                    txtBoxPass.PasswordChar = '\u25cf';
                }
                else
                {
                    txtBoxPass.PasswordChar = '\0';
                }
            }
        }

        private void txtBoxPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPass.Text))
            {
                txtBoxPass.Text = placeholderText2;
                txtBoxPass.ForeColor = Color.Gray;
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
                        MessageBox.Show("Logging in with an admin account: " + userID);
                        DashBoard dash = new DashBoard();
                        dash.Show();
                        this.Close();
                    }
                    else if (level.Equals("FrontDesk"))
                    {
                        MessageBox.Show("Loggin in with an employee account: " + userID);
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed: \nUser not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
