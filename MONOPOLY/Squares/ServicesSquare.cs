using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    public enum Type_Service { Train_Station, Service }

    class ServicesSquare : AbstractSquare, IAbstractTitleDeed
    {

        private string name;
        private double buying_cost;
        private double paymenttoOwner;
        private TitleDeedSituation situation;
        private double mortgageValue;
        private Player owner;

        public string NAME {get => name; }
        public double BUYING_COST => buying_cost;
        public double PAYTOOWNER => paymenttoOwner;
        public TitleDeedSituation SITUATION => situation;

        public double MORTGAGE_VALUE => mortgageValue;

        public ServicesSquare(string Name, double Buying_cost, double paymenttoOwner, int position) : base(position)
        {
            this.name = Name;
            this.buying_cost = Buying_cost;
            this.paymenttoOwner = paymenttoOwner;
            this.situation = TitleDeedSituation.Free;
        }

        public void AssignOwner() { }


        public string toString()
        {
            return "\tName: " + name + "\n\tBuying cost: $" + buying_cost + "\n\tTaxes: $" + paymenttoOwner +
                "\n\tSituation: " + situation.ToString();
        }

        public override string InfoSquare()
        {

            if (situation == TitleDeedSituation.Free) return $"You are in {name}, it is {situation} and costs {buying_cost}";
            else return $"you are in a station that belongs to {owner} and if you are not him, you have to pay him {paymenttoOwner}";

        }
    }

}