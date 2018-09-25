using System;

namespace Algorithms {
  class Program {
    static void Main (string[] args) {
      bool ans = DigitalRoot (1853) == 8;
      string status = ProccessResult(ans);
      Console.WriteLine ("Digital root should equal 8 {0}", status);
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
  }
}