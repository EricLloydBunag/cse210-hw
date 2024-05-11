public class Scripture{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(){
        Random random = new Random();
        int wordsToHide = random.Next(1, _words.Count / 3);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(0, _words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText(){
        string displayText = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            displayText += word.DisplayText() + " ";
        }

        return displayText.Trim();
    }

    public bool IsCompletelyHidden(){
        return _words.All(word => word.IsHidden());
    }
}