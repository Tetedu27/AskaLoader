using System.Diagnostics;
using System.Windows.Forms;

namespace AskaBuilder.AskaForms
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void OpenRepositoryBtn_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev/AskaLoader");
        }
    }
}
