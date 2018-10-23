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

        protected override ICommand GetCommand()
        {
            int commandId = PrintCommands();
            switch (commandId)
            {
                case 1:
                    return new StartGameCommand(context, EState.DECIDING, true);
                case 2:
                    return new StartGameCommand(context, EState.BACK_UP);
                case 3:
                    return new CloseGameCommand(context);
                default:
                    Console.WriteLine("Number of action is not correct. Please, try again.");
                    return GetCommand();
            }
        }

        private int PrintCommands()
        {
            StringBuilder stringBuilder = new StringBuilder()
                .AppendLine("Game Over")
                .AppendLine(context.Robot.ToString())
                .AppendLine("Actions: ")
                .AppendLine("1. Start playing.")
                .AppendLine("2. Make back up.")
                .AppendLine("3. End Game.")
                .Append("Input number of action: ");
            return base.PrintCommands(stringBuilder);
        }
    }
}
