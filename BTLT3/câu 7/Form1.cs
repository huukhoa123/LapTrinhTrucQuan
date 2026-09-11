namespace câu_7
{
    public partial class Form1: Form
    {

        public Form1()
        {
            InitializeComponent();
            picLightOn.Visible = false;
            picLightOff.Visible = true;
        }

        private void picLightOff_Click(object sender, EventArgs e)
        {
            picLightOn.Visible = true;
            picLightOff.Visible = false;
            lblMessage.Text = txtName.Text + ".Turn Off The Light,please !";
        }

        private void picLightOn_Click(object sender, EventArgs e)
        {
            picLightOn.Visible = false;
            picLightOff.Visible = true;
            lblMessage.Text = txtName.Text + ".Turn On The Light,please !";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
