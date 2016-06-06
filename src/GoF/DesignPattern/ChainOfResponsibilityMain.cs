using System;
using GoF.DesignPattern.ChainOfResponsibility;

namespace GoF.DesignPattern
{
    internal class ChainOfResponsibilityMain
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            Handler manager = new Manager(employee);
            Handler buHead = new BuHead();
            Handler coo = new Coo();

            manager.SetSuccessor(buHead);
            buHead.SetSuccessor(coo);

            Console.WriteLine("Employee applied leave for 5 days --->\n");
            employee.ApplyForLeave(5);

            Console.WriteLine("\nEmployee applied leave for 15 days --->\n");
            employee.ApplyForLeave(15);

            Console.WriteLine("\nEmployee applied leave for 29 days --->\n");
            employee.ApplyForLeave(29);

            Console.WriteLine("\nEmployee applied leave for 50 days --->\n");
            employee.ApplyForLeave(50);

        }
    }
}
