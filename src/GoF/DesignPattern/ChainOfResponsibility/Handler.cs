namespace GoF.DesignPattern.ChainOfResponsibility
{
    internal abstract class Handler
    {
        protected Handler Successsor;

        public void SetSuccessor(Handler successsor)
        {
            Successsor = successsor;
        }

        public abstract void ApproveLeave(int noOfDays);
    }
}
