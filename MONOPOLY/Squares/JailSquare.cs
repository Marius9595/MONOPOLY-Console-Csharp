using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY.Squares
{
    class JailSquare: AbstractSquare
    {      
        public JailSquare(int position) : base(position){}

        public override string InfoSquare()
        {
            if (POSITION == 10) return "Don`t worry, they are just a murders";

            else return "OHH! you have made a serious mistake, you have to go to jail";
        }
    }
}
