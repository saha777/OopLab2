using System;
using System.Collections.Generic;
using System.Text;
using Lab2.Model;

namespace Lab2.Factory
{
    public class CleverRobotFactory : IRobotFactory
    {
        public Robot Create()
        {
            return new Robot(1000, 300, ERobot.CLEVER);
        }
    }
}
