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
            propertyFactory.Re_AsignValuesFactory("Virginia Avenue", 160, 12, 100, 80, ColorProperty.PINK);
            board[14] = propertyFactory.GetSquare(14);
            servicesFactory.re_AsignValues("Pennsylvania Railroad", 200, 25);
            board[15] = servicesFactory.GetSquare(15);
            propertyFactory.Re_AsignValuesFactory("St. James Place", 180, 14, 100, 90, ColorProperty.ORANGE);
            board[16] = propertyFactory.GetSquare(16);
            board[17] = CommunityCardFactory.GetSquare(17);
            propertyFactory.Re_AsignValuesFactory("Tennessee Avenue", 180, 14, 100, 90, ColorProperty.ORANGE);
            board[18] = propertyFactory.GetSquare(18);
            propertyFactory.Re_AsignValuesFactory("New York Avenue", 200, 16, 100, 100, ColorProperty.ORANGE);
            board[19] = propertyFactory.GetSquare(19);
            board[20] = neutralFactory.GetSquare(20);
            propertyFactory.Re_AsignValuesFactory("Kentucky Avenue", 220, 18, 150, 110, ColorProperty.RED);
            board[21] = propertyFactory.GetSquare(21);
            board[22] = ChanceCardFactory.GetSquare(22);
            propertyFactory.Re_AsignValuesFactory("Indiana Avenue", 220, 18, 150, 110, ColorProperty.RED);
            board[23] = propertyFactory.GetSquare(23);
            propertyFactory.Re_AsignValuesFactory("Illinois Avenue", 240, 20, 150, 120, ColorProperty.RED);
            board[24] = propertyFactory.GetSquare(24);
            servicesFactory.re_AsignValues("B. & O. Railroad", 200, 25);
            board[25] = servicesFactory.GetSquare(25);
            propertyFactory.Re_AsignValuesFactory("Atlantic Avenue", 260, 22, 150, 130, ColorProperty.YELLOW);
            board[26] = propertyFactory.GetSquare(26);
            propertyFactory.Re_AsignValuesFactory("Ventnor Avenue", 260, 22, 150, 130, ColorProperty.YELLOW);
            board[27] = propertyFactory.GetSquare(27);
            servicesFactory.re_AsignValues("Water Works", 150, 4);
            board[28] = servicesFactory.GetSquare(28);
            propertyFactory.Re_AsignValuesFactory("Marvin Gardens", 280, 24, 150, 140, ColorProperty.YELLOW);
            board[29] = propertyFactory.GetSquare(29);
            board[30] = JailFactory.GetSquare(30);
            propertyFactory.Re_AsignValuesFactory("Pacific Avenue", 300, 26, 200, 150, ColorProperty.GREEN);
            board[31] = propertyFactory.GetSquare(31);
            propertyFactory.Re_AsignValuesFactory("North Carolina Avenue", 300, 26, 200, 150, ColorProperty.GREEN);
            board[32] = propertyFactory.GetSquare(32);
            board[33] = CommunityCardFactory.GetSquare(33);
            propertyFactory.Re_AsignValuesFactory("Pennsylvania Avenue", 320, 28, 200, 160, ColorProperty.GREEN);
            board[34] = propertyFactory.GetSquare(34);
            servicesFactory.re_AsignValues("Short Line", 200, 25);
            board[35] = propertyFactory.GetSquare(35);
            board[36] = ChanceCardFactory.GetSquare(36);
            propertyFactory.Re_AsignValuesFactory("Park Place", 350, 35, 200, 175, ColorProperty.PURPLE);
            board[37] = propertyFactory.GetSquare(37);
            board[38] = neutralFactory.GetSquare(38);
            propertyFactory.Re_AsignValuesFactory("Boardwalk", 400, 50, 200, 200, ColorProperty.PURPLE);
            board[39] = propertyFactory.GetSquare(39);



            //mirar decorador
            //mirar mortagage de servicios





            





        }

    }
}

