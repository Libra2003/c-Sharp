using System;

namespace Gamechallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 7;
            int guessNum = 1;
            bool keepGoing = true;

            Console.WriteLine("Lets play guess the number!\nIam thinking of a number between 0 to 20");
            Console.WriteLine("Enter your guess, or -1 to give up!");
            int myguess ;
            do
            {
                Console.WriteLine("What is youtr guess?");
                string strGuess = Console.ReadLine();
                bool result = Int32.TryParse(strGuess, out myguess);
                if (!result)
                {
                    Console.WriteLine("Doesn't look like a number plz enter a number");
                }
         
                else
                {
                    if(myguess == -1)
                    {
                        Console.WriteLine($"well my guess was {guess}");
                        keepGoing = false;
                    }
                    else if (myguess < guess)
                    {
                        Console.WriteLine("Nope a higher Number");
                    }
                    else if (myguess > guess && myguess < 20)
                    {
                        Console.WriteLine("Nope a Lower Number");
                    }
                    else if (myguess > 20)
                    {
                        Console.WriteLine("Enter a number lower than 20");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations you have got the write number in {guessNum} attempts");
                        keepGoing = false;
                    }
                }
                guessNum++;
            } while (keepGoing);
        }
    }
}
