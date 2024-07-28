using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    internal class Service
    {
        public Service(ILogger logger, string message) 
        {
            logger.Log(message);
        }
    }
}
