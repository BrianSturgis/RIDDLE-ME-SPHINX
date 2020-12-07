using System;
using System.Collections.Generic;
using Models;

public class Program
{
    public static void Main(){
      Sphinx name = new Sphinx();
      name.ListKeys();
      string random = name.RandomRiddle();
      Console.WriteLine("hello i am the Sphinx, here is a riddle. " + riddle[random]);
      string input = Console.ReadLine();
      string inputLower = input.ToLower();
      if (riddle.ContainsKey(inputLower)){
        Console.WriteLine("correct");
      }else{
        Console.WriteLine("Going to eat you");
      }
    }
}