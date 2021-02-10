using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    abstract class SquareFactory
    {
        public abstract AbstractSquare GetSquare(int position);
    }
}
