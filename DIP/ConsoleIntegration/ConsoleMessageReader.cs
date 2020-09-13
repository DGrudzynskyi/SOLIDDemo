using System;

namespace DIP.ConsoleIntegration{
    class ConsoleMessageReader : IMessageReader {
        public bool build(IMessage buildThisMessage) {
            Console.WriteLine("please enter message header. enter 'q' to exit");
            buildThisMessage.Header = Console.ReadLine();
            if(buildThisMessage.Header == "q"){
                return false;
            }

            Console.WriteLine("please enter message body");
            buildThisMessage.Body = Console.ReadLine();
            return true;
        }
    }
}