using System;

namespace GoF.DesignPattern.ChainOfResponsibility
{
    internal class BuHead : Handler
    {
        public override void ApproveLeave(int noOfDays)
        {
            if (noOfDays < 20)
            {
                Console.WriteLine("Leave approved by BU Head");
            }
            else
            {
                Console.WriteLine("Leave request > 20 days, BU Head cannot approve. Forwarding request to COO.");
                Successsor.ApproveLeave(noOfDays);
            }
        }
    }
}
