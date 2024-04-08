class Acitivity{
    public string activityname;
    public string description;
    public int timecount;

    public void intro(){
        Console.WriteLine($"Welcome to the {activityname} activity. \n{description}.\nHow long, in seconds,would you like of your session?");
        timecount= int.Parse(Console.ReadLine());
        
    }

    public virtual void doacitivity(){

    }

    public void ending(){
        Console.WriteLine("Well done!!");
        doanimation();
        Console.WriteLine($"You have completed another {timecount} seconds of the {activityname} Acticity");
        doanimation();
        
    }

    protected void doanimation(){
        Console.Write(" ");
        for (int i = 0; i<3; i++){
            Console.Write("\b|");
            Console.Write("\b");
            

            Thread.Sleep(500);

            Console.Write("\b/");
            Console.Write("\b"); // Erase the + character

            Thread.Sleep(500);

            Console.Write("\b-");
            Console.Write("\b");

            Thread.Sleep(500);

            Console.Write("\b\\");
            Console.Write("\b"); // Replace it with the - character

            
        }
    }
    public void startactivity(){
        intro();
        doacitivity();
        ending();
    }
    public void countdown(){
        Console.Write(" ");
        for (int i = 4; i>0; i--){
            Console.Write($"{i}");
            Console.Write("\b");

            Thread.Sleep(1000);
        }
    }
}