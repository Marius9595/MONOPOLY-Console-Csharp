using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
     abstract class PropertyDecorator:IAbstractProperty
    {
        public PropertyDecorator(IAbstractProperty IAbstractProperty)
        {
            
        }



        /*
        public string toStringOwner()
        {
            return "\tName: " + name + "\n\tType: " + type.ToString() + "\n\tBuying cost: $" + buying_cost + "\n\tTaxes: $" + taxes +
                "\n\tSituation: " + situation.ToString() + "\n\tOwner: " + owner.name;
        }
        */
    }
        
    

}
    


