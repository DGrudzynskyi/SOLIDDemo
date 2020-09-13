using System;
using System.Collections.Generic;
using DIP;

namespace OpenClosed {
    class DefaultMessagesFactory : IMessagesFactory
    {
        private Dictionary<MessageType, Type> _registeredTypes = new Dictionary<MessageType, Type>() {
            {MessageType.Regular, typeof(DIP.MessageTypes.Message)},
            {MessageType.Polite, typeof(DIP.MessageTypes.PoliteMessage)},
            {MessageType.SALE, typeof(DIP.MessageTypes.Message)}
        };

        public IMessage create(MessageType messageType)
        {
            return Activator.CreateInstance(_registeredTypes[messageType]) as IMessage;
        }
    }
}