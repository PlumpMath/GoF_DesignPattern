using System;

namespace GoF.DesignPattern.Factory.FactoryMethod
{
    internal class Pizza
    {
        protected string Crust;
        protected string Sauce;
        protected string Name;
        protected string Topping;

        public void Prepare()
        {
            Console.WriteLine("Pick Crust : " + Crust);
            Console.WriteLine("Applying sauce : " + Sauce);
            Console.WriteLine("Put toppings : " + Topping);
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 min");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cut into 6 pics");
        }

        public virtual void Box()
        {
            Console.WriteLine("Box the pizza in Cardboard");
        }
    }
}
