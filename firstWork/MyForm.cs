namespace firstWork
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void TimeDebug_Tick(object? sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            MyForm myForm = new MyForm();
            myForm.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
