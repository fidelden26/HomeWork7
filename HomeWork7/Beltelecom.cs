namespace HomeWork7
{
    public class Beltelecom
    {
        public List<Contract> Contracts { get; set; }
        public List<Port> Ports { get; set; }
        public List<Terminal> Terminals { get; set; }

        public Beltelecom()
        {
            Contracts = new List<Contract>();
            Ports = new List<Port>();
            Terminals = new List<Terminal>();
        }


        public Contract NewContract(Abonent abonent)
        {
            Random random = new Random();
            Contract contract = new Contract(abonent, "+37533" + random.Next(1000000, 9999999).ToString());
            Contracts.Add(contract);
            Port port = new Port();
            Ports.Add(port);
            port.PortEvent += Message;
            port.CallEvent += PortCall;
            Terminals.Add(new Terminal());
            return contract;
        }

        public Terminal TakeTerminal(Contract contract)
        {
            var index = Contracts.FindIndex(x => x == contract);
            return Terminals[index];
        }

        public Port TakePort(Contract contract)
        {
            var index = Contracts.FindIndex(x => x == contract);
            return Ports[index];
        }

        private static void Message(string message)    // обработчик
        {
            Console.WriteLine(message);
        }

        //Обработчик
        private void PortCall(string message, string phoneNumber)
        {
            Console.WriteLine(message);
            var indexSubscriber = Contracts.FindIndex(x => x.Number == phoneNumber);

            if (indexSubscriber == -1)
            {
                Console.WriteLine("You entered an incorrect phone number");
            }
            else if (Ports[indexSubscriber].Connection == true)
            {
                if (Ports[indexSubscriber].Talk == false)
                {
                    Ports[indexSubscriber].IncomingCall(phoneNumber, Terminals[indexSubscriber]);
                }
                else
                {
                    Console.WriteLine("Line is busy.");
                }
            }
            else
            {
                Console.WriteLine("The terminal is not connected to the port.");
            }
        }

    }
}