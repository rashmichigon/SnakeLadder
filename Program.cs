namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulation");

            //UC1

            int position = 0;
            Console.WriteLine("Initial (start) position is:" + position);

            //UC2

            Random random = new Random();
            int diceOutput = random.Next(1, 7);
            Console.WriteLine("Dice Output is :" + diceOutput);

            //UC3

            position = diceOutput;
            Console.WriteLine("Position :", position);
            Random random2 = new Random();
            Console.WriteLine("Checking for Options");
            int option = random2.Next(1, 4);
            switch (option)
            {
                case 1:
                    Console.WriteLine("No Play");
                    position = position;
                    Console.WriteLine("Position :" + position);
                    break;
                case 2:
                    Console.WriteLine("Ladder");
                    position = diceOutput;
                    Console.WriteLine("Position :" + position);
                    break;
                case 3:
                    Console.WriteLine("Snake");
                    position = diceOutput;
                    Console.WriteLine("Position :" + position);
                    break;
            }
            Console.ReadLine();
        }
    }
}