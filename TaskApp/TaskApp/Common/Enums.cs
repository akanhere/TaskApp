using System;
using System.Collections.Generic;
using System.Text;

namespace TaskApp.Common
{
    public enum TaskStatus
    {
        Open,
        Assigned,
        ClosedByReporter,
        WaitingOnCustomer,
        Expired,
        Cancelled

    }
}
