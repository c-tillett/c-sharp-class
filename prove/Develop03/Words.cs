using System;
public class Word
{
    public string ScriptureBuilder(string verse)
    {
        List<int> blanks_index = new List<int>();
        List<int> readable_index = new List<int>();
        List<string> blanks = new List<string>();
        List<string> readable = new List<string>();
        List<string> old_verse = new List<string>(verse.Split(""));
        for(int i = 0; i<= old_verse.Count; i++)
        {
            if(old_verse[i].Contains("_"))
            {
                blanks_index.Add(old_verse.IndexOf(old_verse[i]));
            }
            else
            {
                readable_index.Add(old_verse.IndexOf(old_verse[i]));
            }
        }
        for(int i = 0; i <=3; i++)
        {
            if(readable.Count == 0)
            {   
                break;
            }
            else
            {
                Random random = new Random();
                int new_blank_index = random.Next(0, readable.Count);
                blanks_index.Add(new_blank_index);
                readable_index.Remove(new_blank_index);
            }
        }
        List<string> building_blocks = new List<string>();
        for(int n = 0; n <= old_verse.Count; n++)
        {
            if (blanks_index.Contains(n))
            {
                building_blocks.Add(blanks[n]);
            }
            else
            {
                building_blocks.Add(readable[n]);
            }
        }
        string new_verse = building_blocks.ToString();
        Console.WriteLine(new_verse);
        return new_verse;
    }
}