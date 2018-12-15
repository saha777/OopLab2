using Lab2.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public interface IContext
    {
        List<ICommand> GetActions();
    }
}
