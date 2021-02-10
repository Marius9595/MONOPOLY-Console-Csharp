using System;

namespace MONOPOLY
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Mairo = new Player("mario");
            PropertyFactory Avenida1 = new PropertyFactory("sef", 250, 231, TitleDeedSituation.Free, Mairo);

            var avenida =Avenida1.GetSquare(1);

            HouseDecorator PropiedadconCasa = new HouseDecorator((PropertySquare)avenida);

            (PropertySquare)avenida = PropiedadconCasa;





        }
    }
}
