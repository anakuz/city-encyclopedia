using System;
using System.Windows.Forms;

namespace encyclopedia_database
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void commitStreetButton_Click(object sender, EventArgs e)
        {
            var stryear = strYearTextBox.Text + "-01-01";
            AddMethods.AddStreetRecordForm(strNNTextBox.Text, strONTextBox.Text, stryear);

            strNNTextBox.Clear();
            strONTextBox.Clear();
            strYearTextBox.Clear();
        }

        private void commitSightButton_Click(object sender, EventArgs e)
        {
            var sightyear = sightYearTextBox.Text + "-01-01";
            AddMethods.AddSightRecordForm(sightNameTextBox.Text, sightyear, int.Parse(strFKTextBox.Text));

            sightNameTextBox.Clear();
            sightYearTextBox.Clear();
            strFKTextBox.Clear();

        }

        private void backgroundCommitButton_Click(object sender, EventArgs e)
        {
            var bcgryear = bcgrYearTextBox.Text + "-01-01";
            AddMethods.AddBackgroundRecordForm(bcgrSourceTextBox.Text, bcgryear, bcgrContTextBox.Text, int.Parse(sightFKTextBox.Text));

            bcgrSourceTextBox.Clear();
            bcgrYearTextBox.Clear();
            bcgrContTextBox.Clear();
            sightFKTextBox.Clear();
        }

        private void commitButton_Click(object sender, EventArgs e) // square tab
        {
            var sqryear = sqrYearTextBox.Text + "-01-01";
            AddMethods.AddSquareRecordForm(sqrNNameTextBox.Text, sqrONameTextBox.Text, sqryear);

            sqrNNameTextBox.Clear();
            sqrONameTextBox.Clear();
            sqrYearTextBox.Clear();
        }

        private void declineButton_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
