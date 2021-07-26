using System;
using System.IO;
using System.Security.Cryptography;

namespace Cryptush.lib
{
    public class dAES
    {
        public static string TrimEnd(string str, string trimStr)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(trimStr)) return str;

            while (str.EndsWith(trimStr))
            {
                str = str.Remove(str.LastIndexOf(trimStr));
            }
            return str;
        }
        public static string DecFile(string inputFile, string key)
        {
            try
            {
                string outputFileName = TrimEnd(inputFile, ".Cryptush");
                Aes aes = Aes.Create();
                // if the key is defined here then aes.KeyValue will ne null, don't know why
                aes.IV = new byte[16] { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 };
                aes.Padding = PaddingMode.Zeros;
                aes.Mode = CipherMode.CBC;
                aes.KeySize = 256;
                aes.BlockSize = 128;

                ICryptoTransform decryptor = aes.CreateDecryptor(Convert.FromBase64String(key), aes.IV); // worked only when the key is a parameter here

                using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (FileStream fsOut = new FileStream(outputFileName, FileMode.Create))
                        {
                            int read;
                            byte[] buffer = new byte[1048576];
                            while ((read = cryptoStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                fsOut.Write(buffer, 0, read);
                            }
                        }
                    }
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
