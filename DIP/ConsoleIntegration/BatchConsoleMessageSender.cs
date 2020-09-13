using System;
using System.Collections.Generic;

namespace DIP.ConsoleIntegration {
    class BatchConsoleMessageSender : IMessageSender {
        private Queue<IMessage> messagesToSend = new Queue<IMessage>();

        public void Send(IMessage message) {
            messagesToSend.Enqueue(message);

            if(messagesToSend.Count == 3) {
                Console.WriteLine("Sending 3 messages:");
                
                for(int i = 0; i < 3; i++) {
                    var index = i + 1;
                    var messageToSend = messagesToSend.Dequeue();
                    Console.WriteLine(index + ". Header:");
                    Console.WriteLine(messageToSend.Header);
                    Console.WriteLine(index + ".Body:");
                    Console.WriteLine(messageToSend.Body);
                    Console.WriteLine();
                }
            }
        }
    }
}