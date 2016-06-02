namespace GoF.DesignPattern.Singleton.ThreadSafeAndLazy
{
    internal sealed class Singleton
    {
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            return Nested.Instance;
        }

        private class Nested
        {
            public static readonly Singleton Instance = new Singleton();
        }
    }
}
