using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY.Squares
{
    public enum TypeNeutral {VisitingJail,FreeAutoParking,StartSquare}
    class NeutralSquare: AbstractSquare
    {
        
        public NeutralSquare(int position) : base(position){}

        public override string InfoSquare()
        {
            if (POSITION == 0) return "you are in the beginning take your 200$, again?";
            else return "Great! a break in the Free auto parking is always good" ;
        }
    }
}
