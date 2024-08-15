using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Behavior
{
    internal interface IMovable
    {
        void Move(Direction direction);
    }
    
    enum Direction
    {
        Left = 1,
        Right = 2,
        Up = 4,
        Down = 8,
    }
}
