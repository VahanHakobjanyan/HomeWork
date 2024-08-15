using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Behavior
{
    internal interface IDamagable
    {
        byte Health { get; }
        void LowerHealth();
    }
}
