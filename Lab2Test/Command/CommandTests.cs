using Lab2;
using Lab2.Command;
using Lab2.Memento;
using Lab2.Model;
using Lab2.State;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Test.Command
{
    [TestClass]
    public class CommandTests : AbstractContextTest
    {
        protected RobotSnapshot _robotSnapshot;
        protected Robot _robotMemento;
        protected Lab2.State.State _stateMemento;

        [TestMethod]
        public void StartGameCommandTest()
        {
            createContext();

            ICommand startGameCommand = new StartGameCommand(_context, EState.DECIDING, true);

            startGameCommand.Execute();

            Assert.IsNotNull(_context.Robot);
            Assert.IsTrue(_context.State is DecidingState);
        }

        [TestMethod]
        public void OpenCommandTest()
        {
            StartGameCommandTest();

            int robotBattery = _context.Robot.BatteryBalance;
            int mass = _context.Robot.Mass;

            ICommand openCommand = new OpenCommand(_context);

            openCommand.Execute();

            Assert.IsFalse(robotBattery == _context.Robot.BatteryBalance);
            Assert.IsFalse(mass == _context.Robot.Mass);
            Assert.IsTrue(_context.State is DecidingState);
        }

        [TestMethod]
        public void SkipCommandTest()
        {
            StartGameCommandTest();

            int robotBattery = _context.Robot.BatteryBalance;
            int mass = _context.Robot.Mass;

            ICommand skipCommand = new SkipCommand(_context);

            skipCommand.Execute();

            Assert.IsFalse(robotBattery == _context.Robot.BatteryBalance);
            Assert.IsTrue(mass == _context.Robot.Mass);
            Assert.IsTrue(_context.State is DecidingState);
        }

        [TestMethod]
        public void MakeSnapshotCommandTest()
        {
            StartGameCommandTest();

            int snaphotCount = _context.GetRobotSnapshots().Count;
            _robotMemento = _context.Robot;
            _stateMemento = _context.State;

            ICommand makeSnapshotCommand = new MakeSnapshotCommand(_context);

            makeSnapshotCommand.Execute();

            _robotSnapshot = _context.GetRobotSnapshots()[snaphotCount];

            Assert.IsTrue(snaphotCount + 1 == _context.GetRobotSnapshots().Count);
            Assert.IsTrue(_context.State is DecidingState);
        }

        [TestMethod]
        public void EndGameCommandTest()
        {
            StartGameCommandTest();
            EndGameCommand();
        }

        public void EndGameCommand()
        {
            ICommand endGameCommand = new EndGameCommand(_context);

            endGameCommand.Execute();

            Assert.IsTrue(_context.State is EndGameState);
        }

        [TestMethod]
        public void BackUpCommandTest()
        {
            MakeSnapshotCommandTest();
            EndGameCommand();

            ICommand backUpCommand = new BackUpCommand(_context, _robotSnapshot);

            backUpCommand.Execute();

            Assert.IsTrue(_robotMemento.Equals(_context.Robot));
            Assert.IsTrue(_stateMemento.GetType().Equals(_context.State.GetType()));
            Assert.IsTrue(_context.State is DecidingState);
        }
    }
}
