//using System;

//namespace GoF.DesignPattern.Strategy
//{

//    /// <summary>
//    /// A simple app where different type of ducks are shown on screen. All ducks inherit from base Duck to enhance reusability.
//    /// 
//    /// Now a requirement comes to add the flying behavior to duck. See <see cref="EvolvingToStrategy2"/> how it is incorporated.
//    /// </summary>
//    internal abstract class Duck
//    {
//        public string DuckType { get; private set; }
//        public string Color { get; private set; }

//        public Duck(string duckType, string color)
//        {
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

//    internal class RedheadDuck : Duck
//    {
//        public RedheadDuck(string duckType, string color) : base(duckType, color)
//        {
//        }
//    }

//    internal class MallabuDuck : Duck
//    {
//        public MallabuDuck(string duckType, string color) : base(duckType, color)
//        {
//        }
//    }

//    internal class NorthWildDuck : Duck
//    {
//        public NorthWildDuck(string duckType, string color) : base(duckType, color)
//        {
//        }
//    }

//    internal class ToyDuck : Duck
//    {
//        public ToyDuck(string duckType, string color) : base(duckType, color)
//        {
//        }
//    }
//}
