using System.Numerics;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FirstPosition = 0;
            const int SecondPosition = 0;
            int position1 = 0;
            int position2 = 0;
            int DiceRoll1, DiceRoll2;
            int count = 0;
            Console.WriteLine("Player 1 is starting with position" + FirstPosition);
            Console.WriteLine("Player 2 is starting with position" + SecondPosition);
            while (position1 < 100 || position2 < 100)
            {
                count++;
                Random random1 = new Random();
                DiceRoll1 = random1.Next(1, 7);
                Random random2 = new Random();
                DiceRoll2 = random2.Next(1, 7);
                Console.WriteLine("The number player 1 got through dice is" + DiceRoll1);
                Console.WriteLine("The number player 2 got through dice is" + DiceRoll2);
                Random random3 = new Random();
                int play1 = random3.Next(1, 4);
                Random random4 = new Random();
                int play2 = random4.Next(1, 4);
                if (play1 == 1)
                {
                    Console.WriteLine("Player 1 got no play");
                    DiceRoll1 = 0;
                    position1 = position1 + DiceRoll1;
                }
                else if (play1 == 2)
                {
                    Console.WriteLine("Player1 got ladder");
                    position1 = (position1 - DiceRoll1);
                }
                else
                {
                    Console.WriteLine("Player1 got snake");
                    position1 = (position1 - DiceRoll1);
                    if (position1 < 0)
                    {
                        position1 = FirstPosition;
                    }
                }
                if (position1 > 100)
                {
                    position1 = position1 - DiceRoll1;
                }
            }

        }
    }
}
