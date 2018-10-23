using Lab2.Command;
using Lab2.State;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Lab2Test
{
    [TestClass]
    public class ContextTest
    {
        [TestMethod]
        public void StatesTest()
        {
            Context context = new Context();
            List<ICommand> commands = context.Execute();
            
            Assert.IsTrue(context.State is StartGameState);

            commands = context.Execute(commands[0]);

            Assert.IsTrue(context.State is DecidingState);



            commands = context.Execute(commands[0]);

            Assert.IsTrue(context.State is DecidingState);

            commands = context.Execute(commands[1]);

            Assert.IsTrue(context.State is DecidingState);

            commands = context.Execute(commands[2]);

            Assert.IsTrue(context.State is DecidingState);

            commands = context.Execute(commands[3]);

            Assert.IsTrue(context.State is EndGameState);



            commands = context.Execute(commands[0]);

            Assert.IsTrue(context.State is DecidingState);

            commands = context.Execute(commands[3]);

            Assert.IsTrue(context.State is EndGameState);



            commands = context.Execute(commands[1]);

            Assert.IsTrue(context.State is BackUpState);

            commands = context.Execute(commands[1]);

            Assert.IsTrue(context.State is DecidingState);

            commands = context.Execute(commands[3]);

            Assert.IsTrue(context.State is EndGameState);


            commands = context.Execute(commands[2]);
            Assert.IsNull(commands);
        }
    }
}
