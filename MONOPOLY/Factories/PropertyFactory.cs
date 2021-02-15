using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class PropertyFactory:SquareFactory
    {
        private string Name;
        private double Buying_cost;
        private double PaymenttoOwner;
        private double buldingCost;
        private double mortgageValue;
        private ConsoleColor color;

        public PropertyFactory() {

        }

        public  void  Re_AsignValuesFactory(string Name, double Buying_cost, double PaymenttoOwner, 
            double buldingCost, double mortgageValue, ConsoleColor color)
        {
            this.Name = Name;
            this.Buying_cost=Buying_cost;
            this.PaymenttoOwner=PaymenttoOwner;
            this.buldingCost = buldingCost;
            this.mortgageValue = mortgageValue;
            this.color = color;
        }

        public override AbstractSquare GetSquare(int position)
        {
            return new PropertySquare(Name, Buying_cost, PaymenttoOwner,buldingCost,mortgageValue,color, position);
        }
    }
}
