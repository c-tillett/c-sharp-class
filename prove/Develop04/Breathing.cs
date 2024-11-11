using System;

public class Breathing : Activity
{
   public Breathing(int duration)
   {
        ActivityName = "Breathing Activity";
        ActivityDuration = duration;
        LoadingTime = 10;
        ActivityDescription = $"This activity is here to help you feel more grounded and calm\nby having you focus on your breathing.\nYou will be told when to breathe in and when to breathe out with pauses between each command\nIt will help if you try to keep your mind clear, and focus just on the air coming through your nostrils.";
   }
    private void InAndOut()
    {
        Console.Clear();
        Activity activity = new Activity();   
        DateTime end = DateTime.Now.AddSeconds(ActivityDuration);
        while (DateTime.Now < end)
        {
            Console.WriteLine("Breathe in...");
            activity.Loading(4);
            Console.WriteLine("Breathe Out...");
            activity.Loading(4);
        }
    }

    public void BreathingActivity()
    {
        Breathing activity = new Breathing(ActivityDuration);
        activity.WelcomeMessage();
        activity.InAndOut();
        activity.Exit();
    }
}
