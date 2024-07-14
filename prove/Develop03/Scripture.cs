using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Scripture
{
    private List<Word> _words;
    private Reference References{get;}

    public bool Learned()
    {
        return wordsPosition >= _words.Count;
    }

    public Scripture(Reference references, string text)
    {
        _words = new List<Word>();
        References = references;

        string[] splitText = text.Split(" ");
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }   
    }

    public string ShowText()
    {
        // Covert to string ussing Convertall
        List<string> text = _words.ConvertAll(word => word.ToString());
        string showText = string.Join(' ', text);  
        return References.Display() + showText;
    }
    
    public int wordsPosition = 0;
    public void HideText()
    {
        if (wordsPosition < _words.Count)
        {
            // Convert array to an ordinary (dynamic) list using .ToList()
            List<int> worodIndex = _words
                .Select((word, index) => new {Word = word, Index = index})
                .Where(article => !article.Word._isHidden)
                .Select(article => article.Index)
                .ToList();

            if (worodIndex.Count > 0)
            {
                Random random = new Random();
                int hint = random.Next(1, worodIndex.Count);
                _words[worodIndex[hint]].IsHide();
                // Need to be add to wordsPosition
                wordsPosition++;
            }
        }
    }       
    
}

  