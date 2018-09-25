using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms {
  class Program {
    static void Main (string[] args) {
      // Digital Root 
      Console.WriteLine ("DIGITAL ROOT");
      bool ans = DigitalRoot (1853) == 8;
      string status = ProccessResult (ans);
      Console.WriteLine ("Digital root should equal 8 {0}", status);

      // Caesar Cipher
      Console.ResetColor ();
      Console.WriteLine ("CAESAR CIPHER");
      ans = CaesarCipher ("hello", 4) == "lipps";
      status = ProccessResult (ans);
      Console.WriteLine ("Caesar Cipher should equal 'lipps' {0}", status);
      ans = CaesarCipher ("asdf asdf", 13) == "nfqs nfqs";
      status = ProccessResult (ans);
      Console.WriteLine ("Caesar Cipher should equal 'nfqs nfqs' {0}", status);

      //Sum Rec 
      Console.ResetColor ();
      Console.WriteLine ("SUM REC");
      int[] ar = { 1, 2, 3 };
      ans = SumRec (ar) == 6;
      status = ProccessResult (ans);
      Console.WriteLine ("Sum Rec should equal 6 {0}", status);

      // Fibs 
      Console.ResetColor ();
      Console.WriteLine ("FIBS");
      int[] ans1 = { 0, 1, 1 };
      ans = Enumerable.SequenceEqual (Fibs (3), ans1);
      status = ProccessResult (ans);
      Console.WriteLine ("Fibs(3) should equal [0, 1, 1] {0}", status);
      int[] ans2 = { 0, 1 };
      ans = Enumerable.SequenceEqual (Fibs (2), ans2);
      status = ProccessResult (ans);
      Console.WriteLine ("Fibs(2) should equal [0, 1] {0}", status);
      int[] ans3 = { 0, 1, 1, 2, 3 };
      ans = Enumerable.SequenceEqual (Fibs (5), ans3);
      status = ProccessResult (ans);
      Console.WriteLine ("Fibs(5) should equal [0, 1, 1, 2, 3] {0}", status);

      // Is Palindrome 
      Console.ResetColor ();
      Console.WriteLine ("IS PALINDROME");
      ans = !IsPalindrome ("ricecar");
      status = ProccessResult (ans);
      Console.WriteLine ("IsPalindrome('ricecar') shoud be false {0}", status);
      status = ProccessResult (IsPalindrome ("racecar"));
      Console.WriteLine ("IsPalindrome('racecar') shoud be true {0}", status);

      // Folding Cipher 
      Console.ResetColor ();
      Console.WriteLine ("FOLDING CIPHER");
      ans = FoldingCipher ("abcm") == "zyxn";
      status = ProccessResult (ans);
      Console.WriteLine ("FoldingCpiher('abcm') should equal 'zyxn' {0}", status);
    }

    static string ProccessResult (bool ans) {
      string status;
      if (ans) {
        Console.ForegroundColor = ConsoleColor.Green;
        status = "PASS";
      } else {
        status = "FAIL";
        Console.ForegroundColor = ConsoleColor.Red;
      }
      return status;
    }
    static int DigitalRoot (int num) {
      if (num < 10) {
        return num;
      }
      return DigitalRoot ((num % 10) + (num / 10));
    }

    static string CaesarCipher (string s, int shift) {
      char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray ();
      string result = "";
      for (int i = 0; i < s.Length; i++) {
        char c = s[i];
        if (c.ToString () == " ") {
          result += c;
        } else {
          int oldIndex = Array.IndexOf (alpha, c);
          int newIndex = (oldIndex + shift) % alpha.Length;
          result += alpha[newIndex];
        }
      }
      return result;
    }

    static int SumRec (int[] numbers) {
      if (numbers.Length == 0) {
        return 0;
      }
      int[] newNumbers = new int[numbers.Length - 1];
      Array.Copy (numbers, 1, newNumbers, 0, numbers.Length - 1);
      return SumRec (newNumbers) + numbers[0];
    }

    static int[] Fibs (int num) {
      int[] ar = { 0, 1 };
      List<int> fibs = new List<int> (ar);
      if (num < 1) {
        return null;
      }
      if (num < 3) {
        return fibs.Take (num).ToArray ();
      }
      while (fibs.Count < num) {
        fibs.Add (fibs[fibs.Count - 2] + fibs[fibs.Count - 1]);
      }
      return fibs.ToArray ();
    }

    static bool IsPalindrome (string s) {
      for (int i = 0; i < s.Length / 2; i++) {
        if (s[i] != s[s.Length - 1 - i]) {
          return false;
        }
      }
      return true;
    }
    static string FoldingCipher (string s) {
      char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray ();
      char[] reverse = new char[alpha.Length];
      Array.Copy(alpha, 0,reverse, 0, alpha.Length);
      Array.Reverse (reverse);
      Dictionary<char, char> alphaMap = new Dictionary<char, char> ();
      for (int i = 0; i < alpha.Length; i++) {
        alphaMap.Add (alpha[i], reverse[i]);
      }
      string result = "";
      for (int i = 0; i < s.Length; i++) {
        result += alphaMap[s[i]];
      }
      return result;
    }
  }
}