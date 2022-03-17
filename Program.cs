using System;
using System.Text.RegularExpressions;

namespace GuessTheNumber
{ 
    class program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            int winNum = n.Next(0, 50);
            bool win = false;
            
            Console.WriteLine("Do you want to play a game, Georgie?");
            Console.WriteLine("Yes or no? (Y/N");
           // do
          //  {
              //  string input = Console.ReadLine();
               // string pattern = ;
              //  Regex r = new Regex(@"^(Y|N){1}$", RegexOptions.IgnoreCase);
              //  if (r.IsMatch(input)) ;
                //input = Console.ReadLine();
              //  if (r.Match() == true) ;
                Console.WriteLine("Guess a number between zero and fifty");
            //} while (true);
            
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
                        Console.WriteLine("This is not a number");
                    }
                } while (!parseSucceeded);

                if (i > winNum)
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