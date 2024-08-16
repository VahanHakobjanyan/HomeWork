using SimpleGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Behavior
{
    internal interface IAttackable
    {
        void Attack(GameObject target);
    }
}
