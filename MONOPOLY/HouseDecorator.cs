using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class HouseDecorator : PropertyDecorator
    {

        public HouseDecorator(IAbstractProperty AbstractProperty,Player play) : base(AbstractProperty, play) { }
    }
}
