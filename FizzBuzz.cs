using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FizzBuzz
{
  public class Program
  {
    public static void Main(string[] args)
    {
    // step 1: Print numbers from 1-100.
    Console.WriteLine("Welcome to my FizzBuzz program!");
    for (int i = 1; i <= 100; i++)
      {
        // step 2: If divisible by 3 and 5, print FizzBuzz.
        if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
        // step 3: If divisible by 3, print Fizz.
        else if (i % 3 == 0) Console.WriteLine("Fizz");
        // step 4: If divisible by 5, print Buzz.
        else if (i % 5 == 0) Console.WriteLine("Buzz");
        // step 5: Print the number if not divisible by 3 or 5.
        else Console.WriteLine(i);
      }
    }
  }
}
