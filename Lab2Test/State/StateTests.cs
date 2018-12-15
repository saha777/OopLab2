using Lab2.Command;
using Lab2.State;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Test.State
{
    [TestClass]
    public class StateTests : AbstractContextTest
    {
        [TestMethod]
        public void StartGameStateTest()
        {
            createContext();
            var startGameState = StateFactory.Create(EState.START, _context);
            Assert.IsNotNull(startGameState.Commands);
            Assert.IsTrue(startGameState.Commands.Count == 2);
            Assert.IsTrue(startGameState.Commands.FindAll(x => x is StartGameCommand).Count == 1);
            Assert.IsTrue(startGameState.Commands.FindAll(x => x is CloseGameCommand).Count == 1);
        }

        [TestMethod]
        public void DecidingStateTest()
        {
            createContext();
            var decidingGameState = StateFactory.Create(EState.DECIDING, _context);

            Assert.IsNotNull(decidingGameState.Commands);
            Assert.IsTrue(decidingGameState.Commands.Count == 4);

            Assert.IsTrue(decidingGameState.Commands.FindAll(x => x is OpenCommand).Count == 1);
            Assert.IsTrue(decidingGameState.Commands.FindAll(x => x is SkipCommand).Count == 1);
            Assert.IsTrue(decidingGameState.Commands.FindAll(x => x is MakeSnapshotCommand).Count == 1);
            Assert.IsTrue(decidingGameState.Commands.FindAll(x => x is EndGameCommand).Count == 1);
        }

        [TestMethod]
        public void BackUpStateTest()
        {
            createContext();
            var backUpGameState = StateFactory.Create(EState.BACK_UP, _context);

            Assert.IsNotNull(backUpGameState.Commands);
            Assert.IsTrue(backUpGameState.Commands.Count > 0);

            Assert.IsTrue(backUpGameState.Commands.FindAll(x => x is EndGameCommand).Count == 1);
        }

        [TestMethod]
        public void EndGameStateTest()
        {
            createContext();
            var endGameState = StateFactory.Create(EState.END, _context);

            Assert.IsNotNull(endGameState.Commands);
            Assert.IsTrue(endGameState.Commands.Count == 3);

            Assert.IsTrue(endGameState.Commands.FindAll(x => x is StartGameCommand).Count == 2);
            Assert.IsTrue(endGameState.Commands.FindAll(x => x is CloseGameCommand).Count == 1);
        }
    }
}
