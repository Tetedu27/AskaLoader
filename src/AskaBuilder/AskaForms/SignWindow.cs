using AskaBuilder.AskaAlgorithms.FormHelper;
using System;
using System.IO;
using System.Windows.Forms;

namespace AskaBuilder.AskaForms
{
    public partial class SignWindow : Form
    {
        public SignWindow()
        {
            InitializeComponent();
        }

        private void StealCertBtn_Click(object sender, EventArgs e)
        {
            string
                signProgram = Path.Combine("Modules\\SignTool\\", "SignTool.exe"),
                File1Path = FileSign1Path.Text,
                File2Path = FileSign2Path.Text;

            if (!File.Exists(signProgram))
            {
                MessageBoxEx.Text = "SignTool file does not exist!\nPlease check modules.";
                MessageBoxEx.Show();
                return;
            }

            if (string.IsNullOrEmpty(File1Path) || string.IsNullOrEmpty(File2Path))
            {
                MessageBoxEx.Text = "File path fields cannot be empty.\nPlease fill all fields.";
                MessageBoxEx.Show();
                return;
            }

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "Signed file saver - [ A S K A ] - ";
                save.Filter = "EXE (*.exe)|*.exe";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    string outputPath = save.FileName;

                    string result = SignEngine.RunSignTool(signProgram, File1Path, File2Path, outputPath);

                    MessageBoxEx.Text = result;
                    MessageBoxEx.Show();
                }
            }
        }

        private void SelectFile1Btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Open 1-EXE file to sign - [ A S K A ] -";
                open.Filter = "EXE (*.exe)|*.exe";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    FileSign1Path.Text = open.FileName;
                }
            }
        }
        private void SelectFile2Btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Open 2-EXE file to steal-sign - [ A S K A ] -";
                open.Filter = "EXE (*.exe)|*.exe";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    FileSign2Path.Text = open.FileName;
                }
            }
        }
    }
}
