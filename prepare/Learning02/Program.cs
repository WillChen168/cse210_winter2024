using System;

class Program
{
    static void Main(string[] args)
    {   
        // Console.WriteLine("what your age?");
        // string age = Console.ReadLine();
        // int age_int = int.Parse(age);

        // Console.WriteLine(age_int+123);
        // int newage = age_int+123;

        // if (newage > 10){
        //     Console.WriteLine("Your are old");
        // }

        // Console.WriteLine("How much money you have?");
        // string money = Console.ReadLine();
        // int money_int = int.Parse(money);

        // Console.WriteLine("What the yeild for your stock?");

        // string yeild = Console.ReadLine();
        // int yeild_int = int.Parse(yeild);

        // Console.WriteLine("How many year you held that Stock?");

        // string years = Console.ReadLine();
        // int years_int = int.Parse(years);

        // for int newmoney = 

        // Console.WriteLine($"You have owned the stock for {years} year the yearly return for that stock is {yeild}%");
        // Console.WriteLine($"You earn Total of {totalmoney} in {years}");


        // if (money_int > 10000)
        // {
        //     Console.WriteLine("You are Rich!!!");
        // }
        // else
        // {
        //     Console.WriteLine("You are poor work gotta harder and smarter");
        // }
        // }


        Console.WriteLine("What is your grade?");
        string grade = Console.ReadLine();
        int grade_int = int.Parse(grade);


        string letter = "";

        if (grade_int >= 90){
                letter = "A";
            } 

        else if (grade_int >= 80){
            letter = "B";
        }

        else if (grade_int >=70){
            letter = "C";
        }
        
        else if (grade_int >=60){
            letter = "D";
        }
        else {
           letter = "F";
        }

        Console.WriteLine($"your grade is {letter}!!!!");



        if (grade_int >= 70){
            Console.WriteLine($"good job you passed !!!!");
        }

        else{
            Console.WriteLine("you failed try harder next time!");
        }
    }

        
    
}