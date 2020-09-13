using System;

namespace Chat {
    // єтот класс нарушает принцип SRP поскольку отвечает и за форматирование сообщения и за его чтение и за его отправку.
    class ConsoleMessage {
        private string _header;

        private string _body;

        public void Send() {
            Console.WriteLine("Header:");
            Console.WriteLine(_header);
            Console.WriteLine("Body:");
            Console.WriteLine(_body);
        }

        public Boolean build() {
            Console.WriteLine("please enter message header. Enter 'q' to exit.");
            _header = Console.ReadLine();
            if(_header == "q"){
                return false;
            }

            Console.WriteLine("please enter message body");
            _body = Console.ReadLine();

            _body += "\r\n Sincerely yours, Daniil";


            return true;
        }
    }
}