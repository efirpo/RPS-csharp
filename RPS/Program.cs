using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissorsGame
{
  public class Game
  {
    public static void Main()
    {
      try
      {
        RPS game = new RPS();
        Console.WriteLine("Welcome to Rock-Paper-Scissors! Would you like to play a game? [ Y / N ]");
        string playGame = Console.ReadLine().ToLower();
        if (playGame != "n")
        {
          if (playGame == "y")
          {
            Console.WriteLine("/^-^/ Close your eyes, Player2, it's Player1's turn! Please enter your choice:\n| rock | paper | scissor|");
            RPS.Input1 = Console.ReadLine().ToLower();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n /^-^/ Close your eyes, Player1, it's Player2's turn! Please enter your choice:\n| rock | paper | scissor|");
            RPS.Input2 = Console.ReadLine().ToLower();
            bool isValid = RPS.CheckInput(RPS.Input1, RPS.Input2);
            if (isValid == true)
            {
              RPS.CheckForWinner(RPS.Input1, RPS.Input2);
              if (RPS.Winner == "tie")
              {
                Console.WriteLine("It's a draw!");
              }
              else if (RPS.Winner == "player1")
              {
                Console.WriteLine("Player 1 wins! Congratulations!");
              }
              else if (RPS.Winner == "player2")
              {
                Console.WriteLine("Player 2 wins! Congratulations!");
              }
              else
              {
                Console.WriteLine("Something has gone wrong in winners");
              }
            }
            else if (isValid == false)
            {
              Console.WriteLine("It is not a valid choice.");
            }
          }
          else if (playGame == "n")
          {
            Console.WriteLine("Goodbye!");
            return;
          }
          else
          {
            Console.WriteLine("That is not a valid option, please try again.");
          }
          Console.WriteLine("Welcome to Rock-Paper-Scissors! Would you like to play a game? [ Y / N ]");
          playGame = Console.ReadLine().ToLower();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Source = {0}", ex.Source);
        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      }
    }
  }
}