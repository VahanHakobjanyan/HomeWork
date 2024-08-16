using SimpleGame.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Entities
{
    internal class Enemy : GameObject, IDamagable
    {
        public byte Health {  get; private set; }
        public Enemy(string name)
        {
            Name = name;
            isSolid = true;
            isPlayableCharacter = false;
        }
        public void LowerHealth()
        {
            Health -= 5;
        }
    }
}
