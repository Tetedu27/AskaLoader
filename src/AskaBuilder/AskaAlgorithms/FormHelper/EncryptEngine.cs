using System;
using System.IO;
using System.Linq;

namespace AskaBuilder.AskaAlgorithms.FormHelper
{
    internal class EncryptEngine
    {
        private static readonly Random random = new Random();

        public static void EncryptFileAndSave(string filePath, byte[] xorBytes, string outputFilePath)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            byte[] encryptedBytes = new byte[fileBytes.Length];

            for (int i = 0; i < encryptedBytes.Length; i++)
            {
                encryptedBytes[i] = (byte)(fileBytes[i] ^ xorBytes[i % xorBytes.Length]);
            }

            File.WriteAllBytes(outputFilePath, encryptedBytes);
        }


        public static string GenerateHexArray(byte[] data)
        {
            return "new byte[] { " + string.Join(", ", data.Select(b => "0x" + b.ToString("X2"))) + " };";
        }

        public static byte[] GenerateRandomBytes(int length)
        {
            byte[] bytes = new byte[length];
            random.NextBytes(bytes);
            return bytes;
        }

        public static string GenerateStrBytes(int length)
        {
            byte[] bytes = new byte[length];
            random.NextBytes(bytes);

            return BitConverter.ToString(bytes).Replace("-", " ");
        }

        public static string GenerateRandStr(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
