using SimpleGame.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Entities
{
    internal class Character : GameObject, IMovable, IAttackable, IDamagable
    {
        public byte Health { get; private set; }
        public Character(string name)
        {
            Name = name;
            isSolid = true;
            isPlayableCharacter = true;
            Health = 100;
        }

        public void Move(Direction direction)
        {
            Console.WriteLine($"Moving to the {direction}");
        }

        public void Attack(GameObject target)
        {
            if (target is IDamagable)
            {
                Console.WriteLine("Attacking target");
            }
        }

        public void LowerHealth()
        {
            Health -= 5;
        }
    }
}
