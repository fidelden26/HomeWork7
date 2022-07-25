namespace HomeWork7
{
    public class Tariff
    {
        public string Name { get; private set; }
        public double Cost { get; private set; }

        public Tariff(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public static readonly Tariff Yasna100 = new Tariff(Rates.Yasna100.ToString(), 1);
        public static readonly Tariff YasnaSmart = new Tariff(Rates.YasnaSmart.ToString(), 2);
        public static readonly Tariff ShpicUnlimited = new Tariff(Rates.ShpicUnlimited.ToString(), 3);
        public static readonly Tariff NikAndMikeSay = new Tariff(Rates.NikAndMikeSay.ToString(), 4);

    }
}
