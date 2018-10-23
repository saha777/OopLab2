using Lab2.Decorator;
using Lab2.Model;
using Lab2.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Command
{
    public class OpenCommand : ICommand
    {
        private Context context;
        public Box Box { get; private set; }

        public OpenCommand(Context context)
        {
            this.context = context;
            this.Box = BoxFactory.Create();
        }

        public void Execute()
        {
            Box.Open(context.Robot);
            context.Robot.MinusBattery();
            context.SetState(StateFactory.Create(EState.DECIDING, context));
        }
        
        public override string ToString()
        {
            return "open box: " + Box.ToString();
        }
    }
}
