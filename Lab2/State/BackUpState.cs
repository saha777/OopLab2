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

        public override List<ICommand> GetCommands()
        {
            List<ICommand> commands = new List<ICommand>();
            commands.Add(new EndGameCommand(context));
            foreach(RobotSnapshot snapshot in context.GetRobotSnapshots())
            {
                commands.Add(new BackUpCommand(context, snapshot));
            }
            return commands;
        }
    }
}
