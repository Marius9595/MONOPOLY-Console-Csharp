using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class Player
    {

        private string name; 
        private int actualPosition = 0; 
        private double currentMoney = 1500; 
        private bool inJail = false; 
        public List<PropertySquare> properties = new List<PropertySquare>(); 
        private bool get_out_of_jail_card = false; // REVISAR
        private bool loser = false; //REVISAR

        public string NAME { get => name;}
        public int ACTUALPOSITION { get => actualPosition; set => actualPosition = actualPosition + value; }
        public double CURRENTMONEY { get => currentMoney; set => currentMoney = currentMoney+ value; }
        public bool INJAIL { get => inJail; set => inJail = value; }
        public bool GetOut { get => get_out_of_jail_card; set => get_out_of_jail_card = value; }
        public bool Loser { get => loser; set => loser = value; }

        public Player(string Name)
        {
            this.name = Name;
        }

        /*
        public string toString()
        {
            int nb_prop = 0;
            if (properties != null)
            {
                nb_prop = properties.Count();
            }
            Console.WriteLine("Proprerties of : " + name);
            for (int i = 0; i < properties.Count; i++)
            {
                Console.WriteLine(properties[i].toString());
            }
            return "Player: " + name + "\nPosition: " + position + "\nMoney: $" + money + "\nProperties: " + nb_prop;
        }
        */

        private int[] RollDices()
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

        private bool DoubleBool(int[] dice)
        {
            if (dice[0] == dice[1]) return true;

            else return false;
           
        }

        public void Move()
        {
            if (DoubleBool(RollDices()))
            {
                int steps=0;

                for (int i = 0;  i< RollDices().Length; i++)
                {

                }

                ACTUALPOSITION = 5;
            }
            else
            {
                actualPosition = actualPosition - 40;
                currentMoney += 200;
            }
        }


    }
}
