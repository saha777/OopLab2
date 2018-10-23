using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Factory
{
    public interface IRobotFactory
    {
        Robot Create();
    }
}
