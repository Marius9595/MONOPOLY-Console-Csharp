using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class Board
    {

        private static Board instance = null;
        public AbstractSquare[] board = new AbstractSquare[40];
        private static readonly object padlock = new object();

        public Board()
        {
            CreateBoard();
        }

        public static Board Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Board();
                    }
                    return instance;
                }
            }
        }


        public void CreateBoard()
        {
            //Instances of Factories of diferent types of squares
            
            CardFactory ChanceCardFactory = new CardFactory(TypeofCard.Chance);
            CardFactory CommunityCardFactory = new CardFactory(TypeofCard.Community);

            Factories.JailFactory JailFactory = new Factories.JailFactory();
            Factories.NeutralFactory neutralFactory = new Factories.NeutralFactory();

            PropertyFactory propertyFactory = new PropertyFactory();

            Factories.IncomeTaxFactory incomeTaxFactory = new Factories.IncomeTaxFactory();

            ServicesFactory servicesFactory = new ServicesFactory();


            //bulding board

            board[0] = neutralFactory.GetSquare(0);
            propertyFactory.Re_AsignValuesFactory("Mediterranean Avenue",60,2,50,30,ColorProperty.BROWN);
            board[1] = propertyFactory.GetSquare(1);
            board[2] = CommunityCardFactory.GetSquare(2);
            propertyFactory.Re_AsignValuesFactory("Baltic Avenue",60,4,50,30,ColorProperty.BROWN);
            board[3] = propertyFactory.GetSquare(3);
            board[4] = incomeTaxFactory.GetSquare(4);
            servicesFactory.re_AsignValues("Reading Railroad", 200, 75);
            board[5] = servicesFactory.GetSquare(5);
            propertyFactory.Re_AsignValuesFactory("Oriental Avenue",100,6,50,50,ColorProperty.BLUE);
            board[6] = propertyFactory.GetSquare(6);
            board[7] = ChanceCardFactory.GetSquare(7);
            propertyFactory.Re_AsignValuesFactory("Vermont Avenue",100,6,50,20,ColorProperty.BLUE);
            board[8] = propertyFactory.GetSquare(8);
            propertyFactory.Re_AsignValuesFactory("Connecticut Avenue", 120, 8, 50, 60,ColorProperty.BLUE);
            board[9] = propertyFactory.GetSquare(9);
            board[10] = JailFactory.GetSquare(10);
            propertyFactory.Re_AsignValuesFactory("St. Charles Place", 140, 10, 100, 70,ColorProperty.PINK);
            board[11] = propertyFactory.GetSquare(11);
            servicesFactory.re_AsignValues("Electric Company", 150, 20);
            board[12] = servicesFactory.GetSquare(12);
            propertyFactory.Re_AsignValuesFactory("States Avenue", 140, 10, 100, 70,ColorProperty.PINK);
            board[13] = propertyFactory.GetSquare(13);
            





        }

    }
}
}
