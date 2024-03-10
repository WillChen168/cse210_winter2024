///Author : Will Chen
///Assignment: Week 02 journal 
/// date: 23/2/2023



using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        string userinput = "jdgdj";
        while(userinput!="5"){
        Console.WriteLine("Welcome to Journal Program!"); 
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.WriteLine("What would you like to do?");

       
        userinput = Console.ReadLine();



        if(userinput == "1"){
            journal.getEntry();
        }

        if (userinput == "2"){
            journal.display();
        }

        if (userinput == "3"){
            journal.Load();
        }

        if (userinput == "4"){
            journal.Save();
        }
    }
}}


// streamwriter is for saving file txt
//System.IO.File.ReadAllLines(filename)