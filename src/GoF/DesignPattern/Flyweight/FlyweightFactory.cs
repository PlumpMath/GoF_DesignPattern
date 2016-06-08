using System.Collections.Generic;

namespace GoF.DesignPattern.Flyweight
{
    internal class FlyweightFactory
    {
        private readonly Dictionary<char, IFlyweight> _flyweights;

        public FlyweightFactory()
        {
            _flyweights = new Dictionary<char, IFlyweight>();
        }

        public IFlyweight GetFlyweight(char key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                if (key == 'A')
                {
                    _flyweights.Add(key, new A());
                }
                if (key == 'B')
                {
                    _flyweights.Add(key, new B());
                }
                if (key == 'Z')
                {
                    _flyweights.Add(key, new Z());
                }
            }

            return _flyweights[key];
        }
    }
}
