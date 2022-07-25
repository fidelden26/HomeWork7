namespace HomeWork7
{
    public class Terminal
    {
        public event Call IncomingСallEvent;
        public Port Port { get; set; }
        public Terminal()
        {
            IncomingСallEvent += IncomingСallMessage;
        }

        public void AssignPort(Port port)
        {
            Port = port;
        }

        public void ConnectToPort(Belarusisians name)
        {
            if (Port.Connection == false)
            {
                Port.Connect(name);
            }
            else
            {
                Console.WriteLine("The terminal is connected to the port.");
            }
        }

        public void DisconnectToPort(Belarusisians name)
        {
            if (Port.Connection == true)
            {
                Port.Disconnect(name);
            }
            else
            {
                Console.WriteLine("The terminal  disconnected from the port.");
            }
        }

        public void OutboundСallToPort(Belarusisians name, string phoneNumber1)
        {
            if (Port.Connection == true)
            {
                if (phoneNumber1 != "")
                {
                    Port.OutboundСall(name, phoneNumber1);
                }
                else
                {
                    Console.WriteLine("You did not enter a phone number.");
                }
            }
            else
            {
                Console.WriteLine("The terminal is not connected to the port");
            }
        }

        public void EndCallToPort(Belarusisians name)
        {
            Port.EndCall(name);
        }

        public void IncomingСall()
        {
            IncomingСallEvent?.Invoke($"Abonent incoming call");
        }

        private static void IncomingСallMessage(string message) // обработчик
        {
            Console.WriteLine(message);
        }
    }
}