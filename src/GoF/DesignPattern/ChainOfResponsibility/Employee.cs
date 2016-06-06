using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// This is our client class. It will usally have a reference of Handler class but in this example since we have used event we didnt got a need for it.
    /// </summary>
    internal class Employee
    {
        public event EventHandler<LeaveEventArgs> LeaveRequest; 
        public void ApplyForLeave(int days)
        {
            if (LeaveRequest != null)
            {
                LeaveRequest(this, new LeaveEventArgs(days));
            }
        }
    }

    internal class LeaveEventArgs : EventArgs
    {
        public int Days { get; set; }

        public LeaveEventArgs(int days)
        {
            Days = days;
        }
    }
}
