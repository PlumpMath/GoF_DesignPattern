namespace GoF.DesignPattern.Singleton.ThreadSafeDoubleChecking
{
    internal sealed class Singleton
    {
        //The variable is declared to be volatile to ensure that assignment to the instance variable completes before the instance variable can be accessed.
        private static volatile Singleton Instance;
        private static readonly object syncRoot = new object();

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                lock (syncRoot)
                {
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                    }
                }
            }
            return Instance;
        }
    }
}
