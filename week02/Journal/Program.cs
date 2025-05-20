using System;
using System.Collections.Generic;
using System.Net.Quic;

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
        Entry entry2 = new Entry();
        entry2._promptText =  "hello";
        entry2.Display();

    



        if (ans == 1)
        {
            Console.WriteLine("You have chosen to Write in your Journal");
            Console.WriteLine(_entryText);


        }
        else if (ans == 2)
        {
            Console.WriteLine("We are now viewing your latest entries");
            Console.WriteLine(entry2);
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