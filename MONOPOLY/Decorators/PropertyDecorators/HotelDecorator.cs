using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class HotelDecorator : PropertyDecorator
    {

        public HotelDecorator(IAbstractProperty AbstractProperty) : base(AbstractProperty) { }
    }
}
