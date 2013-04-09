using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackjackLogic;

namespace BlackjackTests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void OneShouldBe52Cards()
        {
            BlackjackGame bj = new BlackjackGame();
            Assert.AreEqual(52, bj.Deck.Cards.Count);
        }
        
        [TestMethod]
        public void TwoDecksShouldBe104Cards()
        {
            BlackjackGame bj = new BlackjackGame(2);
            Assert.AreEqual(104, bj.Deck.Cards.Count);
        }

        [TestMethod]
        public void FourDecksShouldBe208Cards()
        {
            BlackjackGame bj = new BlackjackGame(4);
            Assert.AreEqual(208, bj.Deck.Cards.Count);
        }
    }
}
