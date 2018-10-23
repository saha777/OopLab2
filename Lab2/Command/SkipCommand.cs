using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Command
{
    public class SkipCommand : ICommand
    {
        private Robot robot;

        public SkipCommand(Robot robot)
        {
            this.robot = robot;
        }

        public void Execute()
        {
            robot.MinusBattery();
        }
    }
}
