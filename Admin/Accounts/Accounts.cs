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
    public partial class Accounts : Form
    {

        fitDB db = new fitDB();
        public Accounts()
        {
            InitializeComponent();
            DisplayData();
        }

        public void DisplayData()
        {
            dataGridAccountList.Rows.Clear();

            db.setConn("datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb");

            db.getConn().Open();

            MySqlCommand cmd = db.getCMD();

            db.AddQuery($"SELECT * FROM fitwhitedb.accounts");

            MySqlDataReader reader = db.getCMD().ExecuteReader();

            while (reader.Read())
            {
                dataGridAccountList.Rows.Add(reader["employeeID"], reader["password"].ToString(), reader["role"].ToString());
            }

            db.getConn().Close();
        }

        private void dataGridAccountList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridAccountList.Columns[e.ColumnIndex].Name;

            db.setConn("datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb");

            if (colName.Equals("Delete"))
            {
                if (MessageBox.Show("Are you sure you want to delete this account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.getConn().Open();
                    db.AddQuery($"DELETE FROM fitwhitedb.accounts WHERE employeeID LIKE '{dataGridAccountList[0, e.RowIndex].Value.ToString()}'");
                    db.getCMD().ExecuteNonQuery();
                    db.getConn().Close();

                    DisplayData();

                    MessageBox.Show("Account successfully deleted.", "Account Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (colName.Equals("Edit"))
            {
                EditAccount editAccount = new EditAccount();
                editAccount.txtBoxEIDEdit.Text = $"{dataGridAccountList[0, e.RowIndex].Value.ToString()}";
                editAccount.txtBoxEIDEdit.Enabled = false;
                editAccount.txtBoxEditPass.Text = $"{dataGridAccountList[1, e.RowIndex].Value.ToString()}";
                editAccount.cbEditRoles.Text = $"{dataGridAccountList[2, e.RowIndex].Value.ToString()}";
                editAccount.ShowDialog();
            }
        }

        private void txtBoxSearchAcc_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSearchAcc.Text.Equals(""))
            {
                DisplayData();
            }

            else
            {
                dataGridAccountList.Rows.Clear();

                db.setConn("datasource=127.0.0.1;port=3306;username=root;password=;database=fitwhitedb");

                db.getConn().Open();

                MySqlCommand cmd = db.getCMD();

                db.AddQuery($"SELECT ordersID, GROUP_CONCAT(productName), orderDate, amount, SUM(quantity) FROM Orders LEFT JOIN products ON Orders.productID = products.productID GROUP BY ordersID AND ordersID LIKE '{txtBoxSearchAcc.Text}%'");

                MySqlDataReader reader = db.getCMD().ExecuteReader();

                while (reader.Read())
                {
                    dataGridAccountList.Rows.Add(reader["employeeID"], reader["password"].ToString(), reader["role"].ToString());
                }

                db.getConn().Close();
            }
        }
    }
}
