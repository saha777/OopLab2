using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Decorator
{
    public class EncodedBox : BoxDecorator
    {
        public EncodedBox(Box childBox = null) : base(childBox)
        {
        }

        public EncodedBox(int cost, int mass, Box childBox = null) : base(cost, mass, childBox)
        {
        }

        public override void Open(Robot robot)
        {
            if (robot.RobotType == ERobot.CLEVER)
            {
                robot.AddMass(this);
            }
            else
            {
                int various = new Random().Next(0, 10);
                if(robot.RobotType == ERobot.CYBORG && various < 6)
                {
                    robot.AddMass(this);
                } 
                else if(robot.RobotType == ERobot.WORKER && various < 1)
                {
                    robot.AddMass(this);
                }
            }
        }
    }
}
