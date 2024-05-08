using System.ComponentModel;
using System.Diagnostics;

namespace firstWork
{
    public partial class timeDebug : Component
    {
        public event EventHandler Tick;

        public timeDebug()
        {
            InitializeComponent();
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            Tick?.Invoke(this, EventArgs.Empty);

            Debug.WriteLine($"{DateTime.Now}");
        }
    }
}
