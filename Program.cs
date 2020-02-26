using System;
using System.Collections.Generic;
using Model;

public static class GuessGame
{
  static void Main()
  {
    Console.WriteLine("Would you like to guess first or can I guess your number?");
    Console.WriteLine("Press 'H' to guess the Computers number... ");
    Console.WriteLine("Press 'C' to have the computer guess your number... ");
    Console.WriteLine("Press 'Any other key' to quit... ");
    string playerInput = Console.ReadLine().ToLower();
  
    if (playerInput  == "c") {
      //start computer.
      ComputerGuess.Guess();

    }
    else if(playerInput == "h")
    {
      //start human guessing game.
      HumanGuess.Guess();
    }
    else
    {
      //Quit Game.
      Console.WriteLine("OK, have a nice day!");
    }
  }

  
}