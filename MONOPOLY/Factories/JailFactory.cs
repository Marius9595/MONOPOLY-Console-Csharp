using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class JailFactory : SquareFactory
    {
        public override AbstractSquare GetSquare(int position)
        {
            return new JailSquare(position);
        }
    }
}
