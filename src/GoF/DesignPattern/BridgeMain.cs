using GoF.DesignPattern.Bridge;

namespace GoF.DesignPattern
{
    internal class BridgeMain
    {
        public static void Main(string[] args)
        {
            string message = "Hello World !";


            Communication smsCommunication = new Sms(new InBuiltApi());
            smsCommunication.SendMessage(message);

            Communication emailCommunication = new Email(new InBuiltApi());
            emailCommunication.SendMessage(message);

            Communication smsCommunicationUsingExternalAPI = new Sms(new ThirdPartyApi());
            smsCommunicationUsingExternalAPI.SendMessage(message);
        }
    }
}
