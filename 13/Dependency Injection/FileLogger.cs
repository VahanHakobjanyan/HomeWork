using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    internal class FileLogger : ILogger
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/TestLog.txt";

        public void Log(string message)
        {
            //creating or overwriting existing file
            using (StreamWriter writer = File.CreateText(path))
            {
                writer.WriteLine(message);
               
            }
            File.OpenText(path);
            
        }
    }
}