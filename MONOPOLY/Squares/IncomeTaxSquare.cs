using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class IncomeTaxSquare: AbstractSquare
    {
        private int tax = 200;

        public int TAX { get => this.tax ;}
        public IncomeTaxSquare(int position) : base(position) { }

        public override string InfoSquare()
        {
            return "I'm sorry but the bank has charged  you 200$ due to a special tax";
        }
    }
}
