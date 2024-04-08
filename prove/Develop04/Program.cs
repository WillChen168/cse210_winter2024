using System;

class Program
{
    static void Main(string[] args)
    {
        Acitivity acitivity = new Acitivity();
        
        Breath breath = new Breath();
        Reflection reflection = new Reflection();
        Listing listing = new Listing();
        string userinput = "jdgdj";
        while(userinput!="4"){
        Console.WriteLine("Menu Options:"); 
        Console.WriteLine("  1. Start breath activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.WriteLine("Select a choice from the menu");


       
        userinput = Console.ReadLine();



        if(userinput == "1"){
            breath.startactivity();
        }
       
        if(userinput =="2"){
            reflection.startactivity();    
        }

        if(userinput =="3"){
            listing.startactivity();    
        }
        
        
    }
}}