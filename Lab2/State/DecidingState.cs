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

        protected override ICommand GetCommand()
        {
            Box box = BoxFactory.Create();
            int commandId = PrintCommands(box);
            switch (commandId)
            {
                case 1:
                    return new OpenCommand(context.Robot, box);
                case 2:
                    return new SkipCommand(context.Robot);
                case 3:
                    return new MakeSnapshotCommand(context);
                case 4:
                    return new EndGameCommand(context);
                default:
                    Console.WriteLine("Number of action is not correct. Please, try again.");
                    return GetCommand();
            }
        }
        
        private int PrintCommands(Box box)
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
            return base.PrintCommands(stringBuilder);
        }
    }
}
