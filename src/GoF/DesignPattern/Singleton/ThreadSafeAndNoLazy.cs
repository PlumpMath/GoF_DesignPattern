namespace GoF.DesignPattern.Singleton.ThreadSafeAndNoLazy
{
    internal sealed class Singleton
    {
        /*
         * Uses Static initialization. The instance is created the first time any member of the class is referenced. The CLR takes care of the variable initialization.
         * 
         */
        private static volatile Singleton Instance = new Singleton();

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            return Instance;
        }
    }
}
