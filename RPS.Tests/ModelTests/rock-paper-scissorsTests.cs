using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RPSTests
  {
    [TestMethod]
    public void RPSCheckInput_CheckIfInputIsValid_True()
    {
      RPS game = new RPS();
      Assert.AreEqual(true, RPS.CheckInput("scissor", "scissor"));
    }
    [TestMethod]
    public void RPSCheckForWinner_CheckIfThereIsAWinner_Tie()
    {
      RPS game = new RPS();
      Assert.AreEqual("tie", RPS.CheckForWinner("scissor", "scissor"));
    }
    [TestMethod]
    public void RPSCheckForWinner_CheckIfThereIsAWinner_Player1()
    {
      RPS game = new RPS();
      Assert.AreEqual("player1", RPS.CheckForWinner("scissor", "paper"));
      Assert.AreEqual("player1", RPS.CheckForWinner("paper", "rock"));
      Assert.AreEqual("player1", RPS.CheckForWinner("rock", "scissor"));
    }
    [TestMethod]
    public void RPSCheckForWinner_CheckIfThereIsAWinner_Player2()
    {
      RPS game = new RPS();
      Assert.AreEqual("player2", RPS.CheckForWinner("paper", "scissor"));
      Assert.AreEqual("player2", RPS.CheckForWinner("rock", "paper"));
      Assert.AreEqual("player2", RPS.CheckForWinner("scissor", "rock"));
    }
  }
}