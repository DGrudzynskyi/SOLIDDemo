using System;

namespace DIP.ConsoleIntegration {
    class ConsoleMessageSender : IMessageSender {
        public void Send(IMessage message) {
            Console.WriteLine("Header:");
            Console.WriteLine(message.Header);
            Console.WriteLine("Body:");
            Console.WriteLine(message.Body);
            Console.WriteLine();
        }
    }
}