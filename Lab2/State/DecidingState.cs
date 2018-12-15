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

        public override List<ICommand> GetCommands()
        {
            List<ICommand> commands = new List<ICommand>();
            commands.Add(new OpenCommand(context));
            commands.Add(new SkipCommand(context));
            commands.Add(new MakeSnapshotCommand(context));
            commands.Add(new EndGameCommand(context));
            return commands;
        }
    }
}
