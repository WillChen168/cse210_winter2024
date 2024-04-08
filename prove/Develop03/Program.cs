using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", "3:5", "And God said let there be light");
        Scripture scripture = new Scripture(reference);
        string Userinput;
        while (true){
            scripture.display();
            Console.WriteLine("Press Enter to contine or type 'quit' to finish");
            Userinput = Console.ReadLine(); 
            scripture.hiderandomword();
            scripture.hiderandomword();
            scripture.hiderandomword();

            if (Userinput == "quit"||scripture.nums.Count==0){
                return;
            }

            

            

        }

        scripture.display();
        
        Console.WriteLine($"\nEnd");
    }
}