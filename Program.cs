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
            Console.ReadLine();
        }
    }
}