using Lab2.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.State
{
    public class StartGameState : State
    {

        public StartGameState(Context context) : base(context)
        {
        }

        protected override ICommand GetCommand()
        {
            int commandId = PrintCommands();
            switch (commandId)
            {
                case 1:
                    return new StartGameCommand(context, EState.DECIDING, true);
                case 2:
                    return new CloseGameCommand(context);
                default:
                    Console.WriteLine("Number of action is not correct. Please, try again.");
                    return GetCommand();
            }
        }

        private int PrintCommands()
        {
            StringBuilder stringBuilder = new StringBuilder()
                .Append("Actions: ").Append("\n")
                .Append("1. Start playing.").Append("\n")
                .Append("2. End Game.").Append("\n")
                .Append("Input number of action: ");
            return base.PrintCommands(stringBuilder);
        }
    }
}
