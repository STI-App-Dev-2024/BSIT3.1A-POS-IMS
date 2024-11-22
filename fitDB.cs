using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace System
{
    public class fitDB
    {
        MySql.Data.MySqlClient.MySqlConnection con;
        string myConnectionString;
        static string host = "localhost";
        static string database = "fitwhitedb";
        static string userDB = "root";
        public static string fitbase = "server=" + host + ";database=" + database + ";user=" + userDB + ";Password=";

        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private MySqlDataAdapter adapter;

        public void setConn(String database)
        {
            this.conn = new MySqlConnection(database);
        }

        public MySqlConnection getConn()
        {
            return this.conn;
        }

        public MySqlCommand getCMD()
        {
            return this.cmd;
        }

        public void setAdapter(String query)
        {
            this.adapter = new MySqlDataAdapter(query, conn);
        }

        public MySqlDataAdapter getAdapter()
        {
            return this.adapter;
        }

        public void AddQuery(String query)
        {
            this.cmd = new MySqlCommand(query, this.conn);
        }


    public bool Open()
        {
            try
            {
                fitbase = "server=" + host + ";database=" + database + ";user=" + userDB + ";Password=";
                con = new MySqlConnection(fitbase);
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public void Close()
        {
            con.Close();
            con.Dispose();
        }

        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                MySqlTransaction mytransaction = con.BeginTransaction();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

    }
}