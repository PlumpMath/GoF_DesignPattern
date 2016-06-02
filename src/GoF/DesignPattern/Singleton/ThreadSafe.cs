namespace GoF.DesignPattern.Singleton.ThreadSafe
{
    internal sealed class Singleton
    {
        private static Singleton Instance;
        private static readonly object syncRoot = new object();

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            lock (syncRoot)
            {
                if (Instance == null)
                {
                    Instance = new Singleton();
                }
                return Instance;
            }
        }
    }
}
