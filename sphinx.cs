using System;
using System.Collections.Generic;


public class Sphinx 
{

    public static Dictionary<string, string>  riddle = new Dictionary<string, string>() {
      {"blue", "What color is the sky?"}, 
      {"an egg", "What has to be broken before you can use it?"}, 
      {"a candle", "I’m tall when I’m young, and I’m short when I’m old. what am I?"}, 
      {"all of them", "What month of the year has 28 days?"}, 
      {"a sponge", "What is full of holes but still holds water?"}
      };

    public static List<string> riddleKeys = new List<string>{};

    public static void Main(){
      ListKeys();
      string random = RandomRiddle();
      Console.WriteLine("hello i am the Sphinx, here is a riddle. " + riddle[random]);
      string input = Console.ReadLine();
      string inputLower = input.ToLower();
      if (riddle.ContainsKey(inputLower)){
        Console.WriteLine("correct");
      }else{
        Console.WriteLine("Going to eat you");
      }
    }

    public void ListKeys()
        { 
            Dictionary<string, string>.KeyCollection keyColl = riddle.Keys;
            foreach(string key in keyColl){
              riddleKeys.Add(key);
            }
        }

    public string RandomRiddle()
        {
          Random rndm = new Random();
          string random = riddleKeys[rndm.Next(riddleKeys.Count)];
          return random;
        }
}