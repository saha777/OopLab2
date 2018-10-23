using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Decorator
{
    public class SimpleBox : Box
    {
        public SimpleBox(int cost, int mass) : base(cost, mass)
        {
        }

        public override int GetCost()
        {
            return cost;
        }

        public override int GetMass()
        {
            return mass;
        }

        public override void Open(Robot robot)
        {
            robot.AddMass(this);
        }
    }
}
