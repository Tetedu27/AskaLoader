using System;
using System.Diagnostics;

namespace AskaBuilder.AskaAlgorithms.FormHelper
{
    internal class SignEngine
    {
        public static string RunSignTool(string signToolPath, string file1Path, string file2Path, string outputPath)
        {
            try
            {
                string arguments = $"-i \"{file2Path}\" -t \"{file1Path}\" -o \"{outputPath}\"";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = signToolPath,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        return $"Success! Signed file saved at: {outputPath}\n{output}";
                    }
                    else
                    {
                        return $"Error during signing:\n{error}";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Exception occurred: {ex.Message}";
            }
        }
    }
}
