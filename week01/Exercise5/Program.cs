using System;

class Program
{
    static void Main(string[] args)
    // displaying welcome message
    {
        DisplayWelcomeMessage();


        string UserName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(UserName, squaredNumber);
    }



    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to The Program");
    }


    // creating a the username input functionD
    static string PromptUserName()
    {
        Console.Write("Please enter Username: ");
        string name = Console.ReadLine();
        return name;
    }
    // creating user Number input

    static int PromptUserNumber()
    {
        Console.Write("Please enter Your Preferred Number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
        
    }

    static int SquareNumber(int number)
    // calculating the Square
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    // displaying name given and square result
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}





