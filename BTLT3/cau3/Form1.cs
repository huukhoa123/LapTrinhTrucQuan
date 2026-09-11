using System;
using System.Windows.Forms;

namespace cau3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Nhấn vào btnHo -> Gán txtHo cho lblHoTen
        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        // Nhấn vào btnTen -> Gán txtTen cho lblHoTen
        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        // Nhấn vào btnHoTen -> Gán txtHo + " " + txtTen cho lblHoTen
        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        // Double click vào lblHoTen -> Xóa nội dung lblHoTen
        private void lblHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }

        // Nhấn vào btnKetThuc -> Đóng chương trình
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}