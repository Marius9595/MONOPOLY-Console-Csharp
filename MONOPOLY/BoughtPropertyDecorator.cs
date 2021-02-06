using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class BoughtPropertyDecorator: PropertyDecorator
    {

        public BoughtPropertyDecorator(PropertySquare prop, Player play) : base(prop, play)
        {
            this.taxes = prop.buying_cost / 2;
            this.situation = Property_Situation.Bought;
        }
    }
}
