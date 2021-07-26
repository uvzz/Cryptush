using System;
using System.IO;

namespace Server.lib
{
    class Logger
    {
        public static bool WriteLog(string type, string strMessage)
        {
            try
            {
                using (FileStream objFilestream = new("CryptushServer.log", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter objStreamWriter = new((Stream)objFilestream))
                    {
                        objStreamWriter.WriteLine($"{DateTime.Now}:{type}:{strMessage}");
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
