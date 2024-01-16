using System;
public class assignment_weektwo_one
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string temp = Console.ReadLine();
        int magicNum = int.Parse(temp);
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