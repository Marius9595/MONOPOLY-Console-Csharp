using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{


    enum ColorProperty
    {
        BROWN,BLUE,PINK,ORANGE,RED,YELLOW,GREEN,PURPLE
    }

    class PropertySquare : AbstractSquare, IAbstractProperty, IAbstractTitleDeed
    {
        private string name;
        private double buying_cost;
        private double paymenttoOwner;
        private double mortgageValue;
        private  double buldingCost;
        private TitleDeedSituation situation;
        private Player owner;
        private ColorProperty color;


        public string NAME => name;
        public ColorProperty COLOR_PROPERTY { get => color; }
        public double MORTGAGE_VALUE { get => mortgageValue;}
        public double BULDING_COST { get => buldingCost; }
        public double BUYING_COST => buying_cost;
        public double PAYTOOWNER => paymenttoOwner;
        public TitleDeedSituation SITUATION => situation;

        

        public PropertySquare(string Name, double Buying_cost,
            double paymenttoOwner, double buldingCost, 
            double mortgageValue, ColorProperty color , int position) : base(position)
        {
            this.name = Name;
            this.buying_cost = Buying_cost;
            this.paymenttoOwner = paymenttoOwner;
            this.situation = TitleDeedSituation.Free;
            this.buldingCost = buldingCost;
            this.mortgageValue = mortgageValue;
            this.color = color;
        }

        


        public void AssignOwner(Player NewOwner)
        {
            this.owner = NewOwner;
        }

        public string toString()
        {
            return "\tName: " + name + "\n\tBuying cost: $" + buying_cost + "\n\tTaxes: $" + paymenttoOwner +
                "\n\tSituation: " + situation.ToString();
        }

        public override string InfoSquare()
        {
            if (owner != null) return $"You are in {name}, it is {situation} and costs {buying_cost}";
            else return $"you are in a property that belongs to {owner} and if you are not him, you have to pay him {paymenttoOwner}";
        }
    }

}
