using System;
using System.Xml.Serialization;

public class Activity
{
    private int _activityDuration;
    private string _activityDescription;
    private string _activityName;
    private int _loadingTime;
    public Activity()
    {
    }
    public string ActivityName
    {
        get {return _activityName;}
        set {_activityName = value;}
    }
    public int ActivityDuration
    {
        get {return _activityDuration;}
        set {_activityDuration = value;}
    }
    public string ActivityDescription
    {
        get {return _activityDescription;}
        set {_activityDescription = value;}
    }
    public int LoadingTime
    {
        get {return _loadingTime;}
        set {_loadingTime = value;}
    }
    public void Loading(int LoadingTime)
    {
        List<string> animation = new List<string> { "-", "\\", "|", "/" };
        DateTime end = DateTime.Now.AddSeconds(LoadingTime);
        while (DateTime.Now < end)
        {
            for (int i = 0; i < animation.Count(); i++)
            {
                string s = animation[i];
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }
    public void WelcomeMessage()
    {
        Activity activity = new Activity();
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}!");
        Console.WriteLine(_activityDescription);
        activity.Loading(10);
    }
    public void Exit()
    {
        Activity activity = new Activity();
        Console.WriteLine($"Thank you for doing the {_activityName} for {_activityDuration} seconds. Please choose another activity.");
        activity.Loading(5);
    }
}