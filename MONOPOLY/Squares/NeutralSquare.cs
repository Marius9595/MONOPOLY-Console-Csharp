using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY.Squares
{
    public enum TypeNeutral {VisitingJail,FreeAutoParking,StartSquare}
    class NeutralSquare: AbstractSquare
    {

        public NeutralSquare(int position) : base(position)
        {

        }

    }
}
