using System;

namespace GoF.DesignPattern.ChainOfResponsibility
{
    internal class Coo : Handler
    {
        public override void ApproveLeave(int noOfDays)
        {
            if (noOfDays < 30)
            {
                Console.WriteLine("Leave approved by COO");
            }
            else
            {
                Console.WriteLine("Leave request > 30 days. Violating the company policy. Leave Rejected....");
            }
        }
    }
}
