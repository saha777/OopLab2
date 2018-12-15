using System;
using System.Collections.Generic;
using System.Text;
using Lab2.Command;

namespace Lab2.State
{
    public abstract class State
    {
        public List<ICommand> Commands { get; private set; }
        protected Context context;

        public State(Context context)
        {
            this.context = context;
            Commands = GetCommands();
        }

        public abstract List<ICommand> GetCommands();
    }
}
