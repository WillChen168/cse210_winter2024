class  Breath:Acitivity
{
    public Breath(){
        activityname = "breathing";
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void doacitivity()
    {
        Console.WriteLine("Get Ready");
        doanimation();

        DateTime startTime = DateTime.Now;

        while(startTime.AddSeconds(timecount) > DateTime.Now) {
            Console.WriteLine("Breath in..");
            countdown();
            Console.WriteLine("Breath Out..");
            countdown();
        }




    }

    
}