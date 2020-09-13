
namespace SRP {
    class Chat {
        public void DOChat()
        {
            var messageReader = new ConsoleMessageReader();
            var messageSender = new ConsoleMessageSender();

            var readNextMessage = true;

            while(readNextMessage) {
                var message1 = new Message();
                readNextMessage = messageReader.build(message1);
                messageSender.Send(message1);
            }
        }
    }
}