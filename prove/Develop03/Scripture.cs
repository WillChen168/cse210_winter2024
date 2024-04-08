class Scripture{
    private List <Word> _verse = new List<Word>();

    public List<int> nums = new List<int>();


    public string book;
    public string chapter;
        public Scripture (Reference reference){
        book = reference._book;
        chapter = reference._chapter;
        string [] scripturearray = reference._verse.Split(" ");
        int conter = 0;
        foreach (string scriptureword in scripturearray){
            _verse.Add(new Word(scriptureword));
            nums.Add(conter);
            conter+=1;


        }
    }


    public void display(){
        Console.Write(book+" "+chapter+" ");
        foreach(Word word in _verse) 
        {
            
            word.display();
        }
    }

    public void hiderandomword(){
        try{
        Random random = new Random();
        int randomnum = random.Next(nums.Count());
        _verse[nums[randomnum]].hideWord();
        nums.RemoveAt(randomnum);
        }
        catch{}

        
    }
}

