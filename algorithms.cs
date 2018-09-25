using System;

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
      List<int> result = new List<int> ();
      int[] ar = { 0, 1 };
      result.AddRange (ar);
      if (num < 1) {
        return null;
      }

    }
  }
}