using System;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace AskaBuilder.AskaForms
{
    public partial class LoaderWindow : Form
    {
        private int _currentStep = 0;
        private Timer _timer;

        public LoaderWindow()
        {
            InitializeComponent();
        }

        private void LoaderWindow_Load(object sender, EventArgs e)
        {
            StartCheckProcess();
        }

        private void StartCheckProcess()
        {
            _timer = new Timer();
            _timer.Interval = 200;
            _timer.Tick += Timer_Tick; 
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                string modulesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Modules");
                string protectToolPath = Path.Combine(modulesPath, "ProtectTool");
                string signToolPath = Path.Combine(modulesPath, "SignTool");

                string reactorLib = Path.Combine(protectToolPath, "reactor.lib");
                string signToolExe = Path.Combine(signToolPath, "SignTool.exe");

                int totalSteps = 4;

                switch (_currentStep)
                {
                    case 0:
                        UpdateStatus("Checking 'Modules' folder...");
                        if (!Directory.Exists(modulesPath))
                            throw new FileNotFoundException("'Modules' folder not found.");
                        UpdateProgress(++_currentStep, totalSteps);
                        break;

                    case 1:
                        UpdateStatus("Checking 'ProtectTool' folder...");
                        if (!Directory.Exists(protectToolPath))
                            throw new FileNotFoundException("'ProtectTool' folder not found.");
                        UpdateProgress(++_currentStep, totalSteps);
                        break;

                    case 2:
                        UpdateStatus("Checking 'reactor.lib'...");
                        if (!File.Exists(reactorLib))
                            throw new FileNotFoundException("'reactor.lib' not found.");
                        UpdateProgress(++_currentStep, totalSteps);
                        break;

                    case 3:
                        UpdateStatus("Checking 'SignTool.exe'...");
                        if (!File.Exists(signToolExe))
                            throw new FileNotFoundException("'SignTool.exe' not found.");
                        UpdateProgress(++_currentStep, totalSteps);
                        break;

                    case 4:
                        UpdateStatus("All modules are present. Launching MainWindow...");
                        _timer.Stop();
                        this.Close();
                        break;
                }
            }
            catch (FileNotFoundException ex)
            {
                _timer.Stop();

                var result = MessageBox.Show(
                    $"{ex.Message}\n\nDo you want to continue?",
                    "Module Missing",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    _timer.Stop();
                    this.Close();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void UpdateStatus(string message)
        {
            AskaLoadLabel.Text = message;
            Application.DoEvents();
        }

        private void UpdateProgress(int step, int totalSteps)
        {
            ProgressCheckBar.Value = (int)((double)step / totalSteps * 100);
            Application.DoEvents(); 
        }
    }
}
