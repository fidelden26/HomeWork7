namespace HomeWork7
{
    public class Port
    {
        public bool Connection { get; private set; } = false;
        public bool Talk { get; private set; } = false;

        public event PortHendler PortEvent;
        public event CallHendler CallEvent;

        public void Connect(Belarusisians name)
        {
            Connection = true;
            PortEvent?.Invoke($"Abonent " + name + " connected the terminal to the port.");
        }

        public void Disconnect(Belarusisians name)
        {
            Connection = false;
            PortEvent?.Invoke($"Abonent " + name + " disconnected the terminal from the port.");
        }

        public void OutboundСall(Belarusisians name, string phoneNumber1)
        {
            Talk = true;
            CallEvent?.Invoke($"Abonent " + name + " calls the caller by phone number " + phoneNumber1, phoneNumber1);
        }


        public void IncomingCall(string phoneNumber1, Terminal terminal1)
        {
            Talk = true;
            terminal1.IncomingСall();
        }

        public void EndCall(Belarusisians name)
        {
            Talk = false;
            PortEvent?.Invoke($"Abonent " + name + " the call ended.");
        }
    }
}