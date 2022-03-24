using System;
using System.Text.RegularExpressions;

namespace GuessTheNumber
{ 
    class program
    {
        private static bool input;
        
        static void Main(string[] args)
        {
            Random n = new Random();
            int winNum = n.Next(0, 50);
            bool win = false;
            

            Console.WriteLine("Do you want to play a game, Georgie?");
            Console.WriteLine("Yes or no? (Y/N");
            Console.WriteLine("Selecting N/n and pressing the enter key will end the game session" +
                "and you will have to start over.");
            do
            {
                string input = Console.ReadLine();

                Regex r = new Regex(@"^(Y|N){1}$", RegexOptions.IgnoreCase);

                if (!r.IsMatch(input))
                {
                    Console.WriteLine("You chose " + input + ", this is not an option Georgie!");
                }
                else if (input == "Y")
                {
                    Console.WriteLine("Let's play a game Georgie!!!");
                    goto AfterLoop;
                 }
                else if (input == "y")
                {
                    Console.WriteLine("Let's play a game Georgie!!!");
                    goto AfterLoop;
                }
                else if (input == "N")
                {
                    Console.WriteLine("Okay Georgie, see ya later!");
                    Environment.Exit(0);
                }
                else if (input == "n")
                {
                    Console.WriteLine("Okay Georgie, see ya later!");
                    Environment.Exit(0);
                }
            } while (input == false);

            
            AfterLoop:
            Console.WriteLine("Guess a number between 0 and 50, Georgie!");
            
            do
            {
               
                bool parseSucceeded = false;
                int i = 0;
                
                
                do
                {
                    string s = Console.ReadLine();
                    parseSucceeded = int.TryParse(s, out i);
                    if (!parseSucceeded)
                    {
                        Console.WriteLine("This is not a number, Georgie! Please try again");
                    }
                } while (!parseSucceeded);


                if (i > 50)
                {
                    Console.WriteLine("Georgie, you can only guess numbers between 0 and 50! You guessed "+i+"!" );
                }
                else if (i > winNum)
                {

                    Console.WriteLine("Sorry Georgie, your guess was too high! Guess again!");

                }
                else if (i < winNum)
                {

                    Console.WriteLine("Sorry Georgie, your guess was too low! Guess again!");

                }

                else if (i == winNum)
                {


                    Console.WriteLine("Great job, Georgie! Come join me in the sewer!");

                    win = true;

                }

            } while (win == false);
        }
    }
}