using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace câu4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtNhapTen.Focus();
            radRed.Checked = true;
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lblLapTrinh.ForeColor = Color.Red;
                txtNhapTen.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblLapTrinh.ForeColor = Color.Green;
                txtNhapTen.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lblLapTrinh.ForeColor = Color.Blue;
                txtNhapTen.ForeColor = Color.Blue;
            }
        }
        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                lblLapTrinh.ForeColor = Color.Black;
                txtNhapTen.ForeColor = Color.Black;
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBold.Checked)
            {
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, FontStyle.Bold);
                txtNhapTen.Font = new Font(txtNhapTen.Font, FontStyle.Bold);
            }
            else
            {
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, FontStyle.Regular);
                txtNhapTen.Font = new Font(txtNhapTen.Font, FontStyle.Regular);
            }
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItalic.Checked)
            {
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, FontStyle.Italic);
                txtNhapTen.Font = new Font(txtNhapTen.Font, FontStyle.Italic);
            }
            else
            {
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, FontStyle.Regular);
                txtNhapTen.Font = new Font(txtNhapTen.Font, FontStyle.Regular);
            }
        }
        private void chkUnderLine_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnderLine.Checked)
            {
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, FontStyle.Underline);
                txtNhapTen.Font = new Font(txtNhapTen.Font, FontStyle.Underline);
            }
            else
            {
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, FontStyle.Regular);
                txtNhapTen.Font = new Font(txtNhapTen.Font, FontStyle.Regular);
            }
        }


    }
}
