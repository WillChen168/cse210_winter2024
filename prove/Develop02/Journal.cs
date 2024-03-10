class Journal{
    public List<Entry> entries = new List<Entry>();
    List<string> prompts = new List<string>(){
    "How was your day?","Who was the most interesting person I interacted with today?",
    "What was the best part of my day?","How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    };
    public void getEntry(){
        Entry entry = new Entry();
        Random random = new Random();
        int randomnumber = random.Next(5);
        entry.prompt = prompts[randomnumber];
        DateTime theCurrentTime = DateTime.Now;
        entry.date = theCurrentTime.ToShortDateString();
        Console.WriteLine(entry.prompt);
        Console.WriteLine("Write your entry");
        entry.reponse=Console.ReadLine();
        entries.Add(entry);

    }

    public void display()
    {
        foreach (Entry entry in entries)
    
        {
            entry.display();
        }
    }
    public void Load()
    {
        Console.WriteLine("Please type file name");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string reponse = parts[2];
            Entry entry = new Entry();
            entry.date = date;
            entry.prompt = prompt;
            entry.reponse = reponse;
            entries.Add(entry);
        }
    }
    public void Save()
    {
        Console.WriteLine("Please create file name");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in entries){
                outputFile.WriteLine($"{entry.date},{entry.prompt},{entry.reponse}");
            }
        }
    }
}