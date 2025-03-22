using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture 
{
    private string _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text) {
        _reference = reference.ToString();
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide) {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        int count = 0;

        while (count < numberToHide && visibleWords.Count > 0)
        {
            var wordToHide = visibleWords[_random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
            count++;
        }
    }

    public string GetDisplayText() {
        return $"{_reference}\n{string.Join(" ", _words.Select(word => word.GetDisplayText()))}"; 
    }
    public bool IsCompletelyHidden() {
        return _words.All(word => word.IsHidden());
    }
}

