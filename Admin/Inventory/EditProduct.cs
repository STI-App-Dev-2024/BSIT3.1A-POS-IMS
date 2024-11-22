using MySql.Data.MySqlClient;
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
    public partial class EditProduct : Form
    {
        string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public Point mouseLocation;
        fitDB db = new fitDB();

        public EditProduct()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCloseE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txtBoxPID.Clear();
            txtBoxProdNameEdit.Clear();
            txtBoxQuantityEdit.Clear();
            txtBoxPriceEdit.Clear();
            richTextBoxDescriptionE.Clear();

            btnConfirmEdit.Enabled = false;
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();

            try
            {
                if (String.IsNullOrEmpty(txtBoxProdNameEdit.Text) && String.IsNullOrEmpty(txtBoxQuantityEdit.Text) && String.IsNullOrEmpty(txtBoxPriceEdit.Text) && String.IsNullOrEmpty(richTextBoxDescriptionE.Text))
                {
                    throw new ArgumentException("All Textboxes cannot be empty.");
                }

                else if (String.IsNullOrEmpty(txtBoxProdNameEdit.Text))
                {
                    throw new ArgumentException("Product Name cannot be empty.");
                }

                else if (String.IsNullOrEmpty(txtBoxQuantityEdit.Text))
                {
                    throw new ArgumentException("Product Quantity cannot be empty.");
                }

                else if (String.IsNullOrEmpty(txtBoxPriceEdit.Text))
                {
                    throw new ArgumentException("Product Price cannot be empty.");
                }

                else if (String.IsNullOrEmpty(richTextBoxDescriptionE.Text))
                {
                    throw new ArgumentException("Product Description cannot be empty.");
                }

                else if (MessageBox.Show("Are you sure you want to update this product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int productID = Convert.ToInt32(txtBoxPID.Text);
                    string productName = txtBoxProdNameEdit.Text;
                    int quantity = Convert.ToInt32(txtBoxQuantityEdit.Text);
                    double price = Convert.ToDouble(txtBoxPriceEdit.Text);
                    string description = richTextBoxDescriptionE.Text;

                    db.setConn("datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb");

                    db.getConn().Open();

                    db.AddQuery($"UPDATE fitwhitedb.products SET `productName` = '{productName}', `productQuantity` = '{quantity}', `price` = '{price}', `productDesc` = '{description}' WHERE `productID` LIKE '{productID}'");

                    db.getCMD().ExecuteNonQuery();

                    db.getConn().Close();

                    Clear();

                    MessageBox.Show("Product successfully updated.", "Product Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {

                }
            }

            catch (FormatException FE)
            {
                popMsg psg = new popMsg(FE.Message, "Error");
                psg.ShowDialog();
            }
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
    }
}
