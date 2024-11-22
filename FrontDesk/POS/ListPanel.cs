using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace System
{
    public class ListPanel : Label
    {
        public Label NameLabel { get; private set; }
        public Label PriceLabel { get; private set; }
        public Label QuantityLabel { get; private set; }
        public Button btnPlus {  get; private set; }
        public Button btnMinus { get; private set; }

        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public event EventHandler QuantityChanged;
        public ListPanel(string productName, decimal productPrice, int yPosition, EventHandler minusClickHandler, EventHandler plusClickHandler)
        {
            Name = productName;
            Price = productPrice;
            Quantity = 1;

            NameLabel = new Label
            {
                Text = productName,
                ForeColor = Color.Black,
                AutoSize = true,
                Padding = new Padding(5),
                Location = new Point(0, yPosition)
            };

            btnMinus = new Button
            {
                Size = new Size(20, 20),
                Text = "-",
                Font = new Font("Arial", 9),
                ForeColor = Color.White,
                BackColor = Color.DimGray,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(100, yPosition),
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(0)
            };
            btnMinus.Click += minusClickHandler;

            btnPlus = new Button
            {
                Size = new Size(20, 20),
                Text = "+",
                Font = new Font("Arial", 9),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(200, 36, 99),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(155, yPosition),
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(0)
            };
            btnPlus.Click += plusClickHandler;

            PriceLabel = new Label
            {
                Text = productPrice.ToString(),
                ForeColor = Color.Black,
                AutoSize = true,
                Padding = new Padding(5),
                Location = new Point(210, yPosition),
                BackColor = Color.Transparent
            };

            QuantityLabel = new Label
            {
                Text = Quantity.ToString(),
                ForeColor = Color.Black,
                AutoSize = true,
                Padding = new Padding(5),
                Location = new Point(125, yPosition),
                BackColor = Color.Transparent
            };

            btnPlus.FlatAppearance.BorderSize = 0;
            btnMinus.FlatAppearance.BorderSize = 0;

        }

        public void IncrementQuantity()
        {
            Quantity++;
            QuantityLabel.Text = Quantity.ToString();
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }

        public void DecrementQuantity()
        {
            Quantity--;
            QuantityLabel.Text = Quantity.ToString();
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
