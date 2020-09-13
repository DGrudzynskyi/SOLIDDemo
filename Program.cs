using System;
using BrokenInterfaceSegregation;
using DIP.ConsoleIntegration;
using LiscovSubstitution;
using OpenClosed;

namespace Chat
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     var readNextMessage = true;
        //     while(readNextMessage) {
        //     var message1 = new ConsoleMessage();
        //         readNextMessage = message1.build();
        //         message1.Send();
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     var chat = new SRP.Chat();
        //     chat.DOChat();

        //     Console.Read();
        // }


        // static void Main(string[] args)
        // {
        //     var chat = new DIP.Chat(new ConsoleMessageReader(), new ConsoleMessageSender());
        //     chat.DOChat(true);

        //     Console.Read();
        // }

        // static void Main(string[] args)
        // {
        //     var chat = new OpenClosed.Chat(new ConsoleMessageReader(), new ConsoleMessageSender(), new DefaultMessagesFactory());
        //     chat.DOChat(MessageType.SALE);

        //     Console.Read();
        // }

        // с заменой отправителя на батч отправитель
        // static void Main(string[] args)
        // {
        //     var chat = new OpenClosed.Chat(new ConsoleMessageReader(), new BatchConsoleMessageSender(), new DefaultMessagesFactory());
        //     chat.DOChat(MessageType.SALE);

        //     Console.Read();
        // }

        // static void Main(string[] args)
        // {
        //     var chat = new BrokenInterfaceSegregation.Chat(
        //         new ConsoleMessageTransmitter(), 
        //         new BatchConsoleMessageTransmitter(), 
        //         new DefaultMessagesFactory()
        //     );
        //     chat.DOChat(MessageType.SALE);

        //     Console.Read();
        // }

        static void Main(string[] args)
        {
            var rectangle = new Rectangle(5,6);
            rectangle.Height = 2;
            rectangle.Length = 8;

            LiscovSubstitution.RectangleChecker.CheckIt(rectangle);
        }
    }
}
