
using System;

namespace GoF.DesignPattern.Composite
{
    internal class MenuItem : Component
    {
        private readonly string _name;
        private readonly string _description;
        private readonly int _price;
        private readonly bool _vegetarian;

        public MenuItem(string name, string description, int price, bool isVegetarian)
        {
            _name = name;
            _description = description;
            _price = price;
            _vegetarian = isVegetarian;
        }

        public new string GetName()
        {
            return _name;
        }

        public new string GetDescription()
        {
            return _description;
        }

        public new int GetPrice()
        {
            return _price;
        }

        public new bool IsVegetarian()
        {
            return _vegetarian;
        }

        public override void Print()
        {
            Console.WriteLine("Item : " + _name + ", Price : " + _price + ", Description : " + _description + ", IsVeg : " + _vegetarian);
        }
    }
}
