using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    internal class FileLogger : ILogger
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public void Log(string message)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                writer.WriteLine(message);
            }
        }
    }
}