using System;
using System.Collections.Generic;

namespace GoF.DesignPattern.Composite
{
    internal class Menu : Component
    {
        private readonly List<Component> _list;
        private readonly string _name;
        private readonly string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
            _list = new List<Component>();
        }

        public new string GetName()
        {
            return _name;
        }

        public new string GetDescription()
        {
            return _description;
        }

        public new void AddMenuItem(Component item)
        {
            _list.Add(item);
        }

        public new void RemoveMenuItem(Component item)
        {
            _list.Remove(item);
        }

        public override void Print()
        {
            Console.WriteLine("****MENU*****  Name : " + _name + ", Description : " + _description + "  *******MENU******");

            foreach (var item in _list)
            {
                item.Print();
            } 
        }
    }
}
