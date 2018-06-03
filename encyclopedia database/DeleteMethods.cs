using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace encyclopedia_database
{
    internal static class DeleteMethods
    {
        public static void DeleteStreetRecord(DataGridView dgv, string tableName)
        {
            dgv.AllowUserToDeleteRows = true;
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                dgv.Rows.Remove(r);
            }

            var connStr = "server=localhost;user=root;database=mydb;password=12332";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT * FROM " + tableName;
                    var adapter = new MySqlDataAdapter(sql, conn);

                    var builder = new MySqlCommandBuilder(adapter);

                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    adapter.Update((DataTable)dgv.DataSource);
                    ((DataTable)dgv.DataSource).AcceptChanges();

                    MessageBox.Show(Helper.MessageDeleted);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
        }

        public static void DeleteSquareRecord(DataGridView dgv, string tableName)
        {
            dgv.AllowUserToDeleteRows = true;
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                dgv.Rows.Remove(r);
            }

            const string connStr = "server=localhost;user=root;database=mydb;password=12332";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT * FROM " + tableName;
                    var adapter = new MySqlDataAdapter(sql, conn);

                    var builder = new MySqlCommandBuilder(adapter);

                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    adapter.Update((DataTable)dgv.DataSource);
                    ((DataTable)dgv.DataSource).AcceptChanges();

                    MessageBox.Show(Helper.MessageDeleted);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
        }

        public static void DeleteSightRecord(DataGridView dgv, string tableName)
        {
            dgv.AllowUserToDeleteRows = true;
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                dgv.Rows.Remove(r);
            }

            var connStr = "server=localhost;user=root;database=mydb;password=12332";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT * FROM " + tableName;
                    var adapter = new MySqlDataAdapter(sql, conn);

                    var builder = new MySqlCommandBuilder(adapter);

                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    adapter.Update((DataTable)dgv.DataSource);
                    ((DataTable)dgv.DataSource).AcceptChanges();

                    MessageBox.Show(Helper.MessageDeleted);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
        }

        public static void DeleteBackgroundRecord(DataGridView dgv, string tableName)
        {
            dgv.AllowUserToDeleteRows = true;
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                dgv.Rows.Remove(r);
            }

            var connStr = "server=localhost;user=root;database=mydb;password=12332";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT * FROM " + tableName;
                    var adapter = new MySqlDataAdapter(sql, conn);

                    var builder = new MySqlCommandBuilder(adapter);

                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    adapter.Update((DataTable)dgv.DataSource);
                    ((DataTable)dgv.DataSource).AcceptChanges();

                    MessageBox.Show(Helper.MessageDeleted);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
        }
    }
}
