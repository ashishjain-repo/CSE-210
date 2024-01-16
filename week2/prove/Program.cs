using System;
public class assignment_weektwo_one
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int magicNum = rnd.Next(101);
        Console.WriteLine(magicNum);
        bool loopVal = true;
        while(loopVal)
        {
            Console.Write("What is your guess? ");
            string tempGuess = Console.ReadLine();
            int guessNum = int.Parse(tempGuess);
            if(guessNum == magicNum)
            {
                loopVal = false;
                Console.WriteLine("You Guessed It!");
            }
            else if(guessNum < magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }

    }
}