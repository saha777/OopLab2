using Lab2.Factory;
using Lab2.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Command
{
    public class StartGameCommand : ICommand
    {
        private Context context;
        private EState eState;
        private bool createRobot;

        public StartGameCommand(Context context, EState state, bool createRobot = false)
        {
            this.context = context;
            this.eState = state;
            this.createRobot = createRobot;
        }

        public void Execute()
        {
            if (createRobot)
            {
                context.SetRobot(RobotFactoryInvoker.CreateRobot());
            }
            context.SetState(StateFactory.Create(eState, context));
        }

        public override string ToString()
        {
            return eState == EState.DECIDING ? "start game" : "back up";
        }
    }
}
