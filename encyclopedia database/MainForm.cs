using System;
using System.Windows.Forms;

namespace encyclopedia_database
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //ShowLogin();

            loggedLabel.Text = "Logged as: " + Helper.un;

            chooseTable_comboBox.DataSource = Enum.GetValues(typeof(Helper.Tables));
            chooseTable_comboBox.SelectedItem = "Street";

            tablesCB.DataSource = Enum.GetValues(typeof(Helper.Tables));
            tablesCB.SelectedItem = "Street";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Helper.RebindGridView(dataGridView1, chooseTable_comboBox.SelectedItem.ToString());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (Helper.un == "root")
            {
                var af = new AddForm();
                af.ShowDialog();
            }
            else MessageBox.Show("No access!");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        //private void ShowLogin()
        //{
        //    using (var lf = new LoginForm())
        //    {
        //        bool isLoggedIn = true;
        //        while (isLoggedIn)
        //        {
        //            Hide();
        //            lf.ShowDialog();
        //            if (lf.DialogResult == DialogResult.OK)
        //            {
        //                isLoggedIn = false;
        //                ShowDialog();
        //            }
        //            lf.Close();
        //        }
        //    }
        //}

        private void modifyButton_Click(object sender, EventArgs e)
        {
            var uf = new UpdateForm();
            uf.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Helper.un == "root")
            {
                var table = chooseTable_comboBox.SelectedItem.ToString();

                switch (table)
                {
                    case "Street":
                        DeleteMethods.DeleteStreetRecord(dataGridView1, table);
                        break;

                    case "Square":
                        DeleteMethods.DeleteSquareRecord(dataGridView1, table);
                        break;

                    case "Sight":
                        DeleteMethods.DeleteSightRecord(dataGridView1, table);
                        break;

                    case "Background":
                        DeleteMethods.DeleteBackgroundRecord(dataGridView1, table);
                        break;

                    default:
                        MessageBox.Show("Please choose a table.");
                        break;
                }
            }
            else MessageBox.Show("No access!");
        }

        private void searchB_Click(object sender, EventArgs e)
        {
           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Helper.un == "root")
            {
                var table = chooseTable_comboBox.SelectedItem.ToString();

                switch (table)
                {
                    case "Street":
                        AddMethods.AddStreetRecordDgv(dataGridView1, table);
                        break;

                    case "Square":
                        AddMethods.AddSquareRecordDgv(dataGridView1, table);
                        break;

                    case "Sight":
                        AddMethods.AddSightRecordDgv(dataGridView1, table);
                        break;

                    case "Background":
                        AddMethods.AddBackgroundRecordDgv(dataGridView1, table);
                        break;

                    default:
                        MessageBox.Show("Please choose a table.");
                        break;
                }
            }
            else MessageBox.Show("No access!");
        }
    }
}
