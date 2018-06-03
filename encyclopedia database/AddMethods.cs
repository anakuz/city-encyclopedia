using System;
using System.Data;
using System.Windows.Forms;
using encyclopedia_database.DatabeseContext;
using encyclopedia_database.Tables;
using MySql.Data.MySqlClient;

namespace encyclopedia_database
{
    internal static class AddMethods
    {
        #region Form Methods
        public static void AddStreetRecordForm(string nname, string oname, string year)
        {
            try
            {
                using (var db = new DatabaseEntities())
                {
                    var street = new Street
                    {
                        NewNameStreet = nname,
                        OldNameStreet = oname,
                        FoundingDateStreet = DateTime.Now
                    };

                    db.Street.Add(street);
                    db.SaveChanges();

                    MessageBox.Show(Helper.MessageAdded);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

        }

        public static void AddSquareRecordForm(string nname, string oname, string year)
        {
            try
            {
                using (var db = new DatabaseEntities())
                {
                    var square = new Square
                    {
                        NewNameSquare = nname,
                        OldNameSquare = oname,
                        FoundingDateSquare = DateTime.Now
                    };

                    db.Square.Add(square);
                    db.SaveChanges();

                    MessageBox.Show(Helper.MessageAdded);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        public static void AddSightRecordForm(string name, string year, int street)
        {
            try
            {
                using (var db = new DatabaseEntities())
                {
                    var sight = new Sight
                    {
                        NameSight = name,
                        FoundingDateSight = DateTime.Now,
                        IdStreet = street
                    };

                    db.Sight.Add(sight);
                    db.SaveChanges();

                    MessageBox.Show(Helper.MessageAdded);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        public static void AddBackgroundRecordForm(string source, string year, string contents, int sight)
        {
            try
            {
                using (var db = new DatabaseEntities())
                {
                    var background = new Background()
                    {
                        SourceBackground = source,
                        YearBackground = DateTime.Now,
                        ContentsBackground = contents,
                        IdSight = sight
                    };

                    db.Background.Add(background);
                    db.SaveChanges();

                    MessageBox.Show(Helper.MessageAdded);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
        #endregion Form Methods

        #region Grid Methods
        public static void AddStreetRecordDgv(DataGridView dgv, string tableName)
        {
            const string connStr = "server=localhost;user=root;database=mydb;password=12332";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT * FROM " + tableName;
                    var adapter = new MySqlDataAdapter(sql, conn);

                    var builder = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    adapter.Update((DataTable)dgv.DataSource);
                    ((DataTable)dgv.DataSource).AcceptChanges();

                    MessageBox.Show(Helper.MessageAdded);
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        public static void AddSquareRecordDgv(DataGridView dgv, string tableName)
        {
            const string connStr = "server=localhost;user=root;database=mydb;password=12332";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT * FROM " + tableName;
                    var adapter = new MySqlDataAdapter(sql, conn);

                    var builder = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    adapter.Update((DataTable)dgv.DataSource);
                    ((DataTable)dgv.DataSource).AcceptChanges();

                    MessageBox.Show(Helper.MessageAdded);
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        public static void AddSightRecordDgv(DataGridView dgv, string tableName)
        {
            var connStr = "server=localhost;user=root;database=mydb;password=12332";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT * FROM " + tableName;
                    var adapter = new MySqlDataAdapter(sql, conn);

                    var builder = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    adapter.Update((DataTable)dgv.DataSource);
                    ((DataTable)dgv.DataSource).AcceptChanges();

                    MessageBox.Show(Helper.MessageAdded);
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        public static void AddBackgroundRecordDgv(DataGridView dgv, string tableName)
        {
            var connStr = "server=localhost;user=root;database=mydb;password=12332";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT * FROM " + tableName;
                    var adapter = new MySqlDataAdapter(sql, conn);

                    var builder = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    adapter.Update((DataTable)dgv.DataSource);
                    ((DataTable)dgv.DataSource).AcceptChanges();

                    MessageBox.Show(Helper.MessageAdded);
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        #endregion
    }
}
