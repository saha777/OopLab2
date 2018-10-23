using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Decorator
{
    public class BoxFactory
    {
        public static Box Create()
        {
            Random random = new Random();

            int various = random.Next(0, 10);
            int cost = random.Next(10, 100);
            int mass = random.Next(20, 100);

            Box box = new SimpleBox(cost, mass);

            if (various <= 4)
            {
                return box;
            }
            else if (various <= 5)
            {
                return new ToxicBox(box);
            }
            else if (various <= 7)
            {
                return new EncodedBox(box);
            }
            else
            {
                return new BadBox(box);
            }
        }
    }
}
