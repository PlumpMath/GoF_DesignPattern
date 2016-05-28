//using System;

//namespace GoF.DesignPattern.Strategy
//{
//    /// <summary>
//    /// Here we scooped out the Fly method and added to a seperate interface. Now all duck that has fly behaviour can implement htis interface. But this has the same problem of maintainance. We did the same thing as before. We have to do something such that change in fly behaviour should be independent and should mot affect rest of the application.
//    /// What can be done is to Encapsulate the Fly method in a class instead of using interface and then add the refernce of this class in the Duck class(ToyClass)
//    /// With this if any change needs to be made in fly method it will be in the Fly class and not the Duck classes that compose it. <see cref="EvolvingToStrategy4"/> how to implement it.
//    /// </summary>
//    internal abstract class Duck
//    {
//        public string DuckType { get; private set; }
//        public string Color { get; private set; }

//        protected Duck(string duckType, string color)
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

//    internal interface IFlyable
//    {
//        void Fly();
//    }

//    internal class RedheadDuck : Duck, IFlyable
//    {
//        public RedheadDuck(string duckType, string color) : base(duckType, color)
//        {
//        }

//        public void Fly()
//        {
//            Console.WriteLine(DuckType + " is flying...");
//        }
//    }

//    internal class MallabuDuck : Duck, IFlyable
//    {
//        public MallabuDuck(string duckType, string color) : base(duckType, color)
//        {
//        }

//        public void Fly()
//        {
//            Console.WriteLine(DuckType + " is flying...");
//        }
//    }

//    internal class NorthWildDuck : Duck, IFlyable
//    {
//        public NorthWildDuck(string duckType, string color) : base(duckType, color)
//        {
//        }

//        public void Fly()
//        {
//            Console.WriteLine(DuckType + " is flying...");
//        }
//    }

//    internal class ToyDuck : Duck
//    {
//        public ToyDuck(string duckType, string color) : base(duckType, color)
//        {
//        }
//    }
//}
