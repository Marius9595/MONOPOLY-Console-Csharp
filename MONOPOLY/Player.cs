using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    public class Player : Player_AbstractStrategy
    {

        private PlayerScenes_States Player_scene;

        private Player_AbstractStrategy Player_action;

        private string name; 
        private int actualPosition = 0; 
        private double currentMoney = 1500; 
        private bool inJail = false; 
        public List<IAbstractTitleDeed> properties = new List<IAbstractTitleDeed>(); 
        private bool get_out_of_jail_card = false; // REVISAR
        private bool loser = false; //REVISAR

        private int dices;
        private Boolean doublebool;
        private ConsoleColor color;

        public int DICES { get => dices; set => dices = value; }
        public Boolean DOUBLEBOOL { get => doublebool; set => doublebool= value; }


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

        
        public string toString()
        {
            int nb_prop = 0;
            if (properties != null)
            {
                nb_prop = properties.Count;
            }
            Console.WriteLine("Proprerties of : " + name);
            for (int i = 0; i < properties.Count; i++)
            {
                Console.WriteLine(properties[i].NAME);
            }
            return "Player: " + name + "\nPosition: " + actualPosition + "\nMoney: $" + currentMoney + "\nProperties: " + nb_prop;
        }
       




        public void DoubleBool(int[] dices)
        {
            if (doublebool)
            {
                if (dices[0] == dices[1]) inJail = true;

                else doublebool = false;
            }
            else
            {
                if (dices[0] == dices[1]) doublebool = true;
            }
        }



        public void MovePlayer()
        {
            int ControllerCount = 0;

           if (this.ACTUALPOSITION + this.dices >=40)
           {
                ControllerCount = 40 - this.ACTUALPOSITION + this.dices;

                this.ACTUALPOSITION = 0;

                this.CURRENTMONEY += 200;

                this.ACTUALPOSITION += ControllerCount;

           } else
           {
             this.ACTUALPOSITION += this.dices;
           }
                

            
        }


        public void SetScene(PlayerScenes_States playerScene)
        {
            this.Player_scene = playerScene;
            this.Player_scene.SetScene(this);
        }

        public void Display(Board board)
        {
            this.Player_scene.Draw(this, board);
        }

        public override void Action(Player player, Board board)
        {
            Player_action.Action(player,board);
        }

        public void SetStrategy (Player_AbstractStrategy Strategy)
        {
            this.Player_action = Strategy;
        }
    }
}
