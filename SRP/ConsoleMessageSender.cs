using System;
namespace SRP {
    class ConsoleMessageSender {
        public void Send(Message message) {
            Console.WriteLine("Header:");
            Console.WriteLine(message.Header);
            Console.WriteLine("Body:");
            Console.WriteLine(message.Body);
            Console.WriteLine();
        }
    }
}