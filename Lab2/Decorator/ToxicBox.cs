using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Decorator
{
    public class ToxicBox : BoxDecorator
    {

        public ToxicBox(Box childBox = null) : base(childBox)
        {
        }

        public ToxicBox(int cost, int mass, Box childBox = null) : base(cost, mass, childBox)
        {
        }

        public override void Open(Robot robot)
        {
            if (robot.RobotType == ERobot.CYBORG)
            {
                robot.MinusBattery(robot.BatteryBalance);
            } else
            {
                robot.AddMass(this);
            }
        }
    }
}
