using GoF.DesignPattern.Strategy;

namespace GoF.DesignPattern
{
    internal class StrategyMain
    {
        public static void Main()
        {
            Duck redHeaDuck = new RedheadDuck("RedHead", "Red", new FlyWithRocket());
            redHeaDuck.Display();
            redHeaDuck.MakeItFly();

            Duck toyDuck = new ToyDuck("Toy", "Blue", new NoFly());
            toyDuck.Display();
            toyDuck.MakeItFly();
        }
    }
}
