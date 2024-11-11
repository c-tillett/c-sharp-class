using System;

public class Listing : Activity
{
    public Listing(int duration)
   {
        ActivityName = "Listing Activity";
        ActivityDuration = duration;
        LoadingTime = 10;
        ActivityDescription = $"In this activity, you will be given a prompt, and then will be given time to make a list pertaining to that prompt.\nJust type in what you would like to add, and then press enter.\nAt the end of the activity, you'll be able to read your list.";
   }
   private string Prompt()
    {
        Random random = new Random();
        List<string> prompts = new List<string>{"Who are people that you appriciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        int prompt_id = random.Next(prompts.Count());
        string prompt = prompts[prompt_id];
        return prompt;
    }
    
    public void ListingActivity()
    {
        Listing activity = new Listing(ActivityDuration);
        activity.WelcomeMessage();
        string prompt = activity.Prompt();
        Console.WriteLine(prompt);
        activity.Loading(8);
        List<string> user_input = new List<string>{}; 
        DateTime end = DateTime.Now.AddSeconds(ActivityDuration);
        while (DateTime.Now < end)
        {
            Console.WriteLine("Please write something and press enter to add it to your list.\n");
            string input = Console.ReadLine();
            user_input.Add(input);
            Console.Clear();
        }
        Console.WriteLine($"The prompt for this activity was:\n{prompt}");
        activity.Loading(3);
        Console.WriteLine("This was your list:");
        for (int i = 0; i < user_input.Count(); i++)
        {
            string item = user_input[i];
            Console.WriteLine(item);
            activity.Loading(1);
        }
        Console.WriteLine("Please take some time to read your list. Press Enter to continue");
        Console.ReadLine();
        activity.Exit();
    }
}