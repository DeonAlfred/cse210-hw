using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> Numbers = new List<int>();
        int userNumber = -1;



        // creating user input and retrieving userinput 

        while (userNumber != 0)
        {
            Console.Write("Enter a number(0 to quit):");

            // converting userinput to int

            string userReponse = Console.ReadLine();
            userNumber = int.Parse(userReponse);

            if (userNumber != 0)
            {

                Numbers.Add(userNumber);
            }

            // First requirement:  computing the sum
            int sum = 0;
            foreach (int number in Numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is {sum}");

            //Second requirement: computing the average
            float average = ((float)sum) / Numbers.Count();
            Console.WriteLine($"The average is {average}");


            //Third requirement:calculating the max value
            int max = Numbers[0];
            foreach (int number in Numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The max number is {max}");



            // calculating the minimum

            int min = Numbers.Min();

            Console.WriteLine($"The minimum is {min}");


            // sorting list when user quits
            Numbers.Sort();

            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }
        }








    }
}

