namespace firstWork
{
    public partial class PaswdHide : UserControl
    {
        public PaswdHide()
        {
            InitializeComponent();
        }

        public string Label
        {
            get => lblPassword.Text;
            set => lblPassword.Text = value;
        }

        public string Password
        {
            get => txbPassword.Text;
            set => txbPassword.Text = value;
        }

        private void btnShowPswd_Click(object sender, EventArgs e)
        {
            if (txbPassword.UseSystemPasswordChar == false)
            {
                txbPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
