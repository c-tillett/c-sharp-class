using System;

public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public string GetStudentName()
    {
        string studentName = _studentName;
        return studentName;
    }

    public string GetTopic()
    {
        string topic = _topic;
        return topic;
    }
    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public void SetStudentName(string student_name)
    {
        _studentName = student_name;
    }
}