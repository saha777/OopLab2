using Lab2.Memento;
using Lab2.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Command
{
    public class BackUpCommand : ICommand
    {
        private Context context;
        private RobotSnapshot robotSnapshot;

        public BackUpCommand(Context context, RobotSnapshot robotSnapshot)
        {
            this.context = context;
            this.robotSnapshot = robotSnapshot;
        }

        public void Execute()
        {
            robotSnapshot.BackUp(context);
            context.SetState(StateFactory.Create(EState.DECIDING, context));
        }

        public override string ToString()
        {
            return "back up to " + robotSnapshot.ToString();
        }
    }
}
