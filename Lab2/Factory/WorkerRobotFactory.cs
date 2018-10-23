using System;
using System.Collections.Generic;
using System.Text;
using Lab2.Model;

namespace Lab2.Factory
{
    public class WorkerRobotFactory : IRobotFactory
    {
        public Robot Create()
        {
            return new Robot(1200, 1000, ERobot.WORKER);
        }
    }
}
