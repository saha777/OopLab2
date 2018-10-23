using Lab2.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.State
{
    public class EndGameState : State
    {
        public EndGameState(Context context) : base(context)
        {
        }

        protected override List<ICommand> GetCommands()
        {
            List<ICommand> commands = new List<ICommand>();
            commands.Add(new StartGameCommand(context, EState.DECIDING, true));
            commands.Add(new StartGameCommand(context, EState.BACK_UP));
            commands.Add(new CloseGameCommand(context));
            return commands;
        }

        private void PrintCommands()
        {
            StringBuilder stringBuilder = new StringBuilder()
                .AppendLine("Game Over")
                .AppendLine(context.Robot.ToString())
                .AppendLine("Actions: ")
                .AppendLine("1. Start playing.")
                .AppendLine("2. Make back up.")
                .AppendLine("3. End Game.")
                .Append("Input number of action: ");
            //return base.PrintCommands(stringBuilder);
        }
    }
}
