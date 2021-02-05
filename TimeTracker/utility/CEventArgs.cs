using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.backend;

namespace TimeTracker.utility
{
    public class CEventArgs
    {
        public class ManagerEventArgs : EventArgs
        {
            public Employee Manager { get; }

            public ManagerEventArgs(Employee e)
            {
                Manager = e;
            }
        }

        public class OptionsSavedEventArgs : EventArgs
        {
            public Employee Employee { get; }

            public OptionsSavedEventArgs(Employee e)
            {
                Employee = e;
            }
        }
    }
}
