using System;
using System.Collections.Generic;

namespace WordCounter.Models
{

  public class RepeatCounter
  {
    private string _sentence;
    private string _word;
    private int _counter;

    public RepeatCounter (string sentence, string word, int counter = 0)
    {
      _sentence = sentence;
      _word = word;
      _counter = counter;
    }

    public static int CountWords(string sentence, string word)
    {
    string [] inputSentence = sentence.ToLower().Split(new Char [] {' ','.', ',','!','?',});
      int counter = 0;

      foreach (string inputword in inputSentence)
      {
        if (inputword == word.ToLower())
        {
          counter++;
        }
      }
      return counter;
    }
  }
}
