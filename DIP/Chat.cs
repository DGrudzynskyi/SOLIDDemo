using DIP.MessageTypes;

namespace DIP
{
    // єтот класс соответствует принципу Interface Segregation и Dependency Inversion, но при єтом он не является 
    // закрытым в терминологии Open-Closed к добавлению нового шаблона письма.
    class Chat
    {
        private IMessageReader _reader;
        private IMessageSender _sender;
        public Chat(IMessageReader reader, IMessageSender sender) {
            _reader = reader;
            _sender = sender;
        }

        public void DOChat(bool bePolite)
        {
            var readNextMessage = true;

            while(readNextMessage) {
                var message1 = bePolite ? (IMessage)new PoliteMessage()  : new Message();
                readNextMessage = _reader.build(message1);
                _sender.Send(message1);
            }
        }
    }
}
