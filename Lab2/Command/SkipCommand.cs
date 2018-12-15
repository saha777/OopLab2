using Lab2.Model;
using Lab2.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Command
{
    public class SkipCommand : ICommand
    {
        private Context context;

        public SkipCommand(Context context)
        {
            this.context = context;
        }

        public void Execute()
        {
            context.Robot.MinusBattery(2);
            context.SetState(StateFactory.Create(EState.DECIDING, context));
        }

        public override string ToString()
        {
            return "skip";
        }
    }
}
