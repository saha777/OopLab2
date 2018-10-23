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

        protected override List<ICommand> GetCommands()
        {
            List<ICommand> commands = new List<ICommand>();
            commands.Add(new StartGameCommand(context, EState.DECIDING, true));
            commands.Add(new CloseGameCommand(context));
            return commands;
        }

        private void PrintCommands()
        {
            StringBuilder stringBuilder = new StringBuilder()
                .Append("Actions: ").Append("\n")
                .Append("1. Start playing.").Append("\n")
                .Append("2. End Game.").Append("\n")
                .Append("Input number of action: ");
            //return base.PrintCommands(stringBuilder);
        }
    }
}
