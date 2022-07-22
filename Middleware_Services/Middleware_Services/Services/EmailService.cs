namespace Middleware_Services.Services
{
    public class EmailService : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("I'm sending " + message + " as a mail.");
        }
    }
}
