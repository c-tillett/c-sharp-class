using System;

public class Reflection : Activity
{
    public Reflection(int duration)
    {
        ActivityName = "Reflection Activity";
        ActivityDuration = duration;
        LoadingTime = 6;
        ActivityDescription = "In this activity, you will be given a prompt to reflect on.\nPeriodically, additional follow-up reflection questions will appear to provide you with a deeper experience.";
    }
    private string BigPrompt()
    {
        Random random = new Random();
        List<string> prompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        int prompt_id = random.Next(prompts.Count());
        string prompt = prompts[prompt_id];
        return prompt;
    }
    private string SmallPrompt()
    {
        Random random = new Random();
        List<string> prompts = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?", "How did you feel when it was complete?", "What made this time diferent than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn form this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
        int prompt_id = random.Next(prompts.Count());
        string prompt = prompts[prompt_id];
        return prompt;
    }
    public void ReflectionActivity()
    {
        Reflection activity = new Reflection(ActivityDuration);
        activity.WelcomeMessage();
        string main_prompt = activity.BigPrompt();
        activity.Loading(5);
        Console.WriteLine(main_prompt);
        activity.Loading(10);
        Console.Clear();
        DateTime end = DateTime.Now.AddSeconds(ActivityDuration);
        while (DateTime.Now < end)
        {
            string sub_prompt = activity.SmallPrompt();
            Console.WriteLine(sub_prompt);
            activity.Loading(5);
            Console.Clear();
        }
        activity.Exit();
    }
}