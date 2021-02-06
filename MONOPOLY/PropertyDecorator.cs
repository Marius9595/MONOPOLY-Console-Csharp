using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    abstract class PropertyDecorator:IAbstractProperty
    {
        protected IAbstractProperty AbstractProperty;
        public PropertyDecorator(IAbstractProperty IAbstractProperty, Player play)
        {
            this.AbstractProperty = (PropertySquare)IAbstractProperty;
            this.name = prop.name;
            this.buying_cost = prop.buying_cost;
            this.type = prop.type;
            this.owner = play;
            this.position = prop.position;
        }

        public string toStringOwner()
        {
            return "\tName: " + name + "\n\tType: " + type.ToString() + "\n\tBuying cost: $" + buying_cost + "\n\tTaxes: $" + taxes +
                "\n\tSituation: " + situation.ToString() + "\n\tOwner: " + owner.name;
        }
    }
        
    

}
    


