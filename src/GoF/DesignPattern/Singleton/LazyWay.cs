using System;

namespace GoF.DesignPattern.Singleton.LazyWay
{
    internal sealed class Singleton
    {
        private static Lazy<Singleton>  Instance = new Lazy<Singleton>(() => new Singleton());

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            return Instance.Value;
        }
    }
}
