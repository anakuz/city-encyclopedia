using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace encyclopedia_database
{
    internal class UpdateMethods
    {
        public static void ShowRecordStreet(TextBox strid, TextBox strnn, TextBox stron, TextBox strfd, DataGridView searchDGV, string table)
        {
            const string connStr = "server=localhost;user=root;database=mydb;password=12332;allow user variables = true";
            var criteria = "";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var comm = new MySqlCommand();

                    if (strid.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        criteria += "idstreet=" + strid.Text;
                    }

                    if (strnn.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        criteria += "newnamestreet=" + "\'" + strnn.Text + "\'";
                    }

                    if (stron.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        criteria += "oldnamestreet=" + "\'" + stron.Text + "\'";
                    }

                    if (strfd.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        var date = strfd.Text + "-01-01";
                        criteria += "foundingdatestreet=" + "\'" + date + "\'";
                    }

                    //comm = new MySqlCommand("SELECT * FROM " + table + " WHERE id" + table + " = " + id + criteria, conn);
                    comm = new MySqlCommand("SELECT * FROM " + table + " WHERE " + criteria, conn);
                    var adapter = new MySqlDataAdapter(comm);
                    searchDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    var ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count == 0)
                        MessageBox.Show("No records found!");
                    else
                        searchDGV.DataSource = ds.Tables[0];

                    var builder = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    adapter.Update((DataTable)searchDGV.DataSource);
                    ((DataTable)searchDGV.DataSource).AcceptChanges();
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        public static void ShowRecordSquare(TextBox sqrid, TextBox sqrnn, TextBox sqron, TextBox sqrfd, DataGridView searchDGV, string table)
        {
            const string connStr = "server=localhost;user=root;database=mydb;password=12332;allow user variables = true";
            var criteria = "";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var comm = new MySqlCommand();

                    if (sqrid.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        criteria += "idsquare=" + sqrid.Text;
                    }

                    if (sqrnn.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        criteria += "newnamesquare=" + "\'" + sqrnn.Text + "\'";
                    }

                    if (sqron.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        criteria += "oldnamesquare=" + "\'" + sqron.Text + "\'";
                    }

                    if (sqrfd.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        var date = sqrfd.Text + "-01-01";
                        criteria += "foundingdatesquare=" + "\'" + date + "\'";
                    }

                    //comm = new MySqlCommand("SELECT * FROM " + table + " WHERE id" + table + " = " + id + criteria, conn);
                    comm = new MySqlCommand("SELECT * FROM " + table + " WHERE " + criteria, conn);
                    var adapter = new MySqlDataAdapter(comm);
                    searchDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    var ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count == 0)
                        MessageBox.Show("No records found!");
                    else
                        searchDGV.DataSource = ds.Tables[0];

                    var builder = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    adapter.Update((DataTable)searchDGV.DataSource);
                    ((DataTable)searchDGV.DataSource).AcceptChanges();
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        public static void ShowRecordSight(TextBox sid, TextBox sn, TextBox sy, TextBox sstrid, DataGridView searchDGV, string table)
        {
            const string connStr = "server=localhost;user=root;database=mydb;password=12332;allow user variables = true";
            var criteria = "";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var comm = new MySqlCommand();

                    if (sid.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        criteria += "idsight=" + sid.Text;
                    }

                    if (sn.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        criteria += "namesight=" + "\'" + sn.Text + "\'";
                    }

                    if (sy.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        var date = sstrid.Text + "-01-01";
                        criteria += "foundingdatesight=" + "\'" + date + "\'";
                    }

                    if (sstrid.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        criteria += "idstreet=" + sstrid.Text;
                    }

                    //comm = new MySqlCommand("SELECT * FROM " + table + " WHERE id" + table + " = " + id + criteria, conn);
                    comm = new MySqlCommand("SELECT * FROM " + table + " WHERE " + criteria, conn);
                    var adapter = new MySqlDataAdapter(comm);
                    searchDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    var ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count == 0)
                        MessageBox.Show("No records found!");
                    else
                        searchDGV.DataSource = ds.Tables[0];

                    var builder = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    adapter.Update((DataTable)searchDGV.DataSource);
                    ((DataTable)searchDGV.DataSource).AcceptChanges();
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        public static void ShowRecordBackground(TextBox bid, TextBox bs, TextBox bc, TextBox byear, TextBox bsid, DataGridView searchDGV, string table)
        {
            const string connStr = "server=localhost;user=root;database=mydb;password=12332;allow user variables = true";
            var criteria = "";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var comm = new MySqlCommand();

                    if (bid.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        criteria += "idbackground=" + bid.Text;
                    }

                    if (bs.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        criteria += "sourcebackground=" + "\'" + bs.Text + "\'";
                    }

                    if (bc.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        criteria += "contentsbackground=" + "\'" + bc.Text + "\'";
                    }

                    if (byear.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        var date = byear.Text + "-01-01";
                        criteria += "yearvackground=" + "\'" + date + "\'";
                    }

                    if (bsid.Text.Length != 0)
                    {
                        if (criteria.Length != 0)
                            criteria += " AND ";
                        criteria += "idsight=" + bsid.Text;
                    }

                    //comm = new MySqlCommand("SELECT * FROM " + table + " WHERE id" + table + " = " + id + criteria, conn);
                    comm = new MySqlCommand("SELECT * FROM " + table + " WHERE " + criteria, conn);
                    var adapter = new MySqlDataAdapter(comm);
                    searchDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    var ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count == 0)
                        MessageBox.Show("No records found!");
                    else
                        searchDGV.DataSource = ds.Tables[0];

                    var builder = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    adapter.Update((DataTable)searchDGV.DataSource);
                    ((DataTable)searchDGV.DataSource).AcceptChanges();
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
    }
}
