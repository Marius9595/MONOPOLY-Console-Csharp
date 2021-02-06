using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    public enum Type_Property { Train_Station, Service, Street }
    public enum Property_Situation { Free, Bought, House, Hotel }

    class PropertySquare : AbstractSquare,IAbstractProperty
    {
        public string name;
        public Type_Property type; // type of property
        public long buying_cost; // what the property costs if a player wants to buy it
        public long taxes; // what the players who do not own the property will have to pay the owner if they land on it
        public Property_Situation situation; // is the property free, bought, is there a house or a hotel on it? 
        public Player owner; // the owner of the property, if it has been bought
        public int position;

        public string Name { get => name; set => name = value; }
        public Type_Property Type { get => type; set => type = value; }
        public long Buying_cost { get => buying_cost; set => buying_cost = value; }
        public long Taxes { get => taxes; set => taxes = value; }
        public Property_Situation Situation { get => situation; set => situation = value; }
        public Player Owner { get => owner; set => owner = value; }

        public PropertySquare(string Name, Type_Property Type, long Buying_cost, long Taxes, Property_Situation Situation, Player Owner, int position) : base(position)
        {
            this.name = Name;
            this.type = Type;
            this.buying_cost = Buying_cost;
            this.taxes = Taxes;
            this.situation = Situation;
            this.owner = Owner;
            this.position = position;

        }

        public PropertySquare() { }

        public string toString()
        {
            return "\tName: " + name + "\n\tType: " + type.ToString() + "\n\tBuying cost: $" + buying_cost + "\n\tTaxes: $" + taxes +
                "\n\tSituation: " + situation.ToString();
        }
    }





    class BoughtProperty : PropertyDecorator
    {

        public BoughtProperty(Property prop, Player play) : base(prop, play)
        {
            this.taxes = prop.buying_cost / 2;
            this.situation = Property_Situation.Bought;
        }
    }

    class HouseProperty : BoughtProperty
    {
        public HouseProperty(BoughtProperty prop, Player play) : base(prop, play)
        {
            this.taxes = prop.taxes * 2;
            this.situation = Property_Situation.House;
        }
    }

    class HotelProperty : HouseProperty
    {
        public HotelProperty(HouseProperty prop, Player play) : base(prop, play)
        {
            this.taxes = prop.taxes * 2;
            this.situation = Property_Situation.Hotel;
        }
    }
}
