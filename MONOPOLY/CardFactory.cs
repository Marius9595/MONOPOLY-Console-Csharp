using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class CardFactory : SquareFactory
    {
        private TypeofCard typeOfCard; 

        public CardFactory(TypeofCard typeOfCard)
        {
            this.typeOfCard = typeOfCard;
        }
        public override AbstractSquare GetSquare(int position)
        {
            return new CardSquare(position, typeOfCard);
        }
    }
}

