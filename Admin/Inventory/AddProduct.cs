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
    public partial class AddProduct : Form
    {
        string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        private string selectedImagePath = "";
        public Point mouseLocation;
        public AddProduct()
        {
            InitializeComponent();
            PlaceholderImage("ProductImg", "placeholder.png");
        }
        private void prodImgUp()
        {
            if (string.IsNullOrWhiteSpace(txtBoxProdNameAdd.Text))
            {
                MessageBox.Show("Please enter a product name before uploading an image.");
                return;
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;

                    prodImg.Image = Image.FromFile(selectedImagePath);
                    prodImg.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

            private void SaveImage()
            {
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("No image selected to save.");
                return;
            }

            string productName = txtBoxProdNameAdd.Text.Trim();
            string fileExtension = Path.GetExtension(selectedImagePath);
            string destFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "ProductImg");

            if (!Directory.Exists(destFolderPath))
            {
                Directory.CreateDirectory(destFolderPath);
            }

            string destFilePath = Path.Combine(destFolderPath, productName + fileExtension);

            try
            {
                File.Copy(selectedImagePath, destFilePath, true);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"An error occurred while saving the image: {ex.Message}");
            }
        }

        private void PlaceholderImage(string folderName, string imageName)
        {
            string imagePath = Path.Combine(Application.StartupPath, folderName, imageName);

            if (File.Exists(imagePath) && (imagePath.EndsWith(".jpg") || imagePath.EndsWith(".png") || imagePath.EndsWith(".jpeg")))
            {
                prodImg.Image = Image.FromFile(imagePath);
                prodImg.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("Image not found or invalid format.");
            }
        }

            private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RunQuery()
        {

            string productName = txtBoxProdNameAdd.Text;
            int quantity = Convert.ToInt32(txtBoxQuantityAdd.Text);
            string productDescription = richTextBoxDescriptionA.Text;
            double price = Convert.ToDouble(txtBoxPriceAdd.Text);

            string query1 = $"INSERT INTO products(`productName`, `productQuantity`, `price`, `productDesc`) VALUES('{productName}', '{quantity}', '{price}','{productDescription}')";

            conn = new MySqlConnection(MySQLConnectionString);

            cmd = new MySqlCommand(query1, conn);

            conn.Open();

            cmd.ExecuteReader();

            conn.Close();
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxProdNameAdd.Text == "" && txtBoxQuantityAdd.Text == "" && txtBoxPriceAdd.Text == "" && richTextBoxDescriptionA.Text == "")
                {

                    throw new FormatException($"Details cannot be empty.");
                }

                else if (txtBoxProdNameAdd.Text == "")
                {
                    throw new FormatException($"Product Name cannot be empty.");
                }

                else if (txtBoxQuantityAdd.Text == "")
                {
                    throw new FormatException($"Product Quantity cannot be empty.");
                }

                else if (richTextBoxDescriptionA.Text == "")
                {
                    throw new FormatException($"Product Description cannot be empty.");
                }

                else if (txtBoxPriceAdd.Text == "")
                {
                    throw new FormatException($"Produce Price cannot be empty");
                }

                else
                {
                    if (MessageBox.Show($"Are you sure you want to save this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        RunQuery();
                        SaveImage();

                        txtBoxProdNameAdd.Clear();
                        txtBoxQuantityAdd.Clear();
                        richTextBoxDescriptionA.Clear();
                        txtBoxPriceAdd.Clear();
                        prodImg.Image = null;
                    }
                }
            }

            catch (FormatException FE)
            {
                MessageBox.Show(FE.Message);
            }
        }

        private void imgUpload_Click(object sender, EventArgs e)
        {
            prodImgUp();
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
