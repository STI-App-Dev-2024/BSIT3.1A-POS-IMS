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
    public partial class SalesSummary : Form
    {
        fitDB db = new fitDB();
        public SalesSummary()
        {
            InitializeComponent();
            DisplayData();

            /*for (int i = 0; i < dataGridSalesReport.Rows.Count; i++)
            {
                lblTSalesAmount.Text = Convert.ToString(double.Parse(lblTSalesAmount.Text) + double.Parse(dataGridSalesReport.Rows[i].Cells[4].Value.ToString()));
            }

            for (int i = 0; i < dataGridSalesReport.Rows.Count; i++)
            {
                lblTProdSold.Text = Convert.ToString(double.Parse(lblTProdSold.Text) + double.Parse(dataGridSalesReport.Rows[i].Cells[3].Value.ToString()));
            }*/
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        public void DisplayData()
        {
            dataGridSalesReport.Rows.Clear();

            db.setConn("datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb");

            db.getConn().Open();

            MySqlCommand cmd = db.getCMD();

            db.AddQuery($"SELECT GROUP_CONCAT(O.productID) AS ProdID, GROUP_CONCAT(P.productName) AS products, P.price, O.quantity, O.amount FROM orders O INNER JOIN products P ON O.productID = P.productID GROUP BY ordersID");

            MySqlDataReader reader = db.getCMD().ExecuteReader();

            while (reader.Read())
            {
                dataGridSalesReport.Rows.Add(reader["ProdID"], reader["products"], reader["price"], reader["quantity"].ToString(), reader["amount"]);
            }

            db.getConn().Close();
        }

        private void btnShowSum_Click(object sender, EventArgs e)
        {
            lblTSalesAmount.Text = "0";
            lblTProdSold.Text = "0";

            String from = dtpFrom.Value.ToString("yyyy-MM-dd");
            String to = dtpTo.Value.ToString("yyyy-MM-dd");

            dataGridSalesReport.Rows.Clear();

            db.setConn("datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb");

            db.getConn().Open();

            MySqlCommand cmd = db.getCMD();

            db.AddQuery($"SELECT GROUP_CONCAT(O.productID) AS ProdID, GROUP_CONCAT(P.productName) AS products, P.price, O.quantity, O.amount FROM orders O INNER JOIN products P ON O.productID = P.productID WHERE `ordersID` BETWEEN '{from}' AND '{to}' GROUP BY ordersID");

            MySqlDataReader reader = db.getCMD().ExecuteReader();

            while (reader.Read())
            {
                dataGridSalesReport.Rows.Add(reader["ProdID"], reader["products"], reader["price"], reader["quantity"].ToString(), reader["amount"]);
            }

            db.getConn().Close();

            for (int i = 0; i < dataGridSalesReport.Rows.Count; i++)
            {
                lblTSalesAmount.Text = Convert.ToString(double.Parse(lblTSalesAmount.Text) + double.Parse(dataGridSalesReport.Rows[i].Cells[4].Value.ToString()));
            }

            for (int i = 0; i < dataGridSalesReport.Rows.Count; i++)
            {
                lblTProdSold.Text = Convert.ToString(double.Parse(lblTProdSold.Text) + double.Parse(dataGridSalesReport.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridSalesReport.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridSalesReport.Columns.Count + 1; i++)
                {
                    MExcel.Cells[1, i] = dataGridSalesReport.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridSalesReport.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridSalesReport.Columns.Count; j++)
                    {
                        MExcel.Cells[i + 2, j + 1] = dataGridSalesReport.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MExcel.Columns.AutoFit();
                MExcel.Rows.AutoFit();
                MExcel.Columns.Font.Size = 12;
                MExcel.Visible = true;
            }
            else
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
