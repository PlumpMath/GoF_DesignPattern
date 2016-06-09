using System.Collections.Generic;

namespace GoF.DesignPattern.Visitor
{
    internal class SimUApp
    {
        private readonly List<Duck> _list;

        public SimUApp()
        {
            _list = new List<Duck>();
        }

        public void AddDuckToApp(Duck duck)
        {
            _list.Add(duck);
        }

        public void MakeAllFlyLike(IFlyVisitor visitor)
        {
            foreach (var duck in _list)
            {
                duck.Fly(visitor);
            }
        }

        public void MakeAllQuack()
        {
            foreach (var duck in _list)
            {
                duck.Quack();
            }
        }
    }
}
