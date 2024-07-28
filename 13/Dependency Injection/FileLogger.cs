using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    internal class FileLogger : ILogger
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "TestLog.txt";

        public void Log(string message)
        {
            //creating or overwriting existing file
            using (StreamWriter writer = File.CreateText(path))
            {
                writer.WriteLine(message);
            }

            //opening file in console
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}