using System;
using System.Collections.Generic;

namespace csone
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.Clear();
      Console.WriteLine("Hello User, what's your name?");
      var myName = Console.ReadLine();
      Console.WriteLine("Hello {0}, how's it going {0}?", myName);
      string mood = Console.ReadLine();
      if (mood == "good")
      {
        Console.WriteLine("Glad to hear it!");
      }
      else if (mood == "bad")
      {
        Console.WriteLine("Thats a bummer dude");
      }
      else
      {
        System.Console.WriteLine("Whatever");
      }
      // Console.WriteLine($"How Old are you {myName}");
      // string ageString = Console.ReadLine();
      // float age = 0f;
      // float.TryParse(ageString, out age);
      // if (age != 0 && age > 21)
      // {
      //   Console.WriteLine("Yer old enough");
      // }
      // else
      // {
      //   Console.WriteLine("Not today Kid");
      // }
      bool playing = true;
      Console.WriteLine("Do you want to play a game?");
      string choice = Console.ReadLine().ToLower();
      if (choice[0] == 'n')
      {
        playing = false;
      }
      while (playing)
      {
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 5);
        System.Console.WriteLine("Lets Play! Pick a number between 1 and 5");
        string guess = Console.ReadLine();
        int numberGuess;
        int.TryParse(guess, out numberGuess);
        if (numberGuess == randomNumber)
        {
          System.Console.WriteLine(" YOU WIN!!!! ");
        }
				else
				{
					System.Console.WriteLine("HAHA U LOSE!");
				}
        System.Console.WriteLine("Play Again?");
          string play = Console.ReadLine().ToLower();
          if (play[0] == 'n')
          {
            playing = false;
          }
      }
			List<string> choices = new List<string>();
			//Dictionary<string, int> myDictionary = new Dictionary<string, int>();
			choices.Add("rock");
			choices.Add("paper");
			choices.Add("scissors");

			for (int i = 0; i < choices.Count; i++)
			{
					System.Console.WriteLine(choices[i]);
			}

    }
  }
}
