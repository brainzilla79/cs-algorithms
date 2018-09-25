using System;

namespace DigitalRoot {
  class Program {
    static void Main(string[] args) {
      int ans = GetDigitalRoot(1853);
      Console.WriteLine(ans);
    }
    static int GetDigitalRoot(int num) {
      if (num < 10) {
        return num;
      }
      return GetDigitalRoot((num % 10) + (num / 10));
    }
  }
}