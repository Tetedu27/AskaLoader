using System;
using System.Diagnostics;

namespace AskaBuilder.AskaAlgorithms.FormHelper
{
    internal class ProtectorEngine
    {
        public static void Protect(bool light, bool medium, bool strong, string reactorPath, string inputFile, string outFile)
        {
            string commandline;

            if (strong)
            {
                commandline = "-internalization 1 -antitamp 1 -hide_calls 1 -hide_calls_internals 1 " +
                              "-control_flow_obfuscation 1 -flow_level 8 -nativeexe 1 -prejit 1 -stringencryption 1 " +
                              "-antistrong 1 -necrobit 1 -all_params 1 -naming unprintable -obfuscate_public_types 1";
            }
            else if (medium)
            {
                commandline = "-antitamp 1 -control_flow_obfuscation 1 -flow_level 5 -necrobit 1 -obfuscate_public_types 1-obfuscate_public_types 1";
            }
            else if (light)
            {
                commandline = "-antitamp 1 -control_flow_obfuscation 1 -flow_level 3  -necrobit 1";
            }
            else
            {
                throw new ArgumentException("No protection level selected.");
            }

            RunReactor(commandline, reactorPath, inputFile, outFile);
        }

        private static void RunReactor(string commandline, string reactorPath, string inputFile, string outFile)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = reactorPath,
                Arguments = $"{commandline} -file \"{inputFile}\" -targetfile {outFile}",
                UseShellExecute = false,
                CreateNoWindow = true
            })?.WaitForExit(); 
        }
    }
}
