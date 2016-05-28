using System;

namespace GoF.DesignPattern.Strategy
{
    /// <summary>
    /// A fly method is scooped out and Encapsulated in a seperate class which inherites from the base FlyBehaviour class.
    /// Strategy here is implemented as an interface but it can also be done with Abstract class.
    /// It promotes 1. Loose Coupling 2. Favor Composition over Inheritance 3. Program to interface not implementation 4. Encapsulate what varies. 
    /// </summary>
    internal abstract class Duck
    {
        protected IFlyableBehaviour Flyable;
        public string DuckType { get; private set; }
        public string Color { get; private set; }

        internal IFlyableBehaviour IFlyableBehaviour
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        protected Duck(string duckType, string color, IFlyableBehaviour flyable)
        {
            Flyable = flyable;
            DuckType = duckType;
            Color = color;
        }

        public void Swim()
        {
            Console.WriteLine(DuckType + " is swimming");
        }

        public void Display()
        {
            Console.WriteLine("Hi from - " + DuckType);
        }

        public void MakeItFly()
        {
            Flyable.Fly();
        }
    }

    internal interface IFlyableBehaviour
    {
        void Fly();
    }
    internal class FlyWithRocket : IFlyableBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am flying like Rocket");
        }
    }
    internal class FlyAsCarrier : IFlyableBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with Carrier");
        }
    }

    internal class NoFly : IFlyableBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I cant Fly");
        }
    }

    internal class RedheadDuck : Duck
    {
        public RedheadDuck(string duckType, string color, IFlyableBehaviour flyable) : base(duckType, color, flyable)
        {
        }
    }

    internal class MallabuDuck : Duck
    {
        public MallabuDuck(string duckType, string color, IFlyableBehaviour flyable) : base(duckType, color, flyable)
        {
        }
    }

    internal class NorthWildDuck : Duck
    {
        public NorthWildDuck(string duckType, string color, IFlyableBehaviour flyable) : base(duckType, color, flyable)
        {
        }
    }

    internal class ToyDuck : Duck
    {
        public ToyDuck(string duckType, string color, IFlyableBehaviour flyable) : base(duckType, color, flyable)
        {
        }
    }
}
