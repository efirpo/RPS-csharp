using System;

namespace RockPaperScissors.Models
{
  public class RPS
  {

    public static string Input1 { get; set; }
    public static string Input2 { get; set; }
    public static string Winner { get; set; }

    public static bool CheckInput(string input1, string input2)
    {
      Input1 = input1;
      Input2 = input2;

      if (Input1 == "scissor")
      {
        return true;
      }
      else if (Input1 == "paper")
      {
        return true;
      }
      else if (Input1 == "rock")
      {
        return true;
      }
      else
      {
        return false;
      }

      if (Input2 == "scissor")
      {
        return true;
      }
      else if (Input2 == "paper")
      {
        return true;
      }
      else if (Input2 == "rock")
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public static string CheckForWinner(string input1, string input2)
    {
      Input1 = input1;
      Input2 = input2;
      if (Input1 == Input2)
      {
        Winner = "tie";
      }
      else if (Input1 == "scissor" && Input2 == "paper" || Input1 == "paper" && Input2 == "rock" || Input1 == "rock" && Input2 == "scissor")
      {
        Winner = "player1";
      }
      else if (Input2 == "scissor" && Input1 == "paper" || Input2 == "paper" && Input1 == "rock" || Input2 == "rock" && Input1 == "scissor")
      {
        Winner = "player2";
      }
      return Winner;
    }
  }
}