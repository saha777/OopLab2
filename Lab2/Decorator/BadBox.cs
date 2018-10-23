using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Decorator
{
    public class BadBox : BoxDecorator
    {
        public BadBox(Box childBox) : base(childBox)
        {
        }

        public override void Open(Robot robot)
        {
            robot.AddMass(this);
        }
    }
}
