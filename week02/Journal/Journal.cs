public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {

        string filename = " Write.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            string Write = "My  text";
            outputFile.WriteLine(Write);
        }



    }
    public void DisplayAll()
    {

    }
    public void SafeToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {
        string filename = "Write.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string a = parts[0];
            string b = parts[1];
        }
    }
}