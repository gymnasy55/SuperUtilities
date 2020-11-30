using System;
using System.Windows.Forms;

namespace SuperUtilities
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(cmbMode.SelectedItem.ToString() == "Color Matching")
            {
                var form = new ColorMatchingForm();
                form.ShowDialog();
            }
            else if (cmbMode.SelectedItem.ToString() == "New Guid")
            {
                var form = new NewGuidForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("In progress...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
