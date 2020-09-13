using DIP;
using OpenClosed;

namespace BrokenInterfaceSegregation {
    class Chat {
        private IMessageTransmitter _reader;
        private IMessageTransmitter _sender;
        private IMessagesFactory _messagesFactory;
        public Chat(IMessageTransmitter reader, IMessageTransmitter sender, IMessagesFactory messagesFactory) {
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