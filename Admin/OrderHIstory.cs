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
    public partial class OrderHIstory : Form
    {
        string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        fitDB db = new fitDB();
        public OrderHIstory()
        {
            InitializeComponent();
            DisplayData();
        }

        public void DisplayData()
        {
            try
            {
                dataGridOrderHistory.Rows.Clear();

                string query2 = $"SELECT ordersID, GROUP_CONCAT(productName), orderDate, amount, SUM(quantity) FROM Orders LEFT JOIN products ON Orders.productID = products.productID GROUP BY ordersID";

                conn = new MySqlConnection(MySQLConnectionString);

                conn.Open();

                cmd = new MySqlCommand(query2, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string formattedDate = DateTime.Parse(reader["orderDate"].ToString()).ToString("yyyy-MM-dd");
                    dataGridOrderHistory.Rows.Add(
                        formattedDate,
                        reader["ordersID"].ToString(),
                        reader["GROUP_CONCAT(productName)"].ToString(),
                        reader["amount"].ToString(),
                        reader["SUM(quantity)"].ToString()
                        );
                }
            }
            catch (MySqlException ex)
            {
                popMsg pop = new popMsg("ex.Message", "Error Message");
                pop.StartPosition = FormStartPosition.Manual;
                pop.Location = new Point(
                    this.Location.X + (this.Width - pop.Width) / 2,
                    this.Location.Y + (this.Height - pop.Height) / 2
                );
                pop.ShowDialog();
            }

            conn.Close();
        }

        private void txtBoxSearchHistory_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSearchHistory.Text.Equals(""))
            {
                DisplayData();
            }

            else
            {
                dataGridOrderHistory.Rows.Clear();

                db.setConn("datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb");

                db.getConn().Open();

                MySqlCommand cmd = db.getCMD();

                db.AddQuery($"SELECT ordersID, GROUP_CONCAT(productName) AS ProductNames, orderDate, amount, SUM(quantity) AS TotalQuantity FROM Orders LEFT JOIN products ON Orders.productID = products.productID WHERE ordersID LIKE'{txtBoxSearchHistory.Text}%' GROUP BY ordersID");

                MySqlDataReader reader = db.getCMD().ExecuteReader();

                while (reader.Read())
                {
                    string formattedDate = DateTime.Parse(reader["orderDate"].ToString()).ToString("yyyy-MM-dd");
                    dataGridOrderHistory.Rows.Add(
                        formattedDate,
                        reader["ordersID"].ToString(),
                        reader["ProductNames"].ToString(),
                        reader["amount"].ToString(),
                        reader["TotalQuantity"].ToString()
                        );
                }

                db.getConn().Close();
            }
        }
    }
}
