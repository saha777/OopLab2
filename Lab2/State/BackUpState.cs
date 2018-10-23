using System;
using System.Collections.Generic;
using System.Text;
using Lab2.Command;
using Lab2.Memento;

namespace Lab2.State
{
    public class BackUpState : State
    {
        public BackUpState(Context context) : base(context)
        {
        }

        protected override ICommand GetCommand()
        {
            int commandId = PrintCommands();
            if (commandId == 0)
            {
                return new EndGameCommand(context);
            }
            else if (commandId <= context.GetRobotSnapshots().Count)
            {
                return new BackUpCommand(context, context.GetRobotSnapshots()[commandId - 1]);
            }
            else
            {
                Console.WriteLine("Number of action is not correct. Please, try again.");
                return GetCommand();
            }
        }

        private int PrintCommands()
        {
            StringBuilder stringBuilder = new StringBuilder()
                .AppendLine("Actions: ")
                .AppendLine("0. Exit.");

            int count = 0;
            foreach (var robotSnapshot in context.GetRobotSnapshots())
            {
                count++;
                stringBuilder.AppendLine(count + ": " + robotSnapshot.ToString());
            }

            stringBuilder.Append("Input number of action: ");
            return base.PrintCommands(stringBuilder);
        }
    }
}
