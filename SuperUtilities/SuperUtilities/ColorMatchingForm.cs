using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace SuperUtilities
{
    public partial class ColorMatchingForm : Form
    {
        public ColorMatchingForm()
        {
            InitializeComponent();
        }

        private void txtBackgroundR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtBackgroundR.Text) >= 0 && Convert.ToInt32(txtBackgroundR.Text) <= 255)
                {
                    trbBackgroundR.Value = Convert.ToInt32(txtBackgroundR.Text);
                    Color clr = Color.FromArgb(trbBackgroundR.Value, trbBackgroundG.Value, trbBackgroundB.Value);
                    lblSample.BackColor = clr;
                    txtBackgroundHEX.Text = clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
                }
                else
                {
                    MessageBox.Show("Incorrect value");
                    txtBackgroundR.Text = txtBackgroundR.Text.Remove(txtBackgroundR.Text.Length - 1, 1);
                }
            }
            catch(Exception ex)
            {
                if (txtBackgroundR.Text.Length > 0)
                {
                    MessageBox.Show("Incorrect value");
                    txtBackgroundR.Text = txtBackgroundR.Text.Remove(txtBackgroundR.Text.Length - 1, 1);
                }
            }
        }

        private void trbBackgroundR_Scroll(object sender, EventArgs e)
        {
            txtBackgroundR.Text = trbBackgroundR.Value.ToString();
            Color clr = Color.FromArgb(trbBackgroundR.Value, trbBackgroundG.Value, trbBackgroundB.Value);
            lblSample.BackColor = clr;
            txtBackgroundHEX.Text = clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
        }

        private void txtBackgroundG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtBackgroundG.Text) >= 0 && Convert.ToInt32(txtBackgroundG.Text) <= 255)
                {
                    trbBackgroundG.Value = Convert.ToInt32(txtBackgroundG.Text);
                    Color clr = Color.FromArgb(trbBackgroundR.Value, trbBackgroundG.Value, trbBackgroundB.Value);
                    lblSample.BackColor = clr;
                    txtBackgroundHEX.Text = clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
                }
                else
                {
                    MessageBox.Show("Incorrect value");
                    txtBackgroundG.Text = txtBackgroundG.Text.Remove(txtBackgroundG.Text.Length - 1, 1);
                }
            }
            catch (Exception ex)
            {
                if (txtBackgroundG.Text.Length > 0)
                {
                    MessageBox.Show("Incorrect value");
                    txtBackgroundG.Text = txtBackgroundG.Text.Remove(txtBackgroundG.Text.Length - 1, 1);
                }
            }
        }

        private void trbBackgroundG_Scroll(object sender, EventArgs e)
        {
            txtBackgroundG.Text = trbBackgroundG.Value.ToString();
            Color clr = Color.FromArgb(trbBackgroundR.Value, trbBackgroundG.Value, trbBackgroundB.Value);
            lblSample.BackColor = clr;
            txtBackgroundHEX.Text = clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
        }

        private void txtBackgroundB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtBackgroundB.Text) >= 0 && Convert.ToInt32(txtBackgroundB.Text) <= 255)
                {
                    trbBackgroundB.Value = Convert.ToInt32(txtBackgroundB.Text);
                    Color clr = Color.FromArgb(trbBackgroundR.Value, trbBackgroundG.Value, trbBackgroundB.Value);
                    lblSample.BackColor = clr;
                    txtBackgroundHEX.Text = clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
                }
                else
                {
                    MessageBox.Show("Incorrect value");
                    txtBackgroundB.Text = txtBackgroundB.Text.Remove(txtBackgroundB.Text.Length - 1, 1);
                }
            }
            catch (Exception ex)
            {
                if (txtBackgroundG.Text.Length > 0)
                {
                    MessageBox.Show("Incorrect value");
                    txtBackgroundB.Text = txtBackgroundB.Text.Remove(txtBackgroundB.Text.Length - 1, 1);
                }
            }
        }

        private void trbBackgroundB_Scroll(object sender, EventArgs e)
        {
            txtBackgroundB.Text = trbBackgroundB.Value.ToString();
            Color clr = Color.FromArgb(trbBackgroundR.Value, trbBackgroundG.Value, trbBackgroundB.Value);
            lblSample.BackColor = clr;
            txtBackgroundHEX.Text = clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
        }

        private void txtFontR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtFontR.Text) >= 0 && Convert.ToInt32(txtFontR.Text) <= 255)
                {
                    trbFontR.Value = Convert.ToInt32(txtFontR.Text);
                    Color clr = Color.FromArgb(trbFontR.Value, trbFontG.Value, trbFontB.Value);
                    lblSample.ForeColor = clr;
                    txtFontHEX.Text = clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
                }
                else
                {
                    MessageBox.Show("Incorrect value");
                    txtFontR.Text = txtFontR.Text.Remove(txtFontR.Text.Length - 1, 1);
                }
            }
            catch (Exception ex)
            {
                if (txtFontR.Text.Length > 0)
                {
                    MessageBox.Show("Incorrect value");
                    txtFontR.Text = txtFontR.Text.Remove(txtFontR.Text.Length - 1, 1);
                }
            }
        }

        private void trbFontR_Scroll(object sender, EventArgs e)
        {
            txtFontR.Text = trbFontR.Value.ToString();
            Color clr = Color.FromArgb(trbFontR.Value, trbFontG.Value, trbFontB.Value);
            lblSample.ForeColor = clr;
            txtFontHEX.Text = clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
        }

        private void txtFontG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtFontG.Text) >= 0 && Convert.ToInt32(txtFontG.Text) <= 255)
                {
                    trbFontG.Value = Convert.ToInt32(txtFontG.Text);
                    Color clr = Color.FromArgb(trbFontR.Value, trbFontG.Value, trbFontB.Value);
                    lblSample.ForeColor = clr;
                    txtFontHEX.Text = clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
                }
                else
                {
                    MessageBox.Show("Incorrect value");
                    txtFontG.Text = txtFontG.Text.Remove(txtFontG.Text.Length - 1, 1);
                }
            }
            catch (Exception ex)
            {
                if (txtFontG.Text.Length > 0)
                {
                    MessageBox.Show("Incorrect value");
                    txtFontG.Text = txtFontG.Text.Remove(txtFontG.Text.Length - 1, 1);
                }
            }
        }

        private void trbFontG_Scroll(object sender, EventArgs e)
        {
            txtFontG.Text = trbFontG.Value.ToString();
            Color clr = Color.FromArgb(trbFontR.Value, trbFontG.Value, trbFontB.Value);
            lblSample.ForeColor = clr;
            txtFontHEX.Text = clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
        }

        private void txtFontB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtFontB.Text) >= 0 && Convert.ToInt32(txtFontB.Text) <= 255)
                {
                    trbFontB.Value = Convert.ToInt32(txtFontB.Text);
                    Color clr = Color.FromArgb(trbFontR.Value, trbFontG.Value, trbFontB.Value);
                    lblSample.ForeColor = clr;
                    txtFontHEX.Text = clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
                }
                else
                {
                    MessageBox.Show("Incorrect value");
                    txtFontB.Text = txtFontB.Text.Remove(txtFontB.Text.Length - 1, 1);
                }
            }
            catch (Exception ex)
            {
                if (txtFontB.Text.Length > 0)
                {
                    MessageBox.Show("Incorrect value");
                    txtFontB.Text = txtFontB.Text.Remove(txtFontB.Text.Length - 1, 1);
                }
            }
        }

        private void trbFontB_Scroll(object sender, EventArgs e)
        {
            txtFontB.Text = trbFontB.Value.ToString();
            Color clr = Color.FromArgb(trbFontR.Value, trbFontG.Value, trbFontB.Value);
            lblSample.ForeColor = clr;
            txtFontHEX.Text = clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
        }

        private void txtBackgroundHEX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string colorstring = txtBackgroundHEX.Text;
                if(colorstring.Length == 6)
                {
                    int R = Int32.Parse(colorstring.Substring(0, 2), NumberStyles.HexNumber);
                    int G = Int32.Parse(colorstring.Substring(2, 2), NumberStyles.HexNumber);
                    int B = Int32.Parse(colorstring.Substring(4, 2), NumberStyles.HexNumber);
                    trbBackgroundR.Value = R;
                    trbBackgroundG.Value = G;
                    trbBackgroundB.Value = B;
                    txtBackgroundR.Text = trbBackgroundR.Value.ToString();
                    txtBackgroundG.Text = trbBackgroundG.Value.ToString();
                    txtBackgroundB.Text = trbBackgroundB.Value.ToString();
                    Color clr = Color.FromArgb(trbBackgroundR.Value, trbBackgroundG.Value, trbBackgroundB.Value);
                    lblSample.BackColor = clr;
                }
            }
            catch(Exception ex)
            {
                if (txtBackgroundHEX.Text.Length > 0)
                {
                    MessageBox.Show("Incorrect value");
                    txtBackgroundHEX.Text = txtBackgroundHEX.Text.Remove(txtBackgroundHEX.Text.Length - 1, 1);
                }
            }
            
        }

        private void txtFontHEX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string colorstring = txtFontHEX.Text;
                if (colorstring.Length == 6)
                {
                    int R = Int32.Parse(colorstring.Substring(0, 2), NumberStyles.HexNumber);
                    int G = Int32.Parse(colorstring.Substring(2, 2), NumberStyles.HexNumber);
                    int B = Int32.Parse(colorstring.Substring(4, 2), NumberStyles.HexNumber);
                    trbFontR.Value = R;
                    trbFontG.Value = G;
                    trbFontB.Value = B;
                    txtFontR.Text = trbFontR.Value.ToString();
                    txtFontG.Text = trbFontG.Value.ToString();
                    txtFontB.Text = trbFontB.Value.ToString();
                    Color clr = Color.FromArgb(trbFontR.Value, trbFontG.Value, trbFontB.Value);
                    lblSample.ForeColor = clr;
                }
            }
            catch (Exception ex)
            {
                if (txtFontHEX.Text.Length > 0)
                {
                    MessageBox.Show("Incorrect value");
                    txtFontHEX.Text = txtFontHEX.Text.Remove(txtFontHEX.Text.Length - 1, 1);
                }
            }
        }
    }
}