namespace Middleware_Services.Services
{
    public class TextMessageService : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("I'm sending " + message + " as a text.");
        }
    }
}
