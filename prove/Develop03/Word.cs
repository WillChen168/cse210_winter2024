class Word{
    private string _word;

    public Word(string word){
        _word = word;

    }

    public void random(){
        Random random = new Random();
        
    }

    public void display() {
        Console.Write(_word + " ");
    }

    public void hideWord() {
        int wordLength = _word.Length;
        _word = "";
        for (int i = 0; i < wordLength;i++){
            _word += "_";
        }
    }

}