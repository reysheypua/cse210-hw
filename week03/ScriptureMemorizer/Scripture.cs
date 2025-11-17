class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] splitWords = text.Split(" ");
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<int> visibleIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        if (visibleIndexes.Count == 0)
            return;

        int hideCount = Math.Min(numberToHide, visibleIndexes.Count);

        for (int i = 0; i < hideCount; i++)
        {
            int randomPick = _random.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randomPick];

            _words[wordIndex].Hide();

            visibleIndexes.RemoveAt(randomPick);
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = "";

        foreach (Word word in _words)
        {
            wordsText += word.GetDisplayText() + " ";
        }

        wordsText = wordsText.Trim();

        return referenceText + "\n" + wordsText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words
        )
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

}