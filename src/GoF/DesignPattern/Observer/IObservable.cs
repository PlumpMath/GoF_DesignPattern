namespace GoF.DesignPattern.Observer
{
    internal interface IObservable
    {
        void Register(IObserver observer);
        void UnRegister(IObserver observer);
    }
}
