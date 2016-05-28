//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GoF.DesignPattern.Strategy
//{
//    /// <summary>
//    /// Fly method was added in Duck base class. But there is a problem. All ducks got the flying capability even if they dome(ToyDuck)are not supposed to fly. 
//    /// One can argue that they can overrride the fly method in Duck class that dont fly and do nothing in that method. But this breaks the basic idea of reusablity. 
//    /// Some can say that they can simply add the method Fly in the respective Duck class(ToyDuck). But this will be a maintainance nightmare. Requirements come to slightly modify Fly behaviour. Just think how difficult of task it will be to trace down all the class that has this Fly method and to modify it.
//    /// <see cref="EvolvingToStrategy3"/> what is done next.
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

//        public virtual void Fly()
//        {
//            Console.WriteLine(DuckType + " is flying...");
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
