using Lab2.Command;
using Lab2.State;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Lab2Test
{
    [TestClass]
    public class ContextTest : AbstractContextTest
    {
        [TestMethod]
        public void StatesTest()
        {
            createContext();
            List<ICommand> commands = _context.GetActions();
            
            Assert.IsTrue(_context.State is StartGameState);

            commands = _context.GetActions();
            commands[0].Execute();

            Assert.IsTrue(_context.State is DecidingState);



            commands = _context.GetActions();
            commands[0].Execute();

            Assert.IsTrue(_context.State is DecidingState);

            commands = _context.GetActions();
            commands[1].Execute();

            Assert.IsTrue(_context.State is DecidingState);

            commands = _context.GetActions();
            commands[2].Execute();

            Assert.IsTrue(_context.State is DecidingState);

            commands = _context.GetActions();
            commands[3].Execute();

            Assert.IsTrue(_context.State is EndGameState);



            commands = _context.GetActions();
            commands[0].Execute();

            Assert.IsTrue(_context.State is DecidingState);

            commands = _context.GetActions();
            commands[3].Execute();

            Assert.IsTrue(_context.State is EndGameState);



            commands = _context.GetActions();
            commands[1].Execute();

            Assert.IsTrue(_context.State is BackUpState);

            commands = _context.GetActions();
            commands[1].Execute();

            Assert.IsTrue(_context.State is DecidingState);

            commands = _context.GetActions();
            commands[3].Execute();

            Assert.IsTrue(_context.State is EndGameState);


            commands = _context.GetActions();
            commands[2].Execute();
            Assert.IsNull(_context.GetActions());
        }
    }
}
