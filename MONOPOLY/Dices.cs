using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    static public class Dices
    {
        public static String One = "+-----+\n|     |\n|  o  |\n|     |\n+-----+";
        public static String Two = "+-----+\n|o    |\n|     |\n|    o|\n+-----+";
        public static String Three = "+-----+\n|o    |\n|  o  |\n|    o|\n+-----+";
        public static String Four = "+-----+\n|o   o|\n|     |\n|o   o|\n+-----+";
        public static String Five = "+-----+\n|o   o|\n|  o  |\n|o   o|\n+-----+";
        public static String Six = "+-----+\n|o   o|\n|o   o|\n|o   o|\n+-----+";

        public static int[] RollDices()
        {
            Random rnd = new Random();
            int dice_1 = rnd.Next(1, 7);
            int dice_2 = rnd.Next(1, 7);
            int total = dice_1 + dice_2;
            int[] DICE = new int[2];
            DICE[0] = dice_1;
            DICE[1] = dice_2;

            return DICE;
        }



    }
}
