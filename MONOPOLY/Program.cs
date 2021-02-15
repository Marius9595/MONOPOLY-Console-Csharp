using System;



namespace MONOPOLY
{
    class Program
    {
        static void Main(string[] args)
        {


            Game juego = new Game();

            juego.Create();

            /*
            Board board = new Board();

            Player Mario = new Player("mario", ConsoleColor.Red);

            Console.BackgroundColor = Mario.COLOR;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" {Mario.NAME.ToUpper()}               ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" {Mario.NAME.ToUpper()} is your turn  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" {Mario.NAME.ToUpper()}               ");
            config.init();
            Console.WriteLine(); 

            config.init();
            Console.WriteLine("\nPress any key to roll the dices!\n");
            Console.ReadKey(true);


            int[] Dados = Dices.RollDices();

            Mario.DisplayDices(Dados);
            */

























            /* COMO FUNCIONA EL MOVIMIENTO
            Board board = new Board();

            Player Mario = new Player("mario", ConsoleColor.Red);
            int num=40;

            int i = 1;

            while (num>0)
            {
                Console.WriteLine(board.board[Mario.ACTUALPOSITION].POSITION);


                Mario.ACTUALPOSITION += i;

                num -= 1;

                

                Console.ReadKey();

                
            } */


















            /*
            Player mario = new Player("Mario",ConsoleColor.Cyan);

            display(mario);

            void display(Player player) {

                string line = $"ES EL TURNO DE:{player.NAME}";

                Console.BackgroundColor = player.COLOR;
                for (int i = 0; i < line.Length; i++) Console.Write(" ");
                Console.Write("\n");
                Console.Write(line);
                Console.Write("\n");
                for (int i = 0; i < line.Length; i++) Console.Write(" ");





                Console.BackgroundColor = config.BACK_GROUND_COLOR;

                Console.WriteLine();
                Console.WriteLine("\nPlease Make a Selection :\n");
                Console.WriteLine("0 : Game Status");
                Console.WriteLine("1 : Finish Turn");
                Console.WriteLine("2 : Your DashBoard");
                Console.WriteLine("3 : Purchase the property");
                Console.WriteLine("4 : Buy House for property");
                Console.WriteLine("5 : Buy Hotel for property");
                Console.WriteLine("6 : Declare Bankrupt");
                Console.WriteLine("7 : Quit Game");
                Console.Write("(1-7)>");

            */




        }



            /*
            Scenes es = new Scenes(new GameOverSceneState());

            Player mario = new Player("mario", ConsoleColor.Red);
            Player[] jugador = new Player[1];

            jugador[0]=mario;

            Board board = new Board();

            es.Display(jugador, board);

        */
            

        
    }
}

