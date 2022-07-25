namespace HomeWork7
{
    public class Calls
    {
        public int Time { get; private set; }
        public string TelephoneNumber { get; private set; }
        public Guid Chek { get; private set; }
        public double Cost2 { get; private set; }

        public Calls(string telephoneNumber, Tariff tariff)
        {
            Random random = new Random();
            Time = random.Next(20);
            TelephoneNumber = telephoneNumber;
            Chek = Guid.NewGuid();
            Cost2 = tariff.Cost * Time;

        }
    }
}