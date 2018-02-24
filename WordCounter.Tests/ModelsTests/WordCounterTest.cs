using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {

    [TestMethod]
    public void CountWords_OneLetter_1()
    {
      string inputSentence = "a";
      string inputWord = "a";
      RepeatCounter testInputSentence = new RepeatCounter(inputSentence, inputWord);
      int expectedOutput = RepeatCounter.CountWords(inputSentence, inputWord);


      Assert.AreEqual(1, expectedOutput);
    }
    [TestMethod]
    public void CountWords_OneWord_1()
    {

      string inputSentence = "jahmanz";
      string inputWord = "jahmanz";
      RepeatCounter testInputtedSentence = new RepeatCounter(inputSentence, inputWord);


      int expectedOutput = RepeatCounter.CountWords(inputSentence, inputWord);


      Assert.AreEqual(1, expectedOutput);
    }
    [TestMethod]
    public void CountWords_Sentence_2()
    {

      string inputSentence = "jahmanz is jahmanz";
      string inputWord = "jahmanz";
      RepeatCounter testInputtedSentence = new RepeatCounter(inputSentence, inputWord);


      int expectedOutput = RepeatCounter.CountWords(inputSentence, inputWord);


      Assert.AreEqual(2, expectedOutput);
    }
  }
}
