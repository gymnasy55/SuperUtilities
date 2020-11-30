using System;
using System.Windows.Forms;

namespace SuperUtilities
{
    public partial class NewGuidForm : Form
    {
        public NewGuidForm()
        {
            InitializeComponent();
        }

        private void NewGuid()
        {
            txtGuid.Text = Guid.NewGuid().ToString();
        }

        private void NewGuidForm_Load(object sender, EventArgs e)
        {
            NewGuid();
        }

        private void btnNewGuid_Click(object sender, EventArgs e)
        {
            NewGuid();
        }
    }
}
