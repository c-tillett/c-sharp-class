using System;
using System.Data;

public class Scripture
{
    private string _scripture;
    public Scripture()
    {
            _scripture = "Nevertheless I went forth, and as I came near unto the house of Laban I beheld a man, and he had fallen to the dearth before me, for he was drunken with wine.";
    }

    public string GetWholeScripture()
    {
        string scrip = _scripture;
        return scrip;
    }

    public string GetNewScripture(string verse)
    {
        string obama = verse;
        return obama;
    }

}