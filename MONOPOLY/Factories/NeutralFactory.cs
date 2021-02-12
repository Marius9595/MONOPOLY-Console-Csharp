using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class NeutralFactory : SquareFactory
    {
        public override AbstractSquare GetSquare(int position)
        {
            return new NeutralSquare(position);
        }
    }
}
