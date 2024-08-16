using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Entities
{
    abstract class GameObject
    {
        public string Name { get; set; }
        internal bool isPlayableCharacter;
        internal bool isSolid;

        public void DeleteObject()
        {
            Console.WriteLine("Object is removed");
        }
    }
}
