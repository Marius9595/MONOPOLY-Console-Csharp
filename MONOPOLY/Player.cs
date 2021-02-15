using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class Player 
    {

        private PlayerScenes_States Player_scene;

        private string name; 
        private int actualPosition = 0; 
        private double currentMoney = 1500; 
        private bool inJail = false; 
        public List<IAbstractTitleDeed> properties = new List<IAbstractTitleDeed>(); 
        private bool get_out_of_jail_card = false; // REVISAR
        private bool loser = false; //REVISAR

        private ConsoleColor color;



        public ConsoleColor COLOR { get => color;}
        public string NAME { get => name;}
        public int ACTUALPOSITION { get => actualPosition; set => actualPosition=value ; }
        public double CURRENTMONEY { get => currentMoney; set => currentMoney = value; }
        public bool INJAIL { get => inJail; set => inJail = value; }
        public bool GetOut { get => get_out_of_jail_card; set => get_out_of_jail_card = value; }
        public bool Loser { get => loser; set => loser = value; }

        public Player(string Name, ConsoleColor color)
        {
            this.name = Name;
            this.color = color;
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

        

        

        private bool DoubleBool(int[] dices)
        {
            if (dices[0] == dices[1]) return true;

            else return false;

        }

        public void Move(int[] dices)
        {
            if (DoubleBool(dices))
            {
                int steps=0;

                for (int i = 0;  i< dices.Length; i++)
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



        public void SetScene(PlayerScenes_States playerScene)
        {
            this.Player_scene = playerScene;
            this.Player_scene.SetScene(this);
        }

        public void Display()
        {
            this.Player_scene.Draw(this);
        }
    }
}
