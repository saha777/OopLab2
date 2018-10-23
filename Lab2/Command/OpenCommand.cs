using Lab2.Decorator;
using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Command
{
    public class OpenCommand : ICommand
    {
        private Robot robot;
        private Box box;

        public OpenCommand(Robot robot, Box box)
        {
            this.robot = robot;
            this.box = box;
        }

        public void Execute()
        {
            box.Open(robot);
            robot.MinusBattery();
        }
    }
}
