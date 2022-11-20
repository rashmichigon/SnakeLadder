﻿namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FirstPosition = 0;
            int position = 0;
            int DiceRoll;
            Console.WriteLine("First player is starting with position " + FirstPosition);
            while (position < 100)
            {
                Random random = new Random();
                DiceRoll = random.Next(1, 7);
                Console.WriteLine("The number player got through dice is" + DiceRoll);
                Random random2 = new Random();
                int play = random2.Next(1, 4);
                if (play == 1)
                {
                    Console.WriteLine("Player got no play");
                    DiceRoll = 0;
                    position = position + DiceRoll;
                }
                else if (play == 2)
                {
                    Console.WriteLine("Player got ladder");
                    position = (position + DiceRoll);
                }
                else
                {
                    Console.WriteLine("Player got snake");
                    position = (position - DiceRoll);
                    if (position < 0)
                    {
                        position = FirstPosition;
                    }
                    if (position > 100)
                    {
                        position = position - DiceRoll;
                    }
                    Console.WriteLine("The Player position is: " + position);
                }
                Console.ReadLine();
            }

        }
    }
}
