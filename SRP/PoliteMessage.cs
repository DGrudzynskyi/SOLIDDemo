namespace SRP {
    class PoliteMessage {
        private string _body;

        public string Header {get; set;}

        public string Body { get => _body; set => _body = value + "\r\n Sincerely Yours, Daniil";}
    }
}