namespace câu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = txtPassword.Text;
        }
        private void btnTiep_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "";
            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
