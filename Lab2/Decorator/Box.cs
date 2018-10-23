using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Decorator
{
    public abstract class Box
    {
        protected int cost;
        protected int mass;

        public Box(int cost, int mass)
        {
            this.cost = cost;
            this.mass = mass;
        }

        public abstract void Open(Robot robot);
        public abstract int GetCost();
        public abstract int GetMass();

        public string ToString()
        {
            return " Box { cost: " + GetCost() + "; mass: " + GetMass() + "} ";
        }
    }
}
