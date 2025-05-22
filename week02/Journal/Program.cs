using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To The Journal Program");


        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString("dddd,dd,MMMM yyyy");
        entry.Display();
        Console.Write("Choose Your Number : ");
        string answer = Console.ReadLine();
        int ans = int.Parse(answer);

        Entry promp = new Entry();
        Console.WriteLine(promp._promptText )




        if (ans == 1)
        {
            Console.WriteLine("You have chosen to Write in your Journal");

        }

        else if (ans == 2)
        {
            Console.WriteLine("We are now viewing your latest entries");

        }
        else if (ans == 3)
        {
            Console.WriteLine(" loading Saved File...");

        }
        else if (ans == 4)
        {
            Console.WriteLine("Saving File to Journal");
        }
        else
        {
            Console.WriteLine("Thank You For Using Your Journal, Goodbye!");
        }


    }

}