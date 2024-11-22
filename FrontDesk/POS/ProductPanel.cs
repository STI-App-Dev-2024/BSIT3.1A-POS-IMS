using POS__ims;
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
    public  class ProductPanel : RndPanel
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public event EventHandler<ProductInfo> PanelClicked;
        public ProductPanel(string name, decimal price, int width, int height)
        {
            ProductName = name;
            Price = price;

            this.Size = new Size(width, height);
            this.BorderRadius = 10;
            this.GradientTopColor = Color.FromArgb(200, 36, 99);
            this.GradientBottomColor = Color.FromArgb(200, 36, 99);

            Label nameLabel = new Label
            {
                 Text = name,
                 Location = new Point(10, width),
                 AutoSize = true,
                 Font = new Font("Arial", 12, FontStyle.Bold),
                 BackColor = Color.Transparent,
                 ForeColor = Color.White,
            };
            this.Controls.Add(nameLabel);

            Label priceLabel = new Label
            {
                Text = "₱" + Price.ToString(),
                Location = new Point(10, width +20),
                AutoSize = true,
                Font = new Font("Arial", 10),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
            };
            this.Controls.Add(priceLabel);

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(180, 180),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };

            string productImagesFolder = Path.Combine(Directory.GetCurrentDirectory(), "ProductImg");
            string[] acceptedExtensions = { ".jpg", ".jpeg", ".png" };
            string productImagePath = null;
            foreach (var extension in acceptedExtensions)
            {
                string path = Path.Combine(productImagesFolder, name + extension);
                if (File.Exists(path))
                {
                    productImagePath = path;
                    break;
                }
            }

            if (productImagePath != null)
            {
                pictureBox.Image = Image.FromFile(productImagePath);
            }
            else
            {
                string placeholderImagePath = Path.Combine(productImagesFolder, "placeholder.png");

                if (File.Exists(placeholderImagePath))
                {
                    pictureBox.Image = Image.FromFile(placeholderImagePath);
                }
                else
                {
                    MessageBox.Show("Placeholder image not found. Please ensure 'placeholder.png' exists in the 'ProductImg' folder.");
                }
            }

            this.Controls.Add(pictureBox);

            this.Click += (sender, e) => OnPanelClicked();
            nameLabel.Click += (sender, e) => OnPanelClicked();
            priceLabel.Click += (sender, e) => OnPanelClicked();
            pictureBox.Click += (sender, e) => OnPanelClicked();
        }

        protected virtual void OnPanelClicked() 
        {
            PanelClicked?.Invoke(this, new ProductInfo
            {
                Name = this.ProductName,
                Price = this.Price
            }
            );
        }
    }
}
