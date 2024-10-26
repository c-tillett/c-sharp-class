using System;
using System.Runtime.InteropServices;
using System.Threading.Channels;


class Program
{
    static void Main(string[] args)
    {
        Reference builder = new Reference("Nephi", "4", "7");
        string reference = builder.OneVerseReference();
        Scripture scripture = new Scripture();
        string verse = scripture.GetWholeScripture();
        string import_verse = verse;
        
        

        Console.WriteLine($"{reference} -\n{scripture}");

        while (!import_verse.Any(char.IsLetter))
        {
            Console.WriteLine($"{reference} -\n{import_verse}\n");
            string input = Console.ReadLine();
            if (input != "")
            {
                Word word = new Word();
                string with_blanks = word.ScriptureBuilder(import_verse);
                import_verse = with_blanks;
            }
            else
            {
                System.Environment.Exit(0);
            }
        }
        

        

    }
    
}