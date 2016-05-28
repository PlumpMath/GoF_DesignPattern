//using System;

//namespace GoF.DesignPattern.Strategy
//{
//    /// <summary>
//    /// Here we encapsulated the Fly method in a seperate class and added the reference of it in our Duck base class. Now the Duck Subclass(ToyDuck) who dosent want fly behaviour will not call the fly method and rest of them will.
//    /// This solves the problem of Maintainability. and also ToyDuck who is not supposed to fly, dosent fly.
//    /// But still there is problem. If in future, feature request comes to add the new fly behaviour(FlyWithRocket, FlyAsCarrier), and reference to it in Duck base class. This is not flexible.
//    /// <see cref="StrategyPattern"/> how it solves the problem and is what is called the Strategy Pattern.
//    /// </summary>
//    internal abstract class Duck
//    {
//        protected Flyable Flyable;
//        public string DuckType { get; private set; }
//        public string Color { get; private set; }

//        protected Duck(string duckType, string color, Flyable flyable)
//        {
//            Flyable = flyable;
//            DuckType = duckType;
//            Color = color;
//        }

//        public void Swim()
//        {
//            Console.WriteLine(DuckType + " is swimming");
//        }

//        public void Display()
//        {
//            Console.WriteLine("Hi from - " + DuckType);
//        }
//    }

//    internal class Flyable
//    {
//        public void Fly()
//        {
//            Console.WriteLine("I am flying");
//        }
//    }

//    internal class RedheadDuck : Duck
//    {
//        public RedheadDuck(string duckType, string color, Flyable flyable) : base(duckType, color, flyable)
//        {
//        }

//        public void MakeItFly()
//        {
//            Flyable.Fly();
//        }
//    }

//    internal class MallabuDuck : Duck
//    {
//        public MallabuDuck(string duckType, string color, Flyable flyable) : base(duckType, color, flyable)
//        {
//        }

//        public void MakeItFly()
//        {
//            Flyable.Fly();
//        }
//    }

//    internal class NorthWildDuck : Duck
//    {
//        public NorthWildDuck(string duckType, string color, Flyable flyable) : base(duckType, color, flyable)
//        {
//        }

//        public void MakeItFly()
//        {
//            Flyable.Fly();
//        }
//    }

//    internal class ToyDuck : Duck
//    {
//        public ToyDuck(string duckType, string color, Flyable flyable) : base(duckType, color, flyable)
//        {
//        }
//    }
//}
