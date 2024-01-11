using System;

public class assignment_weekone_one
{
    static void Main(string[] args)
    {   
        Console.Write("What is your first name? ");
        string fName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lName = Console.ReadLine();

        Console.WriteLine($"\nYour name is {lName}, {fName} {lName}");
    }
}