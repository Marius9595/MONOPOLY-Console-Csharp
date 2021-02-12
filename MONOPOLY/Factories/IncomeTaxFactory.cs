using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class IncomeTaxFactory : SquareFactory
    {
        public override AbstractSquare GetSquare(int position)
        {
            return new IncomeTaxSquare(position);
        }
    }
}
