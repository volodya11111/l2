namespace firstWork
{
    public partial class PersonRecordEditDialog : Form
    {
        public PersonRecordEditDialog()
        {
            InitializeComponent();
        }

        public void SetPersonData(string firstName, string secondName, string thirdName, string age)
        {
            tbxFirName.Text = firstName;
            tbxSecName.Text = secondName;
            tbxThiName.Text = thirdName;
            tbxAge.Text = age;
        }

        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public string ThirdName { get; private set; }
        public string Age { get; private set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FirstName = tbxFirName.Text;
            SecondName = tbxSecName.Text;
            ThirdName = tbxThiName.Text;
            Age = tbxAge.Text;

            DialogResult = DialogResult.OK;

            Close();
        }

        private void tbxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
