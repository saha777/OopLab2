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

        protected override List<ICommand> GetCommands()
        {
            List<ICommand> commands = new List<ICommand>();
            commands.Add(new EndGameCommand(context));
            foreach(RobotSnapshot snapshot in context.GetRobotSnapshots())
            {
                commands.Add(new BackUpCommand(context, snapshot));
            }
            return commands;
        }

        private void PrintCommands()
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
        }
    }
}
