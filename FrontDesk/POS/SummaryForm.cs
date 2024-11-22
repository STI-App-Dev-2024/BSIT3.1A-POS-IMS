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
    public partial class SummaryForm : Form
    {
        private fitDB db;
        private Dictionary<string, ListPanel> selectedProducts;
        private double totalPrice;
        private string paymentMethod;
        public SummaryForm(Dictionary<string, ListPanel> selectedProducts, double totalPrice, string pay)
        {
            InitializeComponent();
            this.selectedProducts = selectedProducts;
            this.totalPrice = totalPrice;
            this.paymentMethod = pay;
            DisplaySummary();
            lblPMethod.Text = pay;

            db = new fitDB();
            lblOrderID.Text = GetNextOrderID();
        }
            
        private void DisplaySummary()
        {
            int yPosition = 10;

            foreach (var item in selectedProducts)
            {
                ListPanel listPanel = item.Value;

                Label productLabel = new Label
                {
                    Text = $"{listPanel.Name} - Quantity: {listPanel.Quantity} - {listPanel.Price:C}",
                    Location = new Point(10, yPosition),
                    AutoSize = true
                };
                orderSum.Controls.Add(productLabel);
                yPosition += 30;
            }

            Label totalLabel = new Label
            {
                Text = $"Total Price: {totalPrice:C}",
                Location = new Point(10, 10),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            totalSum.Controls.Add(totalLabel);

            lblOrderID.Text = "";
        }

        private string GetNextOrderID()
        {
            string nextOrderID = "01000001"; 

            string query = "SELECT MAX(ordersID) FROM orders";
            if (db.Open())
            {
                try
                {
                    var reader = db.ExecuteReader(query);
                    if (reader.Read())
                    {
                        object maxID = reader[0];
                        if (maxID != DBNull.Value)
                        {
                            int currentMaxID = Convert.ToInt32(maxID);
                            nextOrderID = (currentMaxID + 1).ToString("D8"); 
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving next order ID: " + ex.Message);
                }
                finally
                {
                    db.Close();
                }
            }
            return nextOrderID;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (db.Open())
            {
                try
                {
                    foreach (var item in selectedProducts)
                    {
                        ListPanel listPanel = item.Value;
                        string orderSql = $"INSERT INTO orders (ordersID, quantity, amount, paymentMethod, orderDate, productID) " +
                                          $"VALUES ({Convert.ToInt32(lblOrderID.Text)}, {listPanel.Quantity}, {listPanel.Price}, '{paymentMethod}', '{DateTime.Now.ToString("yyyy-MM-dd")}', " +
                                          $"(SELECT productID FROM products WHERE productName = '{listPanel.Name}'))";

                        int result = db.ExecuteNonQuery(orderSql);

                        if (result > 0)
                        {
                            string updateProductQuantitySql =
                                "BEGIN " +
                                "    BEGIN TRANSACTION; " +
                                "    UPDATE products " +
                                "    SET productQuantity = productQuantity - @Quantity " +
                                "    WHERE productName = @ProductName; " +
                                "    IF (SELECT productQuantity FROM products WHERE productName = @ProductName) < 0 " +
                                "    BEGIN " +
                                "        ROLLBACK TRANSACTION; " +
                                "        RAISERROR ('Quantity cannot be negative.', 16, 1); " +
                                "    END " +
                                "    ELSE " +
                                "    BEGIN " +
                                "        COMMIT TRANSACTION; " +
                                "    END; " +
                                "END;";

                            int updateResult = db.ExecuteNonQuery(updateProductQuantitySql);

                            if (updateResult > 0)
                            {

                            }
                            else
                            {
                                MessageBox.Show("Failed to update product quantity.", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to save the order.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    db.Close();
                }
            }
            else
            {
                MessageBox.Show("Unable to connect to the database.");
            }

            MessageBox.Show($"Order has been posted.", "Success");

            this.Close();
        }
    }
    }

  

