using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace encyclopedia_database
{
    public static class Helper
    {
        public const string MessageAdded = "Record has been successfully added!",
            MessageDeleted = "Record has been successfully deleted!";

        public static string un;

        public enum Tables
        {
            Street,
            Square,
            Sight,
            Background
        }

        public static void RebindGridView(DataGridView dgv, string table)
        {
            var dataGridViewColumn = dgv.Columns["idStreet"];
            if (dataGridViewColumn != null) dataGridViewColumn.ReadOnly = true;

            var connStr = "server=localhost;user=root;database=mydb;password=12332";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var comm = new MySqlCommand("SELECT * FROM " + table, conn);
                    var adapter = new MySqlDataAdapter(comm);
                    var ds = new DataSet();
                    adapter.Fill(ds);
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.DataSource = ds.Tables[0];

                    dgv.Columns[0].HeaderText = "ID";
                    dgv.Columns[1].HeaderText = "New name";
                    dgv.Columns[2].HeaderText = "Old name";
                    dgv.Columns[3].HeaderText = "Founding date";
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }


        internal static void Login(string connStr)
        {
            var conn = new MySqlConnection(connStr);
            if (!IsConnected(conn)) return;
            var mf = new MainForm();
            mf.ShowDialog();
        }

        private static bool IsConnected(IDbConnection conn)
        {
            using (conn)
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid username and/or password!");
                    return false;
                }
            }
        }

        internal static string ExtractLogin(string login)
        {
            return un = login;
        }

        internal static string GetConnString(string usernameTbText, string passwordTbText)
        {
            string _login = usernameTbText,
                _password = passwordTbText;
            return "server = localhost; user = " + _login + "; database = mydb; password = " + _password;
        }

        //public static Tuple<string, string> GetData(string usernameTbText, string passwordTbText)
        //{
        //    string _login = usernameTbText,
        //        _password = passwordTbText;
        //    return Tuple.Create("server = localhost; user = " + _login + "; database = mydb; password = " + _password,
        //        _login);
        //}
    }
}
