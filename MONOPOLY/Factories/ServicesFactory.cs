using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class ServicesFactory: SquareFactory
    {
        public string name;
        public double buying_cost; 
        public double paymenttoOwner;  
        public int position;

        public ServicesFactory(string Name, long Buying_cost, long PaymenttoOwner)
        {
            this.name = Name;
            this.buying_cost = Buying_cost;
            this.paymenttoOwner = PaymenttoOwner;
        }
        public override AbstractSquare GetSquare(int position)
        {
            return new ServicesSquare(name, buying_cost, paymenttoOwner, position);
        }
    }
}
