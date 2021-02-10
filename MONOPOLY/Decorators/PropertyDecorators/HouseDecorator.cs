using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class HouseDecorator : PropertyDecorator
    {

        public HouseDecorator(IAbstractProperty AbstractProperty) : base(AbstractProperty) { }


        public void Hola()
        {

            Console.WriteLine("hola, tenog una casa");
        }
    }
}
