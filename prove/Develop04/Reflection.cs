class  Reflection:Acitivity
{   
    public List<string> prompts = new List<string>{
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
    };

    public List<string> prompts2 = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "THow did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection(){
        activityname = "Reflection";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    

    public override void doacitivity()
    {
        Console.WriteLine("Get Ready");
        doanimation();
        Console.WriteLine("Consider the follow prompt");
        Random random = new Random();
        int ranums=random.Next(4);
        string prompt = prompts[ranums];
        Console.WriteLine($" --- {prompt} --- ");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.Write($"Now ponder on each of the following question as they related to this experince You may begin in:");
        countdown();


        


        DateTime startTime = DateTime.Now;
        Console.WriteLine();
        while(startTime.AddSeconds(timecount) > DateTime.Now) {
            ranums=random.Next(9);
            prompt = prompts2[ranums];
            Console.WriteLine($" --- {prompt} --- ");
            Thread.Sleep(8000);
        
        }


    

    }


}