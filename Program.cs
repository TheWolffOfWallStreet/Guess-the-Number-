namespace GuessTheNumber
{
    class program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(0, 50);
            bool win = false;
            Console.WriteLine("Guess a number between zero and fifty");
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
                    Console.WriteLine("The number you guessed is TOO DAMN HIGH! Guess again!");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("The number you guessed is TOO DAMN LOW! Guess again!");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("Yer a wizard, Harry!");
                    win = true;
                }
            } while (win == false);
        }
    }
}