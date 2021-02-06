using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    
    

    class PropertySquare : AbstractSquare,IAbstractProperty,IAbstractTitleDeed
    {
        private string name;
        private double buying_cost; 
        private double paymenttoOwner; 
        private TitleDeedSituation situation; 


        public string NAME => name;
        public double BUYING_COST => buying_cost;
        public double PAYTOOWNER => paymenttoOwner;
        public TitleDeedSituation SITUATION => situation;

        public PropertySquare(string Name, double Buying_cost, double paymenttoOwner, int position) : base(position)
        {
            this.name = Name;
            this.buying_cost = Buying_cost;
            this.paymenttoOwner = paymenttoOwner;
            this.situation = TitleDeedSituation.Free;
        }

        public PropertySquare() { }


        public void AssignOwner()
        {
        }

        public string toString()
        {
            return "\tName: " + name + "\n\tBuying cost: $" + buying_cost + "\n\tTaxes: $" + paymenttoOwner +
                "\n\tSituation: " + situation.ToString();
        }
    }

}
