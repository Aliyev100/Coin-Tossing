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

public class CoinToss
{


    public static void Main(string[] args)
    {

        // initialize variables in declarations
        CoinTossing TossCoin = new CoinTossing();
        
        TossCoin.CoinTossCalculate();

    } // end Main


} // end class CoinToss
