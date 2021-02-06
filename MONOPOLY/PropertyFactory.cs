using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class PropertyFactory:SquareFactory
    {
        public string name;
        public Type_Property type; // type of property
        public long buying_cost; // what the property costs if a player wants to buy it
        public long taxes; // what the players who do not own the property will have to pay the owner if they land on it
        public Property_Situation situation; // is the property free, bought, is there a house or a hotel on it? 
        public Player owner; // the owner of the property, if it has been bought
        public int position;

        public PropertyFactory(string Name, Type_Property Type, long Buying_cost, long Taxes, 
            Property_Situation Situation, Player Owner) {

            this.name = Name;
            this.type = Type;
            this.buying_cost = Buying_cost;
            this.taxes = Taxes;
            this.situation = Situation;
            this.owner = Owner;

        }
        public override AbstractSquare GetSquare( int position)
        {
            return new PropertySquare( name, type, buying_cost, taxes, situation, owner,position);
        }
    }
}
