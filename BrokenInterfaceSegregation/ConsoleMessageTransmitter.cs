using System;
using DIP;

namespace BrokenInterfaceSegregation {
    class ConsoleMessageTransmitter : IMessageTransmitter
    {
        public bool build(IMessage buildThisMessage)
        {
            Console.WriteLine("please enter message header. enter 'q' to exit");
            buildThisMessage.Header = Console.ReadLine();
            if(buildThisMessage.Header == "q"){
                return false;
            }

            Console.WriteLine("please enter message body");
            buildThisMessage.Body = Console.ReadLine();
            return true;
        }

        public void Send(IMessage message)
        {
            Console.WriteLine("Header:");
            Console.WriteLine(message.Header);
            Console.WriteLine("Body:");
            Console.WriteLine(message.Body);
            Console.WriteLine();
        }
    }
}