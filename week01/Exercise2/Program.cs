using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade percentage");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        int remainder = (percent / 10);
        
        
        

        string letter = "";
        string ic = remainder.ToString();
        string ik = ic;

        if (percent >= 90)
        {
            Console.Write("A");
        }
        else if (percent >= 80)
        {
            Console.Write("B");
        }
        else if (percent >= 70)
        {
            Console.Write("C");
        }
        else if (percent >= 60)

        {
            Console.Write("D");
        }
        else
        {
            Console.Write("F");
        }

        if (remainder >= 7)
        {
            Console.Write("+");
        }

        else
        {
            Console.Write("-");
        }
        Console.WriteLine($" {letter}{ik} is Your Grade letter");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations!, You passed");

        }
        else
        {
            Console.WriteLine("Better luck next time");
        }




    }
}
