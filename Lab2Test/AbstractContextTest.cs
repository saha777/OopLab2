using Lab2.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Test
{
    public abstract class AbstractContextTest
    {
        protected Context _context;

        protected void createContext()
        {
            _context = new Context();
        }
    }
}
