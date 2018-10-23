using Lab2.Model;
using Lab2.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Memento
{
    public class RobotSnapshot
    {
        private Robot robot;
        private State.State state;

        public RobotSnapshot(Robot robot, State.State state)
        {
            this.robot = robot;
            this.state = state;
        }

        public void BackUp(Context context)
        {
            context.SetRobot(robot.Clone() as Robot);
            context.SetState(state);
        }

        public override string ToString()
        {
            return robot.ToString() + "\n" + state.ToString();
        }
    }
}
