using Lab2.Command;
using Lab2.Decorator;
using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.State
{
    public class DecidingState : State
    {
        public DecidingState(Context context) : base(context)
        {
        }

        protected override List<ICommand> GetCommands()
        {
            List<ICommand> commands = new List<ICommand>();
            commands.Add(new OpenCommand(context));
            commands.Add(new SkipCommand(context));
            commands.Add(new MakeSnapshotCommand(context));
            commands.Add(new EndGameCommand(context));
            return commands;
        }
        
        private void PrintCommands(Box box)
        {
            StringBuilder stringBuilder = new StringBuilder()
                .AppendLine("Robot state")
                .AppendLine(context.Robot.ToString())
                .AppendLine("New box")
                .AppendLine(box.ToString())
                .AppendLine("Actions: ")
                .AppendLine("1. Open box.")
                .AppendLine("2. Skip box.")
                .AppendLine("3. Make snapshot.")
                .AppendLine("4. End Game.")
                .Append("Input number of action: ");
            //return base.PrintCommands(stringBuilder);
        }
    }
}
