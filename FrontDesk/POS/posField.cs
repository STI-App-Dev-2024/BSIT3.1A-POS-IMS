using MySql.Data.MySqlClient;
using POS__ims;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace System.FrontDesk.POS
{
    public partial class posField : Form
    {
        private int height, width;
        private Size formOriginalSize;
        private Rectangle recPnl1;
        private Rectangle recPnl2;

        private fitDB db = new fitDB();
        private ProductInfo selectedProductInfo;
        private RndPanel containerPanel;
        private Dictionary<string, ListPanel> selectedProducts = new Dictionary<string, ListPanel>();
        fitDB conn = new fitDB();
        private string Value;
        private Timer resizeTimer;

        double sum = 0;
        public posField()
        {
            InitializeComponent();
            formOriginalSize = this.Size;
            recPnl1 = new Rectangle(searchBox.Location, searchBox.Size);
            recPnl2 = new Rectangle(productPnl.Location, productPnl.Size);

            resizeTimer = new Timer();
            resizeTimer.Interval = 50;
            resizeTimer.Tick += ResizeTimer_Tick;

            this.Resize += posField_Resize;

            productList.AutoScroll = true;
            productPnl.AutoScroll = true;

            if (db.Open())
            {
                LoadProductPanels();
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.");
            }
        }

        private void ResizeTimer_Tick(object sender, EventArgs e)
        {
            resizeTimer.Stop();
            resize_Control(searchBox, recPnl1);
            resize_Control(productPnl, recPnl2);
            ArrangeProductPanels();
        }

        private void ArrangeProductPanels()
        {
            productPnl.SuspendLayout();
            int xPosition = 10;
            int yPosition = 10;
            int spacing = 10;
            int formWidth = this.productPnl.ClientSize.Width;

            foreach (Control control in productPnl.Controls)
            {
                if (control is ProductPanel)
                {
                    control.Location = new Point(xPosition, yPosition);

                    xPosition += control.Width + spacing;
                    if (xPosition + control.Width > formWidth)
                    {
                        xPosition = 10;
                        yPosition += control.Height + spacing;
                    }
                }
            }
            productPnl.ResumeLayout();
        }

        private void posField_Resize(object sender, EventArgs e)
        {
            resizeTimer.Stop();
            resizeTimer.Start();
        }
        
        private void resize_Control(Control c, Rectangle originalRect)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(originalRect.X * xRatio);
            int newY = (int)(originalRect.Y * yRatio);
            int newWidth = (int)(originalRect.Width * xRatio);
            int newHeight = (int)(originalRect.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void LoadProductPanels()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM products";

                DataSet ds = conn.ExecuteDataSet(sql);

                if (ds != null && ds.Tables["result"].Rows.Count > 0)
                {
                    int xPosition = 10;
                    int yPosition = 10;
                    int spacing = 10;
                    int formWidth = this.productPnl.ClientSize.Width;
                    int width = 200;
                    int height = 250;


                    foreach (DataRow row in ds.Tables["result"].Rows)
                    {
                        string name = row["productName"].ToString();
                        decimal price = Convert.ToDecimal(row["price"]);

                        ProductPanel productPanel = new ProductPanel(name, price, width, height);

                        productPanel.PanelClicked += ProductPanel_PanelClicked;

                        productPanel.Location = new Point(xPosition, yPosition);
                        productPnl.Controls.Add(productPanel);

                        xPosition += productPanel.Width + spacing;
                        if (xPosition + productPanel.Width > formWidth)
                        {
                            xPosition = 10;
                            yPosition += productPanel.Height + spacing;
                        }
                    }
                    ArrangeProductPanels();
                }
                else
                {
                    MessageBox.Show("No products found in the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void ProductPanel_PanelClicked(object sender, ProductInfo e)
        {
            try
            {
                if (e == null) return;

                selectedProductInfo = e;

                if (selectedProducts.TryGetValue(selectedProductInfo.Name, out ListPanel listPanel))
                {
                    listPanel.IncrementQuantity();
                }
                else
                {
                    int yPosition = productList.Controls.Count * 8 + 10;

                    ListPanel listp = new ListPanel(
                        selectedProductInfo.Name,
                        selectedProductInfo.Price,
                        yPosition,
                        (s, ev) => Minus(s, ev),
                        (s, ev) => Plus(s, ev)
                    );

                    listp.btnMinus.Tag = selectedProductInfo.Name;
                    listp.btnPlus.Tag = selectedProductInfo.Name;

                    productList.Controls.Add(listp.NameLabel);
                    productList.Controls.Add(listp.PriceLabel);
                    productList.Controls.Add(listp.QuantityLabel);
                    productList.Controls.Add(listp.btnPlus);
                    productList.Controls.Add(listp.btnMinus);

                    selectedProducts[selectedProductInfo.Name] = listp;

                }

                sum += Convert.ToDouble(selectedProductInfo.Price);
                lblPrice.Text = sum.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void Plus(object sender, EventArgs e)
        {
            try
            {
                if (sender is System.Windows.Forms.Button plusButton)
                {
                    var productName = plusButton.Tag?.ToString();
                    if (productName == null || !selectedProducts.TryGetValue(productName, out var listPanel))
                        return;

                    listPanel.IncrementQuantity();
                    sum += Convert.ToDouble(listPanel.Price);

                    lblPrice.Text = sum.ToString("F2"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Minus(object sender, EventArgs e)
        {
            try
            {
                if (sender is System.Windows.Forms.Button minusButton)
                {
                    var productName = minusButton.Tag?.ToString();
                    if (productName == null || !selectedProducts.TryGetValue(productName, out var listPanel))
                        return;

                    if (listPanel.Quantity > 1)
                    {
                        listPanel.DecrementQuantity();
                        sum -= Convert.ToDouble(listPanel.Price);
                    }
                    else
                    {
                        productList.Controls.Remove(listPanel.NameLabel);
                        productList.Controls.Remove(listPanel.PriceLabel);
                        productList.Controls.Remove(listPanel.QuantityLabel);
                        productList.Controls.Remove(listPanel.btnPlus);
                        productList.Controls.Remove(listPanel.btnMinus);

                        selectedProducts.Remove(productName);
                        sum -= Convert.ToDouble(listPanel.Price);

                        int x = (productList.Controls.Count - 10) / 8 - 1;
                        AdjustControlsYPosition(productList, x);

                        /*foreach (var product in productList.Controls)
                        {
                            int yPosition = productList.Controls.Count * 8 + 10;    
                        }*/
                    }
                    lblPrice.Text = sum.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void AdjustControlsYPosition(Panel panel, int newYPosition)
        {
            int yPositionIncrement = 10;

            foreach (Control control in panel.Controls)
            {
                if (control.Top != 10)
                {
                    control.Top = newYPosition + (panel.Controls.GetChildIndex(control) * yPositionIncrement);
                }
                else
                {
                    control.Top = 10;
                }
            }
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            PerformSearch(rjTextBox1.Texts.Trim());
        }

        private void PerformSearch(string searchTerm)
        {
            string query;
            bool alldigits = searchTerm.All(char.IsDigit);
            conn.Open();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadProductPanels();
                return;
            }
            try
            {
                if (alldigits)
                {
                    query = $"SELECT * FROM products WHERE productID LIKE '%{int.Parse(searchTerm)}%'";
                }
                else
                {
                    query = $"SELECT * FROM products WHERE productName LIKE '%{searchTerm}%'";
                }

                MySqlDataReader row = conn.ExecuteReader(query);

                productPnl.Controls.Clear();

                int xPosition = 10;
                int yPosition = 10;
                int spacing = 10;
                int formWidth = this.productPnl.ClientSize.Width;
                int width = 200;
                int height = 250;

                if (row.HasRows)
                {
                    prodSearchMsg.Text = "";
                    while (row.Read())
                    {
                        string name = row["productName"].ToString();
                        decimal price = Convert.ToDecimal(row["price"]);

                        ProductPanel productPanel = new ProductPanel(name, price, width, height);
                        productPanel.PanelClicked += ProductPanel_PanelClicked;

                        productPanel.Location = new Point(xPosition, yPosition);
                        productPnl.Controls.Add(productPanel);

                        xPosition += productPanel.Width + spacing;
                        if (xPosition + productPanel.Width > formWidth)
                        {
                            xPosition = 10;
                            yPosition += productPanel.Height + spacing;
                        }
                    }
                }
                else
                {
                    prodSearchMsg.Text = "No products found matching the search criteria.";
                }
                row.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void payment()
        {
            if (payGcash.Checked)
                Value = payGcash.Text;
            else if (payCash.Checked)
                Value = payCash.Text;
            else if (payBank.Checked)
                Value = payBank.Text;
            else if (paycredit.Checked)
                Value = paycredit.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            payment();
            SummaryForm summaryForm = new SummaryForm(selectedProducts, sum, Value);
            summaryForm.ShowDialog();
        }
    }
}
