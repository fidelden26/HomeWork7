namespace HomeWork7
{
    public class Abonent
    {
        public Belarusisians Name { get; private set; }
        public Terminal Terminal { get; private set; }
        public List<Calls> CallHistory { get; private set; }

        public Abonent(Belarusisians name)
        {
            Name = name;
            CallHistory = new List<Calls>();
        }

        public void DesignateTerminal(Terminal terminal)
        {
            Terminal = terminal;
        }

        public void ConnectTP()
        {
            Terminal.ConnectToPort(Name);
        }

        public void DisconnectTP()
        {
            Terminal.DisconnectToPort(Name);
        }

        public void OutСall(string phoneNumber1, Tariff tariff)
        {
            Terminal.OutboundСallToPort(Name, phoneNumber1);
            CallHistory.Add(new Calls(phoneNumber1, tariff));
        }

        public void EndCall()
        {
            Terminal.EndCallToPort(Name);
        }
    }
}