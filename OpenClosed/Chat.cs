using DIP;

namespace OpenClosed {
    class Chat {
        private IMessageReader _reader;
        private IMessageSender _sender;
        private IMessagesFactory _messagesFactory;
        public Chat(IMessageReader reader, IMessageSender sender, IMessagesFactory messagesFactory) {
            _reader = reader;
            _sender = sender;
            _messagesFactory = messagesFactory;
        }

        public void DOChat(MessageType messageType)
        {
            var readNextMessage = true;

            while(readNextMessage) {
                var message1 = _messagesFactory.create(messageType);
                readNextMessage = _reader.build(message1);
                _sender.Send(message1);
            }
        }
    }
}