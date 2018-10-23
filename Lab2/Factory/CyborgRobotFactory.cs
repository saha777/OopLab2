using System;
using System.Collections.Generic;
using System.Text;
using Lab2.Model;

namespace Lab2.Factory
{
    public class CyborgRobotFactory : IRobotFactory
    {
        public Robot Create()
        {
            return new Robot(800, 500, ERobot.CYBORG);
        }
    }
}
