using DIP;

namespace OpenClosed {
    enum MessageType {
        Regular,
        Polite,
        SALE,
    }

    interface IMessagesFactory {
        IMessage create(MessageType messageType);
    }
}