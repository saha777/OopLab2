using Lab2.Memento;
using Lab2.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Command
{
    public class MakeSnapshotCommand : ICommand
    {
        private Context context;

        public MakeSnapshotCommand(Context context)
        {
            this.context = context;
        }

        public void Execute()
        {
            context.AddSnaphot(new RobotSnapshot(context.Robot, context.State));
        }

        public override string ToString()
        {
            return "make snapshot";
        }
    }
}
