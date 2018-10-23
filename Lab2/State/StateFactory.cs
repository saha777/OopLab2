using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.State
{
    public class StateFactory
    {
        public static State Create(EState state, Context context)
        {
            switch(state)
            {
                case EState.START:
                    return new StartGameState(context);
                case EState.DECIDING:
                    return new DecidingState(context);
                case EState.BACK_UP:
                    return new BackUpState(context);
                default:
                    return new EndGameState(context);

            }
        }
    }
}
