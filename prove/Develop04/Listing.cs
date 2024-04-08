class  Listing:Acitivity
{
    int counttype = 0;
    public List<string> prompts = new List<string>{
    "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?","When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };
    public Listing(){
        activityname = "Listing";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void doacitivity()
    {
        Random random = new Random();
        int ranums=random.Next(5);
        string prompt = prompts[ranums];
        Console.WriteLine($" --- {prompt} --- ");
        countdown();

        DateTime startTime = DateTime.Now;
        Console.WriteLine("You may begin writing");
        while(startTime.AddSeconds(timecount) > DateTime.Now) {
            Console.ReadLine();
            counttype+=1;
            }
        Console.WriteLine($"you have wrote {counttype} entry");
        
    }
    
}