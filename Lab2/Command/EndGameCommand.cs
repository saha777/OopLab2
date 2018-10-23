using Lab2.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Command
{
    public class EndGameCommand : ICommand
    {
        private Context context;

        public EndGameCommand(Context context)
        {
            this.context = context;
        }

        public void Execute()
        {
            context.SetState(StateFactory.Create(EState.END, context));
        }
    }
}
