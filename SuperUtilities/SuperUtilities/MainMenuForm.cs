using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if(cmbMode.SelectedItem == "Color Matching")
            {
                ColorMatchingForm form = new ColorMatchingForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("In progress...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
