using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace encyclopedia_database
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();

            tablesComboBox.DataSource = Enum.GetValues(typeof(Helper.Tables));
            tablesComboBox.SelectedItem = "Street";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Helper.ShowRecord(searchStrIDTB, searchStrNNTB, searchStrONTB, searchStrFDTB, searchDGV, tablesComboBox.SelectedItem.ToString());
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void commitUpdButton_Click(object sender, EventArgs e)
        {
            if (Helper.un == "root")
            {
                
            }
            else MessageBox.Show("No access!");
        }

        private void declineUpdButton_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to decline changes?";
            const string caption = "Form closing";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            //var tab = tablesTab.SelectedTab.ToString();

            //switch (tab)
            //{
            //    case "Street":
            //        UpdateMethods.ShowRecordStreet(searchStrIDTB, searchStrNNTB, searchStrONTB, searchStrFDTB, searchDGV, "street");
            //        break;

            //    case "Square":
            //        UpdateMethods.ShowRecordSquare(searchSqrIDTB, searchSqrNNTB, searchSqrONTB, searchSqrFDTB, searchDGV, "square");
            //        break;

            //    case "Sight":
            //        UpdateMethods.ShowRecordSight(searchSightIDTB, searchSightNTB, searchSightFDTB, searchSightStrIDTB, searchDGV, "sight");
            //        break;

            //    case "Background":
            //        UpdateMethods.ShowRecordBackground(searchBcgrIDTB, searchBcgrSourceTB, searchBcgrContTB, searchBcgrYearTB, searchBcgrSightIDTB, searchDGV, "background");
            //        break;

            //    default:
            //        MessageBox.Show("Something went wrong!");
            //        break;
            //}

            UpdateMethods.ShowRecordStreet(searchStrIDTB, searchStrNNTB, searchStrONTB, searchStrFDTB, searchDGV, "street");
        }

        private void searchSqrButton_Click(object sender, EventArgs e)
        {
            UpdateMethods.ShowRecordSquare(searchSqrIDTB, searchSqrNNTB, searchSqrONTB, searchSqrFDTB, searchDGV, "square");
        }

        private void searchSightButton_Click(object sender, EventArgs e)
        {
            UpdateMethods.ShowRecordSight(searchSightIDTB, searchSightNTB, searchSightFDTB, searchSightStrIDTB, searchDGV, "sight");
        }

        private void searchBcgrButton_Click(object sender, EventArgs e)
        {
            UpdateMethods.ShowRecordBackground(searchBcgrIDTB, searchBcgrSourceTB, searchBcgrContTB, searchBcgrYearTB, searchBcgrSightIDTB, searchDGV, "background");
        }
    }
}
