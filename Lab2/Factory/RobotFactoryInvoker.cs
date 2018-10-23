using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Factory
{
    public class RobotFactoryInvoker
    {

        public static Robot CreateRobot()
        {
            int various = new Random().Next(0, 10);
            IRobotFactory robotFactory;
            if (various <= 2)
            {
                robotFactory = new CleverRobotFactory();
            }
            else if (various <= 5)
            {
                robotFactory = new CyborgRobotFactory();
            }
            else
            {
                robotFactory = new WorkerRobotFactory();
            }
            return robotFactory.Create();
        }
    }
}
