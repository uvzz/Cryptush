using System.Collections.Generic;
using System.IO;

namespace Cryptush.lib
{
    class dCollector
    {
        public static List<string> Start(string[] paths)
        {
            var files = new List<string> { };
            foreach (string path in paths)
            {
                if (Directory.Exists(path)) { files.AddRange(CollectFromPath(path)); }
            }
            return files;
        }

        public static List<string> CollectFromPath(string path)
        {
            var files = new List<string> { };

            foreach (string file in Directory.GetFiles(path, string.Format("*.Cryptush"), SearchOption.TopDirectoryOnly))
            {
                files.Add(file);
            }        

            foreach (string subDir in Directory.GetDirectories(path))
            {
                try
                {
                    var subDirFiles = CollectFromPath(subDir);
                    foreach (string file in subDirFiles)
                    {
                        files.Add(file);
                    }
                }
                catch
                {
                }
            }
            return files;
        }
    }
}
