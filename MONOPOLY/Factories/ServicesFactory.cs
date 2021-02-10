using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class ServicesFactory: SquareFactory
    {
        private string name;
        private double buying_cost; 
        private double paymenttoOwner;  


        public ServicesFactory() {  }

        public void re_AsignValues(string Name, double Buying_cost, double PaymenttoOwner)
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
