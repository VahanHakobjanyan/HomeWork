using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Entities
{
    internal class Weapon : GameObject
    {
        public Weapon(string name)
        {
            Name = name;
            isPlayableCharacter = false;
            isSolid = false;
        }
    }
}
