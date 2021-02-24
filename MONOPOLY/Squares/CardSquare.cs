using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{

    public enum TypeofCard { Community, Chance }

    public enum Chances
    {
        GetoutfromJail = 1, PaytoPlayer, Paytaxes,
        ReceivefromBank, MoveForward, MoveBackward,
        GotoJail, TakeOther
    }
    public enum Community
    {
        GetoutfromJail = 1, PaytoPlayer, Paytaxes,
        ReceivefromBank, MoveForward, MoveBackward,
        GotoJail, TakeOther
    }

    class CardSquare : AbstractSquare
    {
        private int content;                                                   
        private int rand_steps;
        private int rand_cash;
        public TypeofCard typeofCard;

        


        public int RAND_STEPS { get => rand_steps;}
        public int CONTENT { get => content;}
        public int RAND_CASH { get => rand_cash;}
       


        public CardSquare(int position,TypeofCard typeofCard) : base(position)
        {
            this.content = randomCard();
            this.rand_cash = RandomCash();
            this.rand_steps = RandomSteps();
            this.typeofCard = typeofCard;
        }


        private int randomCard()
        {
            Random rnd = new Random();
            int card = rnd.Next(1, 8);
            return card;
        }

        private int RandomSteps()
        {
            Random rnd = new Random();
            int steps = rnd.Next(1, 8);
            return steps;
        }

        public int RandomCash()
        {
            Random rnd = new Random();
            int cash = rnd.Next(10, 150);
            return cash;
        }



        public string GetContent()
        {
            switch (this.typeofCard)
            {
                case TypeofCard.Chance:

                    if (this.content == (int)Chances.GetoutfromJail) { return "Get out of jail"; }
                    else if (this.content == (int)Chances.Paytaxes) { return "Pay $" + this.rand_cash + " for taxes"; }
                    else if (this.content == (int)Chances.ReceivefromBank) { return "Receive $" + this.rand_cash + " from the bank"; }
                    else if (this.content == (int)Chances.MoveForward) { return "Move " + this.rand_steps + " squares forward"; }
                    else if (this.content == (int)Chances.MoveBackward) { return "Move " + this.rand_steps + " squares backward"; }
                    else if (this.content == (int)Chances.GotoJail) { return "Go to jail"; }
                    else { return "Oh!, You have to take other card"; }

                case TypeofCard.Community:

                    if (this.content == (int)Community.GetoutfromJail) { return "Get out of jail"; }
                    else if (this.content == (int)Community.Paytaxes) { return "Pay " + $"{this.rand_cash} for taxes"; }
                    else if (this.content == (int)Community.ReceivefromBank) { return "Receive $" + this.rand_cash + " from the bank"; }
                    else if (this.content == (int)Community.MoveForward) { return "Move " + this.rand_steps + " squares forward"; }
                    else if (this.content == (int)Community.MoveBackward) { return "Move " + this.rand_steps + " squares backward"; }
                    else if (this.content == (int)Community.GotoJail) { return "Go to jail"; }
                    else { return "Oh!, You have to take other card"; }

                default:

                    return "THERE IS A BIG PROBLEM";
                    break;

            }

        }

        public void MoveForward(Player player) => player.ACTUALPOSITION += rand_steps;
        public void MoveBackward(Player player) => player.ACTUALPOSITION -= rand_steps;
        public void Paytaxes(Player player) => player.CURRENTMONEY -= rand_cash;
        public void ReceivefromBank(Player player) => player.CURRENTMONEY += rand_cash;
        public void GotoJail(Player player) => player.INJAIL = true;
        public void GetoutfromJail(Player player) => player.INJAIL = false;




        public override string InfoSquare()
        {
            return $"You are on special square, you have to take one {typeofCard} card, GOOD LUCK!";
        }
    }
}
