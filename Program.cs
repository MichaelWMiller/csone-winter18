using System;
using System.Collections.Generic;

namespace csone {
    class Program {
        static void Main (string[] args) {
            List<string> choices = new List<string> ();
            Dictionary<int, string> dict = new Dictionary<int, string> ();
            dict.Add (0, "rock");
            dict.Add (1, "paper");
            dict.Add (2, "scissors");

            choices.Add ("rock");
            choices.Add ("paper");
            choices.Add ("scissors");

            for (int i = 0; i < choices.Count; i++) {
                Console.WriteLine (choices[i]);
            }
            bool playing = true;
            Console.WriteLine ("Play Rock-Paper-Scissors?");
            string choice = Console.ReadLine().ToLower();
               if (choice[0] == 'n') 
               {
                    playing = false;
               }
            while (playing) {
                Random rnd = new Random ();
                int randomNumber = rnd.Next (0, 3);
                System.Console.WriteLine ("Lets Play!   Rock, paper or scissors?");
                string guess = System.Console.ReadLine ().ToLower ();
                char charGuess = guess[0];

                string sysGuess = dict[randomNumber];

                if (sysGuess[0] == charGuess) {
                    Console.WriteLine ("I guessed " + sysGuess + "-- A Tie!");
                }
                if (sysGuess[0] == 'r') {
                    if (charGuess == 'p') {
                        Console.WriteLine ("I guessed Rock -- YOU win!");
                    } else if (charGuess == 's') {
                        Console.WriteLine ("I guess Rock -- I Win!");
                    }
                }
                if (sysGuess[0] == 'p') {
                    if (charGuess == 'r') {
                        Console.WriteLine ("I guessed Paper -- I win!!");
                    } else if (charGuess == 's') {
                        Console.WriteLine ("I guessed Paper -- YOU win!");
                    }
                }
                if (sysGuess[0] == 's') {
                    if (charGuess == 'r') {
                        Console.WriteLine ("I guessed Scissors -- YOU win!!");
                    } else if (charGuess == 'p') {
                        Console.WriteLine ("I guess Scissors -- I wiin!!");
                    }

                }

                Console.WriteLine ("Do you want to play again?");
                string playAgain = Console.ReadLine ().ToLower ();
                if (playAgain[0] == 'n') {
                    playing = false;
                }
            }
        }
    }
}