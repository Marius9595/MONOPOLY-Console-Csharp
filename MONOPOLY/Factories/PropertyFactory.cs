using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class PropertyFactory:SquareFactory
    {
        public string name;
        public double buying_cost; 
        public double paymenttoOwner; 

        public int position;

        public PropertyFactory(string Name, long Buying_cost, long PaymenttoOwner,
            TitleDeedSituation Situation, Player Owner) {

            this.name = Name;
            this.buying_cost = Buying_cost;
            this.paymenttoOwner = PaymenttoOwner;


        }
        public override AbstractSquare GetSquare( int position)
        {
            return new PropertySquare( name,buying_cost,paymenttoOwner,position);
        }
    }
}
