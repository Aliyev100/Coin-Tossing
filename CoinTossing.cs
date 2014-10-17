// Problem 7.29 on page 328
// Write an application that simulates coin tossing.  
// Let the application toss a coin each time the user 
// chooses the “Toss Coin” menu option.  Count the 
// number of times each side of the coin appears.  
// Display the results.  The application should call 
// a separate method Flip that takes no arguments and 
// returns false for tails and true for heads.  
// [Note:  If the application realistically simulates 
// coin tossing, each side of the coin should appear 
// approximately half the time.]

using System;

public class CoinTossing
{

        // initialize variables in declarations
        int result;
        Random randomNumbers; // random number generator
        const int NUMBER_OF_SIDES = 2; // constant number of Card
        string[] coinfaces = { "Heads", "Tails" };
    

        public void CoinTossCalculate() 
        {
        int coinHead = 0;
        int coinTails = 0;
        randomNumbers = new Random(); // create random number generator

        // prompt user for input to toss coin or not
        Console.Write("Toss coin? (1 = yes, 2 = no): ");
        result = Convert.ToInt32(Console.ReadLine());

        // if...else nested in while 
        while (result == 1) // if result 1,
        {
            int second = randomNumbers.Next(NUMBER_OF_SIDES);
            if (second == 1)
            {
                Console.WriteLine("HEADS it is!\n");
                coinHead += 1;
                Console.WriteLine("Heads\ttotal count: {0}", coinHead);
                Console.WriteLine("Tails\ttotal count: {0}", coinTails);
            }
            else
            {
                Console.WriteLine("TAILS it is!\n");
                coinTails += 1;
                Console.WriteLine("Heads\ttotal count: {0}", coinHead);
                Console.WriteLine("Tails\ttotal count: {0}", coinTails);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Toss coin? (1 = yess, 2 = no): ");
            result = Convert.ToInt32(Console.ReadLine());
        }

        // result is not 1, so
        Console.WriteLine("Game Over!");

        } //end of CoinTossCalculate
    

} // end class CoinTossing
