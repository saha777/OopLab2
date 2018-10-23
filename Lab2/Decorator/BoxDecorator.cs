using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Decorator
{
    public abstract class BoxDecorator : Box
    {
        protected Box ChildBox { get; private set; }

        public BoxDecorator(Box childBox = null) : base(0, 0)
        {
            ChildBox = childBox;
        }

        public BoxDecorator(int cost, int mass, Box childBox = null) : base(cost, mass) { }

        public override int GetCost()
        {
            return ChildBox == null ? cost : cost + ChildBox.GetCost();
        }

        public override int GetMass()
        {
            return ChildBox == null ? mass : mass + ChildBox.GetMass();
        }
    }
}
