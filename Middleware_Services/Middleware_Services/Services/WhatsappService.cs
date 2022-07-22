namespace Middleware_Services.Services
{
    public class WhatsappService : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("I'm sending " + message + " via whatsapp.");
        }
    }
}
