using System;
using System.Collections.Generic;
using System.Text;
using Lab2.Command;
using Lab2.IO;

namespace Lab2.State
{
    public abstract class State
    {
        private ICommand command;
        protected Context context;

        public State(Context context)
        {
            this.context = context;
        }

        public void Execute()
        { 
            command = GetCommand();
            command.Execute();
        }

        protected abstract ICommand GetCommand();
        
        protected int PrintCommands(StringBuilder builder)
        {
            IOSystem.Clear();
            IOSystem.Write(builder);
            return Int32.Parse(Console.ReadLine());
        }
    }
}
