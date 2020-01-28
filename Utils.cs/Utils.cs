using System;
//NOTE calling these methods is System.Console.WriteLine(Utils.DoubleInteget(12), etc)
//NOTE This is the morning challenge from 28 January 2019

namespace library.Utils
{
  static class MainUtils
  {
    public static int RandomInt(int min, int max)
    {
      Random rnd = new Random();
      return rnd.Next(min, max);
    }

    public static int DoubleInteger(int num)
    {
      return num * 2;
    }

    public static bool isNumberEven(int num)
    {
      return num % 2 == 0;
    }
    public static string GetFileExtension(string filename)
    {
      String[] vals = filename.Split('.');
      if (vals.Length > 1)
      {
        return vals[vals.Length - 1];
      }
      return null;
    }

    public static string LongestString(string[] words)
    {
      string longest = "";
      for (int i = 0; i < words.Length; i++)
      {
        string word = words[i];
        if (word.Length > longest.Length)
        {
          longest = word;
        }
      }
      return longest;

    }

    public static int ArraySum(int[] nums)
    {
      int total = 0;
      for (int i = 0; i < nums.Length; i++)
      {
        total += nums[i];
      }
      return total;
    }

  }
}