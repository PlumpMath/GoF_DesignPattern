using System;

namespace GoF.DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// We have made this concrete handler class as the receiver for Leave event from employee. So we needed employee class instance in this so that we can register for Leave event.
    /// </summary>
    internal class Manager : Handler
    {
        public Manager(Employee employee)
        {
            employee.LeaveRequest += Employee_LeaveRequest;
        }

        private void Employee_LeaveRequest(object sender, LeaveEventArgs e)
        {
            ApproveLeave(e.Days);
        }

        public override void ApproveLeave(int noOfDays)
        {
            if (noOfDays < 10)
            {
                Console.WriteLine("Leave approved by manager");
            }
            else
            {
                Console.WriteLine("Leave request > 10 days, manager cannot approve. Forwarding request to BU Head.");
                Successsor.ApproveLeave(noOfDays);
            }
        }
    }
}
