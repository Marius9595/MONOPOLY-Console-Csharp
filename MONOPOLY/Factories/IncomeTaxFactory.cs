using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY.Factories
{
    class IncomeTaxFactory : SquareFactory
    {
        public override AbstractSquare GetSquare(int position)
        {
            return new Squares.IncomeTaxSquare(position);
        }
    }
}
