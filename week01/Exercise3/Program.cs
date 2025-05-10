using System;

class Program
{
  static void Main(string[] args)
  {
    Random randomGenerator = new Random();
    int selectedNumber = randomGenerator.Next(1, 100);

    int guess = -1;







    while (guess != selectedNumber)
    {
      Console.Write("What is your geuss?");

      guess = int.Parse(Console.ReadLine());





      if (selectedNumber > guess)
      {
        Console.WriteLine("Please guess Higher");
        
      }
      else if (selectedNumber < guess)
      {
        Console.WriteLine("Please guess Lower");
        
      }
      else
      {
        Console.WriteLine("Congratulations You guessed it!");
      }


    }

  }
}