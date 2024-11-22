using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{

    public partial class Inventory : Form
    {
        string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        fitDB db = new fitDB();

        private string placeholderText = "Search Product";
        public Inventory()
        {
            InitializeComponent();
            txtBoxSearchProduct.Text = placeholderText;
            txtBoxSearchProduct.ForeColor = Color.Gray;

            txtBoxSearchProduct.Enter += txtBoxSearchProduct_Enter;
            txtBoxSearchProduct.Leave += txtBoxSearchProduct_Leave;
            StartPosition = FormStartPosition.CenterScreen;

            DisplayData();
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct AP = new AddProduct();
            AP.Show();
        }

        private void txtBoxSearchProduct_Enter(object sender, EventArgs e)
        {
            if (txtBoxSearchProduct.Text == placeholderText)
            {
                txtBoxSearchProduct.Text = "";
                txtBoxSearchProduct.ForeColor = Color.Black;
            }
        }

        private void txtBoxSearchProduct_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxSearchProduct.Text))
            {
                txtBoxSearchProduct.Text = placeholderText;
                txtBoxSearchProduct.ForeColor = Color.Gray;
            }
        }

        private void dataGridProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridProductList.Columns[e.ColumnIndex].Name;

            conn = new MySqlConnection(MySQLConnectionString);

            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string productID = dataGridProductList[0, e.RowIndex].Value.ToString();
                    string productName = dataGridProductList[1, e.RowIndex].Value.ToString();

                    conn.Open();
                    cmd = new MySqlCommand($"DELETE FROM fitwhitedb.products WHERE productID LIKE '{dataGridProductList[0, e.RowIndex].Value.ToString()}'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    string productImagesFolder = Path.Combine(Directory.GetCurrentDirectory(), "ProductImg");
                    string[] acceptedExtensions = { ".jpg", ".jpeg", ".png" };

                    foreach (var extension in acceptedExtensions)
                    {
                        string imagePath = Path.Combine(productImagesFolder, productName + extension);
                        if (File.Exists(imagePath))
                        {
                            try
                            {
                                File.Delete(imagePath);
                                break;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Unexpected Error: {ex.Message}");
                            }
                        }
                    }

                    DisplayData();

                    MessageBox.Show("Product successfully deleted.", "Product Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (colName == "Edit")
            {
                EditProduct edit = new EditProduct();
                edit.txtBoxPID.Text = $"{dataGridProductList[0, e.RowIndex].Value.ToString()}";
                edit.txtBoxPID.Enabled = false;
                edit.txtBoxProdNameEdit.Text = $"{dataGridProductList[1, e.RowIndex].Value.ToString()}";
                edit.txtBoxQuantityEdit.Text = $"{dataGridProductList[2, e.RowIndex].Value.ToString()}";
                edit.txtBoxPriceEdit.Text = $"{dataGridProductList[3, e.RowIndex].Value.ToString()}";
                edit.richTextBoxDescriptionE.Text = $"{dataGridProductList[4, e.RowIndex].Value.ToString()}";
                edit.ShowDialog();
            }
        }

        public void DisplayData()
        {
            dataGridProductList.Rows.Clear();

            string query2 = $"SELECT * FROM fitwhitedb.products";

            conn = new MySqlConnection(MySQLConnectionString);

            conn.Open();

            cmd = new MySqlCommand(query2, conn);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridProductList.Rows.Add(reader["productID"], reader["productName"].ToString(), reader["productQuantity"].ToString(), reader["price"].ToString(), reader["productDesc"].ToString());
            }

            conn.Close();
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct();
            product.Show();
        }

        private void txtBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSearchProduct.Text.Equals("") || txtBoxSearchProduct.Text.Equals("Search Product"))
            {
                DisplayData();
            }

            else
            {
                dataGridProductList.Rows.Clear();

                db.setConn("datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb");

                db.getConn().Open();

                MySqlCommand cmd = db.getCMD();

                db.AddQuery($"SELECT * FROM fitwhitedb.products WHERE `productName` LIKE '{txtBoxSearchProduct.Text}%'");

                MySqlDataReader reader = db.getCMD().ExecuteReader();

                while (reader.Read())
                {
                    dataGridProductList.Rows.Add(reader["productID"], reader["productName"].ToString(), reader["productQuantity"].ToString(), reader["price"].ToString(), reader["productDesc"].ToString());
                }

                db.getConn().Close();
            }
        }
    }

}
