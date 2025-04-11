using AskaBuilder.AskaAlgorithms.FormHelper;
using System;
using System.IO;
using System.Windows.Forms;

namespace AskaBuilder.AskaForms
{
    public partial class ProtectorWindow : Form
    {
        public ProtectorWindow()
        {
            InitializeComponent();
        }
        private void ProtectBtn_Click(object sender, EventArgs e)
        {
            string reactorPath = "Modules\\ProtectTool\\reactor.lib";
            string fileToProtect = FileProtect1Path.Text;

            if (!File.Exists(reactorPath))
            {
                MessageBoxEx.Text = "Reactor library does not exist!";
                MessageBoxEx.Show();
                return;
            }

            if (string.IsNullOrEmpty(fileToProtect) || !File.Exists(fileToProtect))
            {
                MessageBoxEx.Text = "Please select a valid file to protect!";
                MessageBoxEx.Show();
                return;
            }

            if (!LightWeightChk.Checked && !MediumChk.Checked && !StrongChk.Checked)
            {
                MessageBoxEx.Text = "Please select a protection level!";
                MessageBoxEx.Show();
                return;
            }

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "Save protected EXE file - [ A S K A ] -";
                save.Filter = "EXE Files (*.exe)|*.exe";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ProtectorEngine.Protect(
                            LightWeightChk.Checked,
                            MediumChk.Checked,
                            StrongChk.Checked,
                            reactorPath,
                            fileToProtect,
                            save.FileName
                        );

                        if (File.Exists(save.FileName))
                        {
                            MessageBoxEx.Text = $"Protection successful! File saved at: {save.FileName}";
                        }

                        else
                        {
                            MessageBoxEx.Text = "Protection failed. The target file was not created.";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBoxEx.Text = $"An error occurred: {ex.Message}";
                    }

                    MessageBoxEx.Show();
                }
            }
        }
        private void SelectFile1Btn_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Open EXE file to protect - [ A S K A ] -";
                open.Filter = "EXE Files (*.exe)|*.exe";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    FileProtect1Path.Text = open.FileName;
                }
            }
        }
    }
}
