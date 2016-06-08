namespace GoF.DesignPattern.Bridge
{
    internal abstract class Communication
    {
        protected IApis Api;

        protected Communication(IApis api)
        {
            Api = api;
        }

        public abstract void SendMessage(string message);
    }
}
