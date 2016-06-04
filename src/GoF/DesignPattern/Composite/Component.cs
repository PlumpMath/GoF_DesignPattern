using System;

namespace GoF.DesignPattern.Composite
{
    internal abstract class Component
    {
        public string GetName()
        {
            throw new NotImplementedException();
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public int GetPrice()
        {
            throw new NotImplementedException();
        }

        public bool IsVegetarian()
        {
            throw new NotImplementedException();
        }

        public void AddMenuItem(Component item)
        {
            throw new NotImplementedException();
        }

        public void RemoveMenuItem(Component item)
        {
            throw new NotImplementedException();
        }

        public abstract void Print();
    }
}
