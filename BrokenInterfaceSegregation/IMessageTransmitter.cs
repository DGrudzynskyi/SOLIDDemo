using DIP;

namespace BrokenInterfaceSegregation {
    interface IMessageTransmitter {
        bool build(IMessage buildThisMessage);
        void Send(IMessage message);
    }
}