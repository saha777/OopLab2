using Lab2.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Command
{
    public class CloseGameCommand : ICommand
    {
        private Context context;

        public CloseGameCommand(Context context)
        {
            this.context = context;
        }

        public void Execute()
        {
            context.SetState(null);
        }

        public override string ToString()
        {
            return "close game";
        }
    }
}
