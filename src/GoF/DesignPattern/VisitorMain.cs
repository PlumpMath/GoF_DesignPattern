using System;
using GoF.DesignPattern.Visitor;

namespace GoF.DesignPattern
{
    internal class VisitorMain
    {
        public static void Main(string[] args)
        {
            SimUApp app = new SimUApp();
            app.AddDuckToApp(new Mallard());
            app.AddDuckToApp(new RedHead());

            Console.WriteLine("Printing in built Quack beahviour of all Ducks.....\n");
            app.MakeAllQuack();

            Console.WriteLine("\nPrinting new operation of Rocket fly of all Ducks.....\n");
            app.MakeAllFlyLike(new RocketFly());

            Console.WriteLine("\nPrinting new operation of Zig-Zag fly of all Ducks.....\n");
            app.MakeAllFlyLike(new ZigZagFly());
        }
    }
}
