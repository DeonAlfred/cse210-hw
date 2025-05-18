using System.Formats.Asn1;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine(_date);

        
    
        
        Console.WriteLine(_promptText);
        {

            Console.WriteLine("1.write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");


        }
    
        Console.WriteLine(_entryText);
        {
            string filename = " Write.txt";

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                
                string Write = "My  text";
                outputFile.WriteLine(Write);
            }
        }
    }

}

