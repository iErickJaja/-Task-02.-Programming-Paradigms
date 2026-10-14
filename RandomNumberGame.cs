using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int playerRoll;
        int computerRoll;

        do
        {
            playerRoll = random.Next(1, 7);
            computerRoll = random.Next(1, 7);

            Console.WriteLine($"You rolled: {playerRoll}");
            Console.WriteLine($"Computer rolled: {computerRoll}");

            if (playerRoll == computerRoll)
            {
                Console.WriteLine("It's a tie! Re-rolling...\n");
            }
        }
        while (playerRoll == computerRoll);

        // Determine the winner
        if (playerRoll > computerRoll)
        {
            Console.WriteLine("\nYou win!");
        }
        else
        {
            Console.WriteLine("\nThe computer wins!");
        }
    }
}
