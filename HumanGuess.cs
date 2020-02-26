using System;

namespace Model {

  class HumanGuess {
    public static void Guess()
  {
      Console.WriteLine("human guessing computer");
      var RNum = new Random();
      int rnd = RNum.Next(1,100);
      CheckValue(rnd);
  }
    public static void CheckValue( int CompGuess)
    {
      Console.WriteLine("Guess a number between 1 and 100");
      string userInput = Console.ReadLine();
      int userNumber = int.Parse(userInput);
      bool GameOver = false;
      if (userNumber > CompGuess)
      {
        Console.WriteLine("Guess lower number");
      }
      else if (userNumber < CompGuess)
      {
        Console.WriteLine("Guess a higher number");
      }
      else if (userNumber == CompGuess)
      {
        Console.WriteLine("You win!");
        GameOver = true;
      }
      else
      {
        Console.WriteLine("Error");
      }
      if (!GameOver)
      {
        Console.WriteLine();
        CheckValue(CompGuess);
      }
    }
  }

}