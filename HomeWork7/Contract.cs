namespace HomeWork7
{
    public class Contract
    {
        public string Number { get; private set; }
        public Abonent Abonent { get; private set; }
        public Contract(Abonent abonent, string number)
        {
            Abonent = abonent;
            Number = number;
        }
    }
}