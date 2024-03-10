class Entry{
    public string date;
    public string reponse;
    public string prompt;

    public void display(){
        Console.WriteLine($"{date}\n{prompt}\n{reponse}");
    }
}