using System;
using System.Collections.Generic;
using Scrabb.Score;

namespace ScrabUI
{
  public class Program
  {
    public static void Main() 
    {
      Console.WriteLine("Type your scrabble word below to determine your score:");
      string word = Console.ReadLine();
			SScore letterScore = new SScore();
      Console.WriteLine("Your word score is: " + letterScore.SScoreTab(word));
      Main();
    }
  }
}