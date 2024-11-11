using System;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public void SetTextbookSection(string textbook_section)
    {
        _textbookSection = textbook_section;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public string GetTextbookSection()
    {
        string textbook_section = _textbookSection;
        return textbook_section;
    }
    public string GetProblems()
    {
        string problems = _problems;
        return problems;
    }
}